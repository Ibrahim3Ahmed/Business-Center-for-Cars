using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinFormsApp8
{

    public partial class accountType : Form
    {
        public accountType()
        {
            InitializeComponent();

        }

        int canmove = 0;
        int xCor = 0;
        int yCor = 0;

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (canmove == 1)
                this.SetDesktopLocation(MousePosition.X - xCor, MousePosition.Y - yCor);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            canmove = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            canmove = 1;
            xCor = e.X;
            yCor = e.Y;
        }



        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::WinFormsApp8.Properties.Resources.Untitled_12;
        }


        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.Image = global::WinFormsApp8.Properties.Resources.fixit_thumb;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path + "\\CRMS\\userStatus.xml");
            xmlDoc.SelectSingleNode("status").InnerText = "Staff";
            xmlDoc.Save(path + "\\CRMS\\userStatus.xml");

            // هنا بنفترض إن عندك فورم اسمه LoginForm
            Login log = new Login("Staff Login");
            log.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path + "\\CRMS\\userStatus.xml");
            xmlDoc.SelectSingleNode("status").InnerText = "Admin";
            xmlDoc.Save(path + "\\CRMS\\userStatus.xml");

            Login log = new Login("Admin Login");
            log.Show();
            this.Hide();
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            canmove = 1;
            xCor = e.X;
            yCor = e.Y;
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            canmove = 0;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (canmove == 1)
                this.SetDesktopLocation(MousePosition.X - 400, MousePosition.Y - 18);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Pass the required 'loginType' argument to the Login constructor
            new Login("Default Login").Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new StaffLogin().Show();
            this.Hide();
        }
    }
}

