using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Linq;

namespace WinFormsApp8
{
    public partial class US_Spare_parts : UserControl
    {
        string connectionstring = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
        public US_Spare_parts()
        {
            InitializeComponent();
            this.Load += US_SpareParts_Load;
            LoadCarModels();
        }
        void LoadAllspareparts()
        {
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                string query = "SELECT PartID AS Part_ID,name AS Part_Name, carmodel AS Car_Model, category AS Category,Quantitysold AS Quantity, price AS Unit_Price,supplier AS Supplier, date AS Date FROM Spare_Parts";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewParts.DataSource = dt;

            }
        }
        private void LoadCarModels()
        {
            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT model FROM Cars", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                comboBox2.Items.Clear();
                comboBox2.Items.Add("");

                while (reader.Read())
                {
                    if (reader["model"] != DBNull.Value)
                    {
                        comboBox2.Items.Add(reader["model"].ToString());
                    }
                }

                reader.Close();
            }

            comboBox2.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void US_SpareParts_Load(object sender, EventArgs e)
        {
            LoadAllspareparts();
            Loadpart();
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }
        //"SELECT PartID AS Part_ID,name AS Part_Name, carmodel AS Car_Model, category AS Category,QuantityInStock AS Quantity, price AS Unit_Price,supplier AS Supplier FROM [Spare_Parts]
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. إدخال بيانات القطعة
                    string insertQuery = "INSERT INTO Spare_Parts (PartID, name, carmodel, category, supplier, Quantitysold, price, date) " +
                                         "VALUES (@Part_ID, @Part_Name, @Car_model, @Category, @Supplier, @Quantity, @Unit_Price, @Date)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction);
                    insertCmd.Parameters.AddWithValue("@Part_ID", textBox4.Text);
                    insertCmd.Parameters.AddWithValue("@part_Name", comboBox4.Text);
                    insertCmd.Parameters.AddWithValue("@Car_Model", comboBox2.Text);
                    insertCmd.Parameters.AddWithValue("@Category", comboBox3.Text);
                    insertCmd.Parameters.AddWithValue("@Supplier", comboBox1.Text);
                    insertCmd.Parameters.AddWithValue("@Quantity", numericUpDown1.Value);
                    insertCmd.Parameters.AddWithValue("@Unit_Price", textBox3.Text);
                    insertCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    insertCmd.ExecuteNonQuery();

                    // 2. تحديث المخزون في جدول inventory
                    string updateInventory = "UPDATE inventory SET partinstock = partinstock - @qty WHERE partname = @Part_Name";
                    SqlCommand updateCmd = new SqlCommand(updateInventory, conn, transaction);
                    updateCmd.Parameters.AddWithValue("@qty", numericUpDown1.Value);
                    updateCmd.Parameters.AddWithValue("@Part_Name", comboBox4.Text);
                    updateCmd.ExecuteNonQuery();

                    // إذا تمت العملية بنجاح، نقوم بتأكيد الترانزكشن
                    transaction.Commit();

