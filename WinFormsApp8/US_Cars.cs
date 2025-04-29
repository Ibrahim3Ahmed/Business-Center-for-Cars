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
        string connectionString = "Data Source=DESKTOP-RHRQ9VP\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
        public US_Cars()
        {
            InitializeComponent();
           
        }
        void LoadAllCars()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT [car id] AS ID, model AS Model, Status, price AS Price FROM Cars";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridCars.DataSource = dt;

            }
        }

        private void US_Cars_Load(object sender, EventArgs e)
        {
            LoadAllCars();
           
          
        }
        void SearchCars(string keyword)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT [car id] AS ID, model AS Model, Status, price AS Price 
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
            string connectionString = "Data Source=DESKTOP-RHRQ9VP\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT [car id], model, Status, price FROM Cars", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridCars.DataSource = dt;
            }
        }

        private void addcar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RHRQ9VP\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Cars ([car id], model, Status, price) VALUES (@id, @model, @status, @price)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", txtcarid.Text);
                cmd.Parameters.AddWithValue("@model", txtmodel.Text);
                cmd.Parameters.AddWithValue("@status", txtstatus.Text);
                cmd.Parameters.AddWithValue("@price", txtprice.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Car added successfully!");

                // بعدها تحدث الـDataGridView
                LoadCars();
            }
        }

        private void dataGridCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridCars.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridCars.Rows[e.RowIndex];

                txtcarid.Text = row.Cells["CarID"].Value.ToString();
                txtmodel.Text = row.Cells["CarModel"].Value.ToString();
                txtstatus.Text = row.Cells["Status"].Value.ToString();
                txtprice.Text = row.Cells["Price"].Value.ToString();
            }
            if (e.RowIndex >= 0 && dataGridCars.Columns[e.ColumnIndex].Name == "Edit")
            {
                txtcarid.Text = dataGridCars.Rows[e.RowIndex].Cells["CarID"].Value.ToString();
                txtmodel.Text = dataGridCars.Rows[e.RowIndex].Cells["CarModel"].Value.ToString();
                txtstatus.Text = dataGridCars.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                txtprice.Text = dataGridCars.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Cars SET model=@model, Status=@status, price=@price WHERE [car id]=@id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@model", txtmodel.Text);
                    cmd.Parameters.AddWithValue("@status", txtstatus.Text);
                    cmd.Parameters.AddWithValue("@price", txtprice.Text);
                    cmd.Parameters.AddWithValue("@id", txtcarid.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("تم تعديل السيارة بنجاح");

                    LoadAllCars(); // عشان تحدث البيانات في الجدول بعد التعديل
                }
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtcarid.Text))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Cars WHERE [Car ID] = @id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", txtcarid.Text);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Row deleted successfully!");
                LoadAllCars(); // حدث لتحديث الجدول بعد الحذف
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
