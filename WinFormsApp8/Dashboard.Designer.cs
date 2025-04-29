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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1Sidebar = new Panel();
            label1 = new Label();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel1Sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1Sidebar
            // 
            panel1Sidebar.BackColor = Color.FromArgb(52, 73, 94);
            panel1Sidebar.Controls.Add(label1);
            panel1Sidebar.Controls.Add(button7);
            panel1Sidebar.Controls.Add(button6);
            panel1Sidebar.Controls.Add(button5);
            panel1Sidebar.Controls.Add(button4);
            panel1Sidebar.Controls.Add(button3);
            panel1Sidebar.Controls.Add(button2);
            panel1Sidebar.Controls.Add(button1);
            panel1Sidebar.Dock = DockStyle.Left;
            panel1Sidebar.Location = new Point(0, 0);
            panel1Sidebar.Name = "panel1Sidebar";
            panel1Sidebar.Size = new Size(200, 653);
            panel1Sidebar.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Peru;
            label1.Location = new Point(0, 18);
            label1.Name = "label1";
            label1.Size = new Size(200, 60);
            label1.TabIndex = 0;
            label1.Text = "Business \r\nCenter for Cars";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            button5.Size = new Size(200, 45);
            button5.TabIndex = 4;
            button5.Text = "Spare Parts";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(44, 62, 80);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.icons8_tools_40;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 351);
            button4.Name = "button4";
            button4.Padding = new Padding(15, 0, 0, 0);
            button4.Size = new Size(200, 45);
            button4.TabIndex = 3;
            button4.Text = "Maintenance\r\nServices";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            button1.Size = new Size(200, 45);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(200, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(691, 653);
            panel2.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(891, 653);
            Controls.Add(panel2);
            Controls.Add(panel1Sidebar);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1Sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1Sidebar;
        public Panel panel2;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
    }
}