                    MessageBox.Show("تمت إضافة القطعة وتحديث المخزون بنجاح!");
                    LoadAllspareparts();
                }
                catch (Exception ex)
                {
                    // إذا حدث خطأ، نقوم بالتراجع عن الترانزكشن
                    transaction.Rollback();
                    MessageBox.Show("حصل خطأ أثناء الإضافة: " + ex.Message);
                }
            }
        }
        private void Loadpart()
        {
            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT partname FROM Inventory";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow empty = dt.NewRow();
                empty["partname"] = "";
                dt.Rows.InsertAt(empty, 0);
                comboBox4.DataSource = dt;
                comboBox4.DisplayMember = "partname";
                comboBox4.ValueMember = "partname";
                comboBox4.SelectedIndex = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();

                try
                {
                    // 1. جلب الكمية القديمة من جدول Spare_Parts
                    string getOldQtyQuery = "SELECT Quantitysold FROM Spare_Parts WHERE PartID = @PartID";
                    SqlCommand getOldQtyCmd = new SqlCommand(getOldQtyQuery, con, trans);
                    getOldQtyCmd.Parameters.AddWithValue("@PartID", textBox4.Text);
                    int oldQty = Convert.ToInt32(getOldQtyCmd.ExecuteScalar());

                    int newQty = (int)numericUpDown1.Value;
                    int diff = newQty - oldQty;

                    // 2. تحديث بيانات القطعة
                    string updateQuery = @"UPDATE Spare_Parts SET 
                                   name = @Part_Name,
                                   carmodel = @Car_Model,
                                   category = @Category,
                                   supplier = @Supplier,
                                   Quantitysold = @QuantitySold,
                                   Price = @Unit_Price,
                                   date = @Date
                                   WHERE PartID = @PartID";

                    SqlCommand updateCmd = new SqlCommand(updateQuery, con, trans);
                    updateCmd.Parameters.AddWithValue("@Part_Name", comboBox4.Text);
                    updateCmd.Parameters.AddWithValue("@PartID", textBox4.Text);
                    updateCmd.Parameters.AddWithValue("@Car_Model", comboBox2.Text);
                    updateCmd.Parameters.AddWithValue("@Category", comboBox3.Text);
                    updateCmd.Parameters.AddWithValue("@Supplier", comboBox1.Text);
                    updateCmd.Parameters.AddWithValue("@QuantitySold", newQty);
                    updateCmd.Parameters.AddWithValue("@Unit_Price", textBox3.Text);
                    updateCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    updateCmd.ExecuteNonQuery();

                    // 3. تعديل المخزون بناءً على الفرق
                    if (diff != 0)
                    {
                        string updateStockQuery = "UPDATE inventory SET partinstock = partinstock - @diff WHERE partname = @Part_Name";
                        SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, con, trans);
                        updateStockCmd.Parameters.AddWithValue("@diff", Math.Abs(diff)); // استخدام Math.Abs للتأكد من أن القيمة دائمًا موجبة
                        updateStockCmd.Parameters.AddWithValue("@Part_Name", comboBox4.Text);
                        updateStockCmd.ExecuteNonQuery();
                    }

                    // 4. تأكيد الترانزكشن
                    trans.Commit();
                    MessageBox.Show("تم التحديث وتعديل المخزون بنجاح");
                    LoadAllspareparts();
                }
                catch (Exception ex)
                {
                    // التراجع عن الترانزكشن في حالة حدوث خطأ
                    trans.Rollback();
                    MessageBox.Show("حدث خطأ أثناء التحديث: " + ex.Message);
                }
            }
        }

        void Searchpart(string keyword)
        {
            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT PartID AS Part_ID,name AS Part_Name, carmodel AS Car_Model, category AS Category,Quantitysold AS Quantity, price AS Unit_Price,supplier AS Supplier,
                   date AS Date FROM Spare_Parts
                    WHERE CAST(PartID AS NVARCHAR) LIKE @search";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + keyword + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewParts.AutoGenerateColumns = false;
                dataGridViewParts.DataSource = dt;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
                Searchpart(textBox1.Text);
            else
                LoadAllspareparts();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewParts.SelectedRows.Count > 0)
            {
                int PartID = Convert.ToInt32(dataGridViewParts.SelectedRows[0].Cells["Part_ID"].Value);
                string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlTransaction trans = con.BeginTransaction();

                    try
                    {
                        // 1. جلب الموديل والكمية قبل الحذف
                        string model = "";
                        int quantitySold = 0;

                        string getInfoQuery = "SELECT name, Quantitysold FROM Spare_Parts WHERE PartID = @PartID";
                        SqlCommand getInfoCmd = new SqlCommand(getInfoQuery, con, trans);
                        getInfoCmd.Parameters.AddWithValue("@PartID", PartID);

                        using (SqlDataReader reader = getInfoCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                model = reader["name"].ToString(); // تأكد من اسم العمود الصحيح
                                quantitySold = Convert.ToInt32(reader["Quantitysold"]);
                            }
                        }

                        if (!string.IsNullOrEmpty(model))
                        {
                            // 2. حذف القطعة
                            string deleteQuery = "DELETE FROM Spare_Parts WHERE PartID = @PartID";
                            SqlCommand deleteCmd = new SqlCommand(deleteQuery, con, trans);
                            deleteCmd.Parameters.AddWithValue("@PartID", PartID);
                            deleteCmd.ExecuteNonQuery();

                            // 3. إعادة الكمية للمخزون
                            string updateInventoryQuery = "UPDATE inventory SET partinstock = partinstock + @qty WHERE partname = @Part_Name";
                            SqlCommand updateStockCmd = new SqlCommand(updateInventoryQuery, con, trans);
                            updateStockCmd.Parameters.AddWithValue("@qty", quantitySold);
                            updateStockCmd.Parameters.AddWithValue("@Part_Name", model);
                            updateStockCmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                        MessageBox.Show("تم الحذف وإعادة الكمية للمخزون بنجاح!");
                        LoadAllspareparts();
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


        private void button4_Click(object sender, EventArgs e)
        {
            comboBox4.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            numericUpDown1.Value = 0;
            textBox3.Text = "";
            textBox1.Text = "";

            dataGridViewParts.ClearSelection();

        }
        //dateTimePicker
        private void dataGridViewParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewParts.Rows[e.RowIndex];

                textBox4.Text = row.Cells["Part_ID"].Value.ToString();
                comboBox4.Text = row.Cells["Part_Name"].Value.ToString();
                comboBox1.Text = row.Cells["Supplier"].Value.ToString();
                comboBox2.Text = row.Cells["Car_Model"].Value.ToString();
                comboBox3.Text = row.Cells["Category"].Value.ToString();
                numericUpDown1.Text = row.Cells["Quantity"].Value.ToString();
                textBox3.Text = row.Cells["Unit_Price"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Date"].Value);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
