using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            US_Home homecontrol = new US_Home();
            homecontrol.Dock=DockStyle.Fill;
            panel2.Controls.Add(homecontrol);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            US_Cars carcontrol = new US_Cars();
            carcontrol.Dock=DockStyle.Fill;
            panel2.Controls.Add(carcontrol);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            US_Customers carcontrol = new US_Customers();
            carcontrol.Dock=DockStyle.Fill;
            panel2.Controls.Add(carcontrol);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            US_Maintenance carcontrol = new US_Maintenance();
            carcontrol.Dock=DockStyle.Fill;
            panel2.Controls.Add(carcontrol);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            US_Spare_parts carcontrol = new US_Spare_parts();
            carcontrol.Dock=DockStyle.Fill;
            panel2.Controls.Add(carcontrol);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            US_Reports carcontrol = new US_Reports();
            carcontrol.Dock=DockStyle.Fill;
            panel2.Controls.Add(carcontrol);
        }
    }
}
