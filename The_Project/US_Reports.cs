using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp8
{
    public partial class US_Reports : UserControl

    {
        int selectedRowId = -1;
        string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=\"Toyota system\";Integrated Security=True";
        PrintDocument printDocument = new PrintDocument();
        //"SELECT partname, partinstock, service, serviceinstock, carmodel, carinstock FROM inventory"
        void LoadInventoryData()
        {
            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT id AS ID ,partname AS Partsname, partinstock AS PartInStock, service AS Service, serviceinstock AS ServiceInStock, carmodel AS CarsModel, carinstock AS CarInStock FROM inventory";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
                dataGridView3.Columns["id"].Visible=false;

            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Inventory") // أو استخدم SelectedIndex
            {
                LoadInventoryData();
            }
        }
        void Searchitem(string keyword)
        {
            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT id AS ID ,partname AS Partsname, partinstock AS PartInStock, service AS Service, serviceinstock AS ServiceInStock, carmodel AS CarsModel, carinstock AS CarInStock
                FROM inventory
                 WHERE CAST(id AS NVARCHAR) LIKE @search ";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + keyword + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.AutoGenerateColumns = true;
                dataGridView3.DataSource = dt;
                dataGridView3.Columns["editi"].DisplayIndex = dataGridView1.Columns.Count - 1;
            }
        }
        public US_Reports()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void LoadCustomerNames()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Username FROM Customers";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow empty = dt.NewRow();
                empty["Username"] = "";
                dt.Rows.InsertAt(empty, 0);
                cmbBoxCustomerName.DataSource = dt;
                cmbBoxCustomerName.DisplayMember = "Username";
                cmbBoxCustomerName.ValueMember = "Username";
                cmbBoxCustomerName.SelectedIndex = 0;
            }
        }

        private void LoadInvoices()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT customername, item, description, quantity, unitprice, totalprice, date FROM invoices";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewInvoices.DataSource = dt;
            }
        }

        private void US_Reports_Load(object sender, EventArgs e)
        {
            LoadCustomerNames();
            LoadInvoices();
            LoadInventoryData();

            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id AS [Part ID], partname AS [Part Name], partinstock AS [Quantity] FROM inventory";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView5.DataSource = dt; // غيّر الاسم لو مش dataGridView1
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }

           
        }

        private decimal CalculateTotalPrice()
        {
            decimal unitPrice = 0;
            decimal quantity = 0;

            try
            {
                unitPrice = decimal.Parse(txtUnitPrice.Text);
                quantity = decimal.Parse(txtQuantity.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for Quantity and Unit Price.");
                return 0;
            }

            return Math.Round(unitPrice * quantity, 2);
        }

        private void btnPrintInvoices_Click(object sender, EventArgs e)
        {
            // تأكد من تعبئة الحقول المطلوبة
            if (string.IsNullOrWhiteSpace(cmbBoxCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                MessageBox.Show("Please ensure all fields are filled out.");
                return;
            }

            int quantity;
            decimal unitPrice;

            if (!int.TryParse(txtQuantity.Text, out quantity) || !decimal.TryParse(txtUnitPrice.Text, out unitPrice))
            {
                MessageBox.Show("Invalid data entered for Quantity or Unit Price.");
                return;
            }

            decimal total = quantity * unitPrice;

            // رسالة اختيار: حفظ فقط أم حفظ و طباعة
            DialogResult result = MessageBox.Show("Do you want to save and print the invoice?\nYes: Save & Print\nNo: Save only", "Save or Print?", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Cancel) return;

            // حفظ الفاتورة في قاعدة البيانات
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO invoices (customername, item, description, quantity, unitprice, totalprice, date) VALUES (@customerName, @item, @description, @quantity, @unitPrice, @total, @date)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@customerName", cmbBoxCustomerName.Text);
                    cmd.Parameters.AddWithValue("@item", cmbBoxItem.Text);
                    cmd.Parameters.AddWithValue("@description", cmbBoxDescription.Text);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@unitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker.Value);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Invoice saved successfully!");
                    LoadInvoices();
                }
            }

            // لو اختار الطباعة
            if (result == DialogResult.Yes)
            {
                if (PrinterSettings.InstalledPrinters.Count > 0)
                {
                    try
                    {
                        printDocument.Print();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Printing failed: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("No printers are installed. Invoice saved only.");
                }
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 12);
            float yPos = 100;
            int leftMargin = 50;
            float lineSpacing = 30;

            // العنوان
            e.Graphics.DrawString("Invoice", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += lineSpacing * 2;

            // المعلومات
            e.Graphics.DrawString("Customer: " + cmbBoxCustomerName.Text, bodyFont, Brushes.Black, leftMargin, yPos); yPos += lineSpacing;
            e.Graphics.DrawString("Item: " + cmbBoxItem.Text, bodyFont, Brushes.Black, leftMargin, yPos); yPos += lineSpacing;
            e.Graphics.DrawString("Description: " + cmbBoxDescription.Text, bodyFont, Brushes.Black, leftMargin, yPos); yPos += lineSpacing;
            e.Graphics.DrawString("Quantity: " + txtQuantity.Text, bodyFont, Brushes.Black, leftMargin, yPos); yPos += lineSpacing;
            e.Graphics.DrawString("Unit Price: " + txtUnitPrice.Text, bodyFont, Brushes.Black, leftMargin, yPos); yPos += lineSpacing;

            // الإجمالي
            if (decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice) && int.TryParse(txtQuantity.Text, out int quantity))
            {
                decimal total = unitPrice * quantity;
                e.Graphics.DrawString("Total Price: " + total.ToString("C"), bodyFont, Brushes.Black, leftMargin, yPos);
                yPos += lineSpacing;
            }

            // التاريخ
            e.Graphics.DrawString("Date: " + dateTimePicker.Value.ToShortDateString(), bodyFont, Brushes.Black, leftMargin, yPos);
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // ضع هنا الكود الذي تريده عند تغيير التاريخ
            MessageBox.Show("تم تغيير التاريخ إلى: " + dateTimePicker.Value.ToShortDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbBoxCustomerName.SelectedIndex = 0;
            cmbBoxDescription.SelectedIndex = -1;
            cmbBoxItem.SelectedIndex = -1;
            txtQuantity.Text = "";
            txtUnitPrice.Text = "";
            dateTimePicker.Value = DateTime.Today;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox7.Text))
                Searchitem(textBox7.Text);
            else
                LoadInventoryData();
        }
        //partname AS Partsname, partinstock AS PartInStock, service AS Service, serviceinstock AS ServiceInStock, carmodel AS CarsmMdel, carinstock AS CarInStock
        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True");

            string partsname = string.IsNullOrWhiteSpace(textBox1.Text) ? null : textBox1.Text;
            string partInStock = string.IsNullOrWhiteSpace(textBox2.Text) ? null : textBox2.Text;
            string service = string.IsNullOrWhiteSpace(textBox3.Text) ? null : textBox3.Text;
            string serviceInStock = string.IsNullOrWhiteSpace(textBox4.Text) ? null : textBox4.Text;
            string carModel = string.IsNullOrWhiteSpace(textBox5.Text) ? null : textBox5.Text;
            string carInStock = string.IsNullOrWhiteSpace(textBox6.Text) ? null : textBox6.Text;

            // بناء شرط WHERE ديناميكي
            List<string> conditions = new List<string>();
            if (partsname != null) conditions.Add("partname IS NULL");
            if (partInStock != null) conditions.Add("partinstock IS NULL");
            if (service != null) conditions.Add("service IS NULL");
            if (serviceInStock != null) conditions.Add("serviceinstock IS NULL");
            if (carModel != null) conditions.Add("carmodel IS NULL");
            if (carInStock != null) conditions.Add("carinstock IS NULL");

            string whereClause = string.Join(" AND ", conditions);

            SqlCommand cmd;
            if (!string.IsNullOrEmpty(whereClause))
            {
                cmd = new SqlCommand($@"
            UPDATE TOP (1) inventory
            SET 
                partname = ISNULL(partname, @Partsname), 
                partinstock = ISNULL(partinstock, @PartInStock), 
                service = ISNULL(service, @Service), 
                serviceinstock = ISNULL(serviceinstock, @ServiceInStock), 
                carmodel = ISNULL(carmodel, @CarsModel), 
                carinstock = ISNULL(carinstock, @CarInStock)
            WHERE {whereClause}", con);
            }
            else
            {
                cmd = null;
            }

            if (cmd != null)
            {
                cmd.Parameters.AddWithValue("@Partsname", (object?)partsname ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PartInStock", (object?)partInStock ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Service", (object?)service ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ServiceInStock", (object?)serviceInStock ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CarsModel", (object?)carModel ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CarInStock", (object?)carInStock ?? DBNull.Value);
            }

            try
            {
                con.Open();
                int rowsAffected = cmd != null ? cmd.ExecuteNonQuery() : 0;

                if (rowsAffected == 0)
                {
                    SqlCommand insertCmd = new SqlCommand(@"
                INSERT INTO inventory 
                (partname, partinstock, service, serviceinstock, carmodel, carinstock)
                VALUES (@Partsname, @PartInStock, @Service, @ServiceInStock, @CarsModel, @CarInStock)", con);

                    insertCmd.Parameters.AddWithValue("@Partsname", (object?)partsname ?? DBNull.Value);
                    insertCmd.Parameters.AddWithValue("@PartInStock", (object?)partInStock ?? DBNull.Value);
                    insertCmd.Parameters.AddWithValue("@Service", (object?)service ?? DBNull.Value);
                    insertCmd.Parameters.AddWithValue("@ServiceInStock", (object?)serviceInStock ?? DBNull.Value);
                    insertCmd.Parameters.AddWithValue("@CarsModel", (object?)carModel ?? DBNull.Value);
                    insertCmd.Parameters.AddWithValue("@CarInStock", (object?)carInStock ?? DBNull.Value);

                    insertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("تمت الإضافة أو التعديل بنجاح!");
                LoadInventoryData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حصل خطأ: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }


        private void dataGridView3_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView3.Columns[e.ColumnIndex].Name == "editi")
            {
                DataGridViewRow row = dataGridView3.Rows[e.RowIndex];

                if (row.Cells["id"].Value != DBNull.Value)
                {
                    selectedRowId = Convert.ToInt32(row.Cells["id"].Value);
                }

                // باقي القيم
                textBox1.Text = row.Cells["Partsname"].Value?.ToString();
                textBox2.Text = row.Cells["PartInStock"].Value?.ToString();
                textBox3.Text = row.Cells["Service"].Value?.ToString();
                textBox4.Text = row.Cells["ServiceInStock"].Value?.ToString();
                textBox5.Text = row.Cells["CarsModel"].Value?.ToString();
                textBox6.Text = row.Cells["CarInStock"].Value?.ToString();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (selectedRowId == -1)
            {
                MessageBox.Show("اختر صف أولاً للتعديل.");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(@"UPDATE inventory SET 
            partname = @Partsname,
            partinstock = @PartInStock,
            service = @Service,
            serviceinstock = @ServiceInStock,
            carmodel = @CarModel,
            carinstock = @CarInStock
            WHERE id = @Id", con);

                cmd.Parameters.AddWithValue("@Partsname", textBox1.Text);
                cmd.Parameters.AddWithValue("@PartInStock", textBox2.Text);
                cmd.Parameters.AddWithValue("@Service", textBox3.Text);
                cmd.Parameters.AddWithValue("@ServiceInStock", textBox4.Text);
                cmd.Parameters.AddWithValue("@CarModel", textBox5.Text);
                cmd.Parameters.AddWithValue("@CarInStock", textBox6.Text);
                cmd.Parameters.AddWithValue("@Id", selectedRowId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("تم التعديل بنجاح.");
                LoadInventoryData();
                selectedRowId = -1;
            }
        }


        private void Delete_Click_1(object sender, EventArgs e)
        {
            if (selectedRowId == -1)
            {
                MessageBox.Show("اختر صف أولاً للحذف.");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM inventory WHERE id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", selectedRowId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("تم الحذف بنجاح.");
                LoadInventoryData();
                selectedRowId = -1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker4.Value.Date;
            DateTime toDate = dateTimePicker5.Value.Date;

            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT ID AS [Order ID], 
                            customername AS [Customer Name], 
                            servicerequested AS [Service Requested], 
                            carmodel AS [Car Model], 
                            cost AS [Cost], 
                            date AS [Service Date]
                     FROM [Maintenance Services]
                     WHERE date BETWEEN @FromDate AND @ToDate";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("لا يوجد مبيعات في هذا التاريخ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView2.DataSource = null;
                        label13.Text = "Total Revenue : 0 pound";
                        return;
                    }

                    dataGridView2.DataSource = table;

                    decimal totalRevenue = 0;
                    foreach (DataRow row in table.Rows)
                    {
                        if (decimal.TryParse(row["Cost"].ToString(), out decimal cost))
                        {
                            totalRevenue += cost;
                        }
                    }
                    label13.Text = $"Total Revenue : {totalRevenue} pound";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dateTimePicker4.Value = DateTime.Today;
            dateTimePicker5.Value = DateTime.Today;

            // تفريغ الداتا جريد والنتيجة
            dataGridView4.DataSource = null;
            label13.Text = "Total Revenue : 0 pound";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker6.Value.Date;
            DateTime toDate = dateTimePicker7.Value.Date;

            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT [car id] AS [Car ID], 
                            customername AS [Customer Name],  
                            model AS [Car Model], 
                            price AS Cost, 
                            date AS [Sale Date]
                     FROM Cars
                     WHERE date BETWEEN @FromDate AND @ToDate";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("لا يوجد مبيعات في هذا التاريخ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView4.DataSource = null;
                        label17.Text = "Total Revenue : 0 pound";
                        return;
                    }

                    dataGridView4.DataSource = table;

                    decimal totalRevenue = 0;
                    foreach (DataRow row in table.Rows)
                    {
                        if (decimal.TryParse(row["Cost"].ToString(), out decimal cost))
                        {
                            totalRevenue += cost;
                        }
                    }
                    label17.Text = $"Total Revenue : {totalRevenue} pound";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dateTimePicker6.Value = DateTime.Today;
            dateTimePicker7.Value = DateTime.Today;

            // تفريغ الداتا جريد والنتيجة
            dataGridView4.DataSource = null;
            label17.Text = "Total Revenue : 0 pound";
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker2.Value.Date;
            DateTime toDate = dateTimePicker3.Value.Date;

            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT name AS [Part Name], 
                            Quantitysold AS [Quantity Soid],    
                            Price AS Cost, 
                            date AS Date
                     FROM Spare_Parts
                     WHERE date BETWEEN @FromDate AND @ToDate";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("لا يوجد مبيعات في هذا التاريخ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                        label14.Text = "Total Revenue : 0 pound";
                        return;
                    }

                    dataGridView1.DataSource = table;

                    decimal totalRevenue = 0;
                    foreach (DataRow row in table.Rows)
                    {
                        if (decimal.TryParse(row["Cost"].ToString(), out decimal cost))
                        {
                            totalRevenue += cost;
                        }
                    }
                    label14.Text = $"Total Revenue : {totalRevenue} pound";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker3.Value = DateTime.Today;

            // تفريغ الداتا جريد والنتيجة
            dataGridView1.DataSource = null;
            label14.Text = "Total Revenue : 0 pound";
        }

        private void tabAlerts_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // تحميل بيانات جدول الإنفنتوري
                    string query = "SELECT id AS [Part ID], partname AS [Part Name], partinstock AS [Quantity] FROM inventory";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // فلترة التنبيهات (كمية أقل من 10)
                    var lowStockRows = dt.Select("Quantity < 10");

                    if (lowStockRows.Length > 0)
                    {
                        string warningText = "تنبيه: الكمية قليلة لقطع الغيار التالية:\n";
                        foreach (var row in lowStockRows)
                        {
                            warningText += $"- {row["Part Name"]} (الكمية: {row["Quantity"]})\n";
                        }
                        label18.Text = warningText;
                        label18.ForeColor = Color.Red;
                        label18.Visible = true;
                    }
                    else
                    {
                        label18.Text = "";
                        label18.Visible = false;
                    }

                    // تحديث جدول التنبيهات (لو فيه DataGridView مخصص ليها)
                    DataTable alertTable = dt.Clone(); // نفس الأعمدة
                    foreach (var row in lowStockRows)
                        alertTable.ImportRow(row);

                    dataGridView5.DataSource = alertTable; // غيّر الاسم حسب ما هو عندك

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}