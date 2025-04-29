namespace WinFormsApp8
{
    partial class Login
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
            panelLogin = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnLogin = new Button();
            Password = new TextBox();
            Username = new TextBox();
            lblTitle = new Label();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.White;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(pictureBox2);
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Controls.Add(label1);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(Password);
            panelLogin.Controls.Add(Username);
            panelLogin.Controls.Add(lblTitle);
            panelLogin.Location = new Point(306, 203);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(300, 250);
            panelLogin.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.blog_wp_login;
            pictureBox2.Location = new Point(51, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icon_256x256;
            pictureBox1.Location = new Point(51, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 11);
            label1.Name = "label1";
            label1.Size = new Size(110, 41);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Red;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(112, 188);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(101, 41);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Password
            // 
            Password.Location = new Point(103, 141);
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(125, 27);
            Password.TabIndex = 2;
            Password.UseSystemPasswordChar = true;
            // 
            // Username
            // 
            Username.ForeColor = Color.Gray;
            Username.Location = new Point(103, 79);
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.Size = new Size(125, 27);
            Username.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(103, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 38);
            lblTitle.TabIndex = 0;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_2025_04_18_15_48_21;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(882, 653);
            Controls.Add(panelLogin);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private TextBox Password;
        private TextBox Username;
        private Label lblTitle;
        private Button btnLogin;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}