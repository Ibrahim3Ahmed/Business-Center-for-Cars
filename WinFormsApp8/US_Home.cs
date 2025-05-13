
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Home : UserControl
    {
        // تعريف الاتصال مرة واحدة فقط
        private readonly string connectionString = @"Data Source=DESKTOP-LULQNSK\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";

        public Home()
        {
            InitializeComponent();

            // تشغيل التايمر لتحديث الوقت
            timer1.Interval = 1000;
            timer1.Start();

            // تحديث التاريخ والوقت عند الإنشاء
            UpdateDateTime();
        }

        private void US_Home_Load(object sender, EventArgs e)
        {
            LoadTotalCars();
            LoadTotalCustomers();
            LoadTotalMaintenance();
            LoadTotalParts();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void LoadTotalCars()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Cars", conn);
                    int total = (int)cmd.ExecuteScalar();
                    label3.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cars: " + ex.Message);
            }
        }

        private void LoadTotalMaintenance()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Maintenance Services]", conn);
                    int total = (int)cmd.ExecuteScalar();
                    label8.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading maintenance services: " + ex.Message);
            }
        }

        private void LoadTotalCustomers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Customers", conn);
                    int total = (int)cmd.ExecuteScalar();
                    label4.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }

        private void LoadTotalParts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Spare_Parts", conn);
                    int total = (int)cmd.ExecuteScalar();
                    label6.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading spare parts: " + ex.Message);
            }
        }

        // أحداث إضافية إن كنت تنوي استخدامها لاحقًا
        private void label10_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
