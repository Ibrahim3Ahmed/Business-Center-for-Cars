using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms; 
using Microsoft.UI.Xaml.Controls;

namespace WinFormsApp8
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var loginform = new accountType()
            {
                // Simplified object initialization  
            };
            loginform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var homecontrol = new Home
            {
                Dock = DockStyle.Fill
            };
            panel2.Controls.Add(homecontrol);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var carcontrol = new US_Cars
            {
                Dock = DockStyle.Fill
            };
            panel2.Controls.Add(carcontrol);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var carcontrol = new US_Customers
            {
                Dock = DockStyle.Fill
            };
            panel2.Controls.Add(carcontrol);
        }

        private void GetV()
        {
            panel2.Controls.Clear();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var maintenanceControl = new US_Maintenance
            {
                Dock = DockStyle.Fill
            };
            panel2.Controls.Add(maintenanceControl);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var carcontrol = new US_Spare_parts
            {
                Dock = DockStyle.Fill
            };
            panel2.Controls.Add(carcontrol);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            var carcontrol = new US_Reports
            {
                Dock = DockStyle.Fill
            };
            panel2.Controls.Add(carcontrol);
        }

        private void button77_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            US_Maintenance carcontrol = new US_Maintenance();
            carcontrol.Dock = DockStyle.Fill;
            panel2.Controls.Add(carcontrol);
        }

        private void panel1Sidebar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button8_Click(object sender, EventArgs e)
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

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
        }

       
    }
}



