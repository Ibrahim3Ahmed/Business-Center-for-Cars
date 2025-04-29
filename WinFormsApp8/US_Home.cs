using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp8
{
    public partial class US_Home : UserControl
    {
        private void LoadTotalCars()
        {
            string connectionString = "Data Source=DESKTOP-RHRQ9VP\\SQLEXPRESS;Initial Catalog=\"Toyota system\";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Cars", conn);
                int total = (int)cmd.ExecuteScalar();
                label3.Text = total.ToString(); // دي اللي بتعرض عدد العربيات
                conn.Close();
            }
        }
        private void LoadTotalCustomers()
        {
            string connStr = @"Data Source=DESKTOP-RHRQ9VP\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True"; // أو استخدم نفس سترنج الاتصال اللي بتستخدمه
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Customers";
                SqlCommand cmd = new SqlCommand(query, conn);
                int count = (int)cmd.ExecuteScalar();
                label4.Text = count.ToString(); // غيّر الاسم ده لو اسم الـLabel مختلف
            }
        }
        public US_Home()
        {
            InitializeComponent();

            // شغّل التايمر فوراً
            timer1.Interval = 1000;
            timer1.Start();

            // حدّث التاريخ والوقت عند الإنشاء
            UpdateDateTime();
            LoadTotalCars();
            LoadTotalCustomers();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // كل ثانية حدّث التاريخ والوقت
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
