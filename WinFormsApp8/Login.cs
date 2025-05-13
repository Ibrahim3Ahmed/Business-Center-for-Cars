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
using Microsoft.UI.Xaml.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace WinFormsApp8
{
    public partial class Login : Form
    {
        public Login(string loginType)
        {
            InitializeComponent();
            this.Text = loginType; // أو استخدم loginType لعرض نوع الدخول
        }




        private void label1_Click(object sender, EventArgs e)
        {
            panelLogin.BackColor = Color.FromArgb(180, Color.White); // 180 من 255 تعني شفافية جزئية
        }



        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=\"Toyota system\";Integrated Security=True");
            conn.Open();
            string query = "SELECT COUNT(*) FROM Admin WHERE name=@Username AND password=@Password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", Username.Text);
            cmd.Parameters.AddWithValue("@Password", Password.Text);
            object result = cmd.ExecuteScalar();
            int count = (result != null) ? Convert.ToInt32(result) : 0;
            if (count > 0)
            {
                new Dashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The username or password you entered is incorrect, try again");
                Username.Clear();
                Password.Clear();
                Username.Focus();
            }
        }





        private void btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new accountType().Show();
            this.Hide();
        }
    }
}



