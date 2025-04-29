using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class US_Customers : UserControl
    {
        string connectionString = "Data Source=DESKTOP-RHRQ9VP\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
        public US_Customers()
        {
            InitializeComponent();
            this.Load += US_Customers_Load;
        }
        void LoadAllcustomers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT customerid AS ID, Username AS Name, phone AS Phone,address AS Address,Service AS Sercive ,price AS Price FROM Customers";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }
        private void US_Customers_Load(object sender, EventArgs e)
        {
            LoadAllcustomers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Searchcustomers(string keyword)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT customerid AS ID, Username AS Name, phone AS Phone,address AS Address,Service AS Sercive ,price AS Price
                 FROM Customers
                 WHERE CAST(customerid AS NVARCHAR) LIKE @search OR Username LIKE @search";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + keyword + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Edit"].DisplayIndex = dataGridView1.Columns.Count - 1;
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtsearch.Text))
                Searchcustomers(txtsearch.Text);
            else
                LoadAllcustomers();
        }
        void Loadcustomers()
        {
            string connectionString = "Data Source=DESKTOP-RHRQ9VP\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT customerid , Username, phone ,address,Service,price FROM Customers", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RHRQ9VP\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Customers (customerid, Username, phone,address,Service,price) VALUES (@id, @name, @phone,@address,@Service, @price)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", txtid.Text);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                cmd.Parameters.AddWithValue("@Service", txtservice.Text);
                cmd.Parameters.AddWithValue("@price", txtprice.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Customer added successfully!");

                // بعدها تحدث الـDataGridView
                Loadcustomers();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtid.Text = row.Cells["id"].Value.ToString();
                txtname.Text = row.Cells["name"].Value.ToString();
                txtphone.Text = row.Cells["phone"].Value.ToString();
                txtaddress.Text = row.Cells["address"].Value.ToString();
                txtservice.Text = row.Cells[5].Value.ToString();
                txtprice.Text = row.Cells["Price"].Value.ToString();
            }
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                txtid.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtname.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                txtaddress.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].Value.ToString();
                txtservice.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtprice.Text = dataGridView1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Customers SET Address=@Address,Username=@name, phone=@phone, Service=@Service, price=@price WHERE customerid=@id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@service", txtservice.Text);
                    cmd.Parameters.AddWithValue("@price", txtprice.Text);
                    cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                    cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@id", txtid.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("تم تعديل العميل بنجاح");

                    LoadAllcustomers(); // عشان تحدث البيانات في الجدول بعد التعديل
                }
            }
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtid.Text))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Customers WHERE customerid = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", txtid.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Row deleted successfully!");
                LoadAllcustomers(); // حدث لتحديث الجدول بعد الحذف
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}

