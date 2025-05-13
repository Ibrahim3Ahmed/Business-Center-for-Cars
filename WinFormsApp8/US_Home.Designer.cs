namespace WinFormsApp8
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTime = new Label();
            lblDate = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkTurquoise;
            label1.Location = new Point(211, 529);
            label1.Name = "label1";
            label1.Size = new Size(278, 51);
            label1.TabIndex = 0;
            label1.Text = "Business Overview";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(20, 209);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 85);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightSteelBlue;
            label3.Location = new Point(114, 31);
            label3.Name = "label3";
            label3.Size = new Size(60, 46);
            label3.TabIndex = 3;
            label3.Text = "45";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(81, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 31);
            label2.TabIndex = 2;
            label2.Text = "Total Cars";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.icons8_car_401;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(205, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 32);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(388, 209);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 85);
            panel2.TabIndex = 2;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.icons8_user_401;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(255, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 35);
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightSteelBlue;
            label4.Location = new Point(123, 31);
            label4.Name = "label4";
            label4.Size = new Size(80, 46);
            label4.TabIndex = 3;
            label4.Text = "120";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(63, 0);
            label5.Name = "label5";
            label5.Size = new Size(186, 31);
            label5.TabIndex = 2;
            label5.Text = "Total Customers";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(20, 390);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 85);
            panel3.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.icons8_flat_tire_401;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(205, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 32);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightSteelBlue;
            label6.Location = new Point(94, 30);
            label6.Name = "label6";
            label6.Size = new Size(80, 46);
            label6.TabIndex = 3;
            label6.Text = "302";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(65, 0);
            label7.Name = "label7";
            label7.Size = new Size(134, 31);
            label7.TabIndex = 2;
            label7.Text = "Spare Parts";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(388, 389);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 85);
            panel4.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.icons8_tools_401;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(231, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 32);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightSteelBlue;
            label8.Location = new Point(123, 31);
            label8.Name = "label8";
            label8.Size = new Size(60, 46);
            label8.TabIndex = 3;
            label8.Text = "17";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(72, 0);
            label9.Name = "label9";
            label9.Size = new Size(153, 31);
            label9.TabIndex = 2;
            label9.Text = "Maintenance";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Microsoft Sans Serif", 16F);
            lblTime.ForeColor = Color.Crimson;
            lblTime.Location = new Point(42, 87);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(101, 31);
            lblTime.TabIndex = 7;
            lblTime.Text = "label11";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Microsoft Sans Serif", 16F);
            lblDate.ForeColor = SystemColors.ActiveCaption;
            lblDate.Location = new Point(115, 137);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(101, 31);
            lblDate.TabIndex = 8;
            lblDate.Text = "label12";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.image__4_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(484, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 147);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // US_Home
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.photo_2025_05_04_01_39_47;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pictureBox1);
            Controls.Add(lblDate);
            Controls.Add(lblTime);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "US_Home";
            Size = new Size(691, 653);
            Load += US_Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Panel panel3;
        private Label label6;
        private Label label7;
        private Panel panel4;
        private Label label8;
        private Label label9;
        private System.Windows.Forms.Timer timer1;
        private Label lblTime;
        private Label lblDate;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}
