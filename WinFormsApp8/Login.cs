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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace WinFormsApp8
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }




        private void label1_Click(object sender, EventArgs e)
        {
            panelLogin.BackColor = Color.FromArgb(180, Color.White); // 180 من 255 تعني شفافية جزئية
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RHRQ9VP\\SQLEXPRESS;Initial Catalog=\"Toyota system\";Integrated Security=True");
            conn.Open();
            string query = "SELECT COUNT(*) FROM Customers WHERE Username=@Username AND Password=@Password";
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
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}



