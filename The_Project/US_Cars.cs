using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class US_Cars : UserControl
    {
        string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
        public US_Cars()
        {
            InitializeComponent();

        }
        void LoadAllCars()
        {
            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT [car id] AS ID, model AS Model, Status, price AS Price,date AS Date,customername AS Customername ,Quantitysold AS QuantitySold FROM Cars";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridCars.DataSource = dt;
                dataGridCars.Columns["Edit"].DisplayIndex = 0; 

            }
        }
        private void Loadcars()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT carmodel FROM Inventory";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow empty = dt.NewRow();
                empty["carmodel"] = "";
                dt.Rows.InsertAt(empty, 0);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "carmodel";
                comboBox1.ValueMember = "carmodel";
                comboBox1.SelectedIndex = 0;
            }
        }

        private void US_Cars_Load(object sender, EventArgs e)
        {
            LoadAllCars();
            Loadcars();



        }
        void SearchCars(string keyword)
        {
            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT [car id] AS ID, model AS Model, Status, price AS Price ,date AS Date,customername AS Customername,Quantitysold AS QuantitySold
                 FROM Cars
                 WHERE CAST([car id] AS NVARCHAR) LIKE @search OR model LIKE @search";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + keyword + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridCars.AutoGenerateColumns=false;
                dataGridCars.DataSource = dt;
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                SearchCars(txtSearch.Text);
            else
                LoadAllCars();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void LoadCars()
        {
            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT [car id], model, Status, price,date,customername,Quantitysold FROM Cars", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridCars.DataSource = dt;
            }
        }

        private void addcar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. إدخال بيانات العربية
                    string insertQuery = "INSERT INTO Cars ([car id], model, Status, price, date, customername, Quantitysold) " +
                                         "VALUES (@id, @model, @status, @price, @Date, @Customername, @QuantitySold)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn, transaction);
                    cmd.Parameters.AddWithValue("@id", txtcarid.Text);
                    cmd.Parameters.AddWithValue("@model", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@status", txtstatus.Text);
                    cmd.Parameters.AddWithValue("@price", txtprice.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Customername", txtcustomername.Text);
                    cmd.Parameters.AddWithValue("@QuantitySold", numericUpDown1.Value);

                    cmd.ExecuteNonQuery();

                    // 2. تقليل المخزون من جدول inventory
                    string updateInventory = "UPDATE inventory SET carinstock = carinstock - @qty WHERE carmodel = @model";
                    SqlCommand updateCmd = new SqlCommand(updateInventory, conn, transaction);
                    updateCmd.Parameters.AddWithValue("@qty", numericUpDown1.Value);
                    updateCmd.Parameters.AddWithValue("@model", comboBox1.Text);
                    updateCmd.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("تمت الإضافة وتحديث المخزون بنجاح!");
                    LoadCars();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("حصل خطأ أثناء الإضافة: " + ex.Message);
                }
            }
        }

        private void dataGridCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridCars.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridCars.Rows[e.RowIndex];

                txtcarid.Text = row.Cells["CarID"].Value.ToString();
                comboBox1.Text = row.Cells["CarModel"].Value.ToString();
                txtstatus.Text = row.Cells["Status"].Value.ToString();
                txtprice.Text = row.Cells["Price"].Value.ToString();
                txtcustomername.Text = row.Cells["Customername"].Value.ToString();
                dateTimePicker1.Value =Convert.ToDateTime(row.Cells["Date"].Value);
                numericUpDown1.Value =Convert.ToDecimal(row.Cells["QuantitySold"].Value);

            }
            if (e.RowIndex >= 0 && dataGridCars.Columns[e.ColumnIndex].Name == "Edit")
            {
                txtcarid.Text = dataGridCars.Rows[e.RowIndex].Cells["CarID"].Value.ToString();
                comboBox1.Text = dataGridCars.Rows[e.RowIndex].Cells["CarModel"].Value.ToString();
                txtstatus.Text = dataGridCars.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                txtprice.Text = dataGridCars.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                txtcustomername.Text = dataGridCars.Rows[e.RowIndex].Cells["Customername"].Value.ToString();
                dateTimePicker1.Value =Convert.ToDateTime(dataGridCars.Rows[e.RowIndex].Cells["Date"].Value);
                numericUpDown1.Value =Convert.ToDecimal(dataGridCars.Rows[e.RowIndex].Cells["QuantitySold"].Value);
            }
        }


        private void update_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();

                try
                {
                    // 1. جلب الكمية القديمة
                    string getOldQtyQuery = "SELECT Quantitysold FROM Cars WHERE [car id] = @id";
                    SqlCommand getOldQtyCmd = new SqlCommand(getOldQtyQuery, con, trans);
                    getOldQtyCmd.Parameters.AddWithValue("@id", txtcarid.Text);
                    int oldQty = Convert.ToInt32(getOldQtyCmd.ExecuteScalar());

                    int newQty = (int)numericUpDown1.Value;
                    int diff = newQty - oldQty;

                    // 2. تعديل بيانات السيارة
                    string updateQuery = "UPDATE Cars SET model=@model, Status=@status, date=@Date, customername=@Customername, price=@price, Quantitysold=@QuantitySold WHERE [car id]=@id";
                    SqlCommand cmd = new SqlCommand(updateQuery, con, trans);
                    cmd.Parameters.AddWithValue("@model", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@status", txtstatus.Text);
                    cmd.Parameters.AddWithValue("@price", txtprice.Text);
                    cmd.Parameters.AddWithValue("@id", txtcarid.Text);
                    cmd.Parameters.AddWithValue("@Customername", txtcustomername.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@QuantitySold", newQty);
                    cmd.ExecuteNonQuery();

                    // 3. تعديل المخزون بناءً على الفرق
                    string updateStockQuery = "UPDATE inventory SET carinstock = carinstock - @diff WHERE carmodel = @model";
                    SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, con, trans);
                    updateStockCmd.Parameters.AddWithValue("@diff", diff);
                    updateStockCmd.Parameters.AddWithValue("@model", comboBox1.Text);
                    updateStockCmd.ExecuteNonQuery();

                    trans.Commit();
                    MessageBox.Show("تم التحديث وتعديل المخزون بنجاح");
                    LoadAllCars();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("حدث خطأ أثناء التحديث: " + ex.Message);
                }
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtcarid.Text))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlTransaction trans = con.BeginTransaction();

                    try
                    {
                        // 1. جلب الكمية والموديل قبل الحذف
                        string getInfoQuery = "SELECT model, Quantitysold FROM Cars WHERE [Car ID] = @id";
                        SqlCommand getInfoCmd = new SqlCommand(getInfoQuery, con, trans);
                        getInfoCmd.Parameters.AddWithValue("@id", txtcarid.Text);
                        SqlDataReader reader = getInfoCmd.ExecuteReader();

                        string model = "";
                        int quantitySold = 0;

                        if (reader.Read())
                        {
                            model = reader["model"].ToString();
                            quantitySold = Convert.ToInt32(reader["Quantitysold"]);
                        }
                        reader.Close();

                        if (!string.IsNullOrEmpty(model))
                        {
                            // 2. حذف السيارة
                            string deleteQuery = "DELETE FROM Cars WHERE [Car ID] = @id";
                            SqlCommand deleteCmd = new SqlCommand(deleteQuery, con, trans);
                            deleteCmd.Parameters.AddWithValue("@id", txtcarid.Text);
                            deleteCmd.ExecuteNonQuery();

                            // 3. إعادة الكمية للمخزون
                            string updateInventoryQuery = "UPDATE inventory SET carinstock = carinstock + @qty WHERE carmodel = @model";
                            SqlCommand updateStockCmd = new SqlCommand(updateInventoryQuery, con, trans);
                            updateStockCmd.Parameters.AddWithValue("@qty", quantitySold);
                            updateStockCmd.Parameters.AddWithValue("@model", model);
                            updateStockCmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                        MessageBox.Show("تم الحذف وإعادة الكمية للمخزون بنجاح!");
                        LoadAllCars();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("حدث خطأ أثناء الحذف: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("يرجى اختيار صف لحذفه.");
            }
        }
    }
}
