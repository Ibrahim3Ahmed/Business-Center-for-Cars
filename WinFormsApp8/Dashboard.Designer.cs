namespace WinFormsApp8
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1Sidebar = new Panel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            button77 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            button4 = new Button();
            button8 = new Button();
            btn1 = new Button();
            panel1Sidebar.SuspendLayout();
            panel2.SuspendLayout();
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1Sidebar
            // 
            panel1Sidebar.BackColor = Color.FromArgb(52, 73, 94);
            panel1Sidebar.Controls.Add(guna2HtmlLabel3);
            panel1Sidebar.Controls.Add(button77);
            panel1Sidebar.Controls.Add(button7);
            panel1Sidebar.Controls.Add(button6);
            panel1Sidebar.Controls.Add(button5);
            panel1Sidebar.Controls.Add(button3);
            panel1Sidebar.Controls.Add(button2);
            panel1Sidebar.Controls.Add(button1);
            panel1Sidebar.Dock = DockStyle.Left;
            panel1Sidebar.Location = new Point(0, 0);
            panel1Sidebar.Name = "panel1Sidebar";
            panel1Sidebar.Size = new Size(200, 653);
            panel1Sidebar.TabIndex = 0;
            panel1Sidebar.Paint += panel1Sidebar_Paint;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.ForeColor = Color.Coral;
            guna2HtmlLabel3.Location = new Point(23, 21);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(159, 64);
            guna2HtmlLabel3.TabIndex = 8;
            guna2HtmlLabel3.Text = "<b>Business</b> \r\n<br>\r\nCenter for Cars\r\n\r\n\r\n\r\n";
            guna2HtmlLabel3.TextAlignment = ContentAlignment.MiddleCenter;
            guna2HtmlLabel3.Click += guna2HtmlLabel1_Click;
            // 
            // button77
            // 
            button77.BackColor = Color.FromArgb(44, 62, 80);
            button77.FlatAppearance.BorderSize = 0;
            button77.FlatStyle = FlatStyle.Flat;
            button77.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button77.ForeColor = Color.White;
            button77.Image = Properties.Resources.icons8_tools_40;
            button77.ImageAlign = ContentAlignment.MiddleLeft;
            button77.Location = new Point(0, 352);
            button77.Margin = new Padding(3, 4, 3, 4);
            button77.Name = "button77";
            button77.Size = new Size(200, 44);
            button77.TabIndex = 7;
            button77.Text = "Maintenance \r\nServices\r\n";
            button77.UseVisualStyleBackColor = false;
            button77.Click += button77_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(44, 62, 80);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 10F);
            button7.ForeColor = Color.White;
            button7.Image = Properties.Resources.icons8_logout_40;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 608);
            button7.Name = "button7";
            button7.Padding = new Padding(15, 0, 0, 0);
            button7.Size = new Size(200, 45);
            button7.TabIndex = 6;
            button7.Text = "Logout";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(44, 62, 80);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 10F);
            button6.ForeColor = Color.White;
            button6.Image = Properties.Resources.icons8_report_40;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-3, 521);
            button6.Name = "button6";
            button6.Padding = new Padding(15, 0, 0, 0);
            button6.Size = new Size(200, 45);
            button6.TabIndex = 5;
            button6.Text = "Reports";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(44, 62, 80);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10F);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.icons8_flat_tire_40;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 433);
            button5.Name = "button5";
            button5.Padding = new Padding(15, 0, 0, 0);
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(200, 45);
            button5.TabIndex = 4;
            button5.Text = "Spare Parts";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(44, 62, 80);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.icons8_user_40;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 271);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 0, 0, 0);
            button3.Size = new Size(200, 45);
            button3.TabIndex = 2;
            button3.Text = "Customers\r\n Management";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(44, 62, 80);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.icons8_car_40;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 187);
            button2.Name = "button2";
            button2.Padding = new Padding(15, 0, 0, 0);
            button2.Size = new Size(200, 45);
            button2.TabIndex = 1;
            button2.Text = "Cars \r\nManagement";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(44, 62, 80);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.icons8_home_40;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 108);
            button1.Name = "button1";
            button1.Padding = new Padding(15, 0, 0, 0);
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(200, 45);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = Properties.Resources.photo_2025_05_04_01_39_37;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(guna2CustomGradientPanel1);
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(691, 653);
            panel2.TabIndex = 1;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BackColor = Color.Transparent;
            guna2CustomGradientPanel1.Controls.Add(button4);
            guna2CustomGradientPanel1.Controls.Add(button8);
            guna2CustomGradientPanel1.Controls.Add(btn1);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges1;
            guna2CustomGradientPanel1.Dock = DockStyle.Top;
            guna2CustomGradientPanel1.FillColor = Color.Transparent;
            guna2CustomGradientPanel1.FillColor2 = Color.Transparent;
            guna2CustomGradientPanel1.FillColor3 = Color.Transparent;
            guna2CustomGradientPanel1.FillColor4 = Color.Transparent;
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CustomGradientPanel1.Size = new Size(691, 37);
            guna2CustomGradientPanel1.TabIndex = 7;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Dock = DockStyle.Right;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.icons8_line_25;
            button4.Location = new Point(589, 0);
            button4.Name = "button4";
            button4.Size = new Size(34, 37);
            button4.TabIndex = 9;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Dock = DockStyle.Right;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = Properties.Resources.icons8_restore_down_25;
            button8.Location = new Point(623, 0);
            button8.Name = "button8";
            button8.Size = new Size(34, 37);
            button8.TabIndex = 9;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Transparent;
            btn1.BackgroundImageLayout = ImageLayout.Stretch;
            btn1.Dock = DockStyle.Right;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Image = Properties.Resources.icons8_close_25__1_;
            btn1.Location = new Point(657, 0);
            btn1.Name = "btn1";
            btn1.Size = new Size(34, 37);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(891, 653);
            Controls.Add(panel2);
            Controls.Add(panel1Sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1Sidebar.ResumeLayout(false);
            panel1Sidebar.PerformLayout();
            panel2.ResumeLayout(false);
            guna2CustomGradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        // Add the missing event handler method for button4_Click in the Dashboard class.  
        private void button4_Click(object sender, EventArgs e)
        {
            // Add your logic here for the Maintenance Services button click event.  
            MessageBox.Show("Maintenance Services button clicked!");
        }

        #endregion

        private Panel panel1Sidebar;
        public Panel panel2;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button77;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Button button4;
        private Button button8;
        private Button btn1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}