using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class StaffLogin : Form
    {
        public StaffLogin()
        {
            InitializeComponent();
        }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
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

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new accountType().Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True");
            try
            {
                conn.Open(); string query = "SELECT COUNT(*) FROM register WHERE username=@username AND pass=@password"; SqlCommand cmd = new SqlCommand(query, conn); cmd.Parameters.AddWithValue("@username", guna2TextBox1.Text); cmd.Parameters.AddWithValue("@password", guna2TextBox2.Text); object result = cmd.ExecuteScalar(); int count = (result != null) ? Convert.ToInt32(result) : 0;

                if (count > 0)
                {
                    Dashboard dashboard = new Dashboard();
                    Panel panel = (Panel)dashboard.Controls["panel1Sidebar"];
                    if (panel != null)
                    {
                        foreach (Control btn in panel.Controls)
                        {
                            if (btn.Name == "button6") // Reports button
                            {
                                btn.Visible = false;
                            }
                            if (btn.Name == "button7") // Logout button
                            {
                                btn.Location = panel.Controls["button6"].Location;
                            }
                        }
                    }
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The username or password you entered is incorrect, try again");
                    guna2TextBox1.Clear();
                    guna2TextBox2.Clear();
                    guna2TextBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
