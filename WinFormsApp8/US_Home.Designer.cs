namespace WinFormsApp8
{
    partial class US_Home
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
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTime = new Label();
            lblDate = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(195, 8);
            label1.Name = "label1";
            label1.Size = new Size(278, 51);
            label1.TabIndex = 0;
            label1.Text = "Business Overview";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(20, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 85);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(114, 31);
            label3.Name = "label3";
            label3.Size = new Size(69, 54);
            label3.TabIndex = 3;
            label3.Text = "45";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 38);
            label2.TabIndex = 2;
            label2.Text = "Total Cars";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(375, 168);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 85);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Chocolate;
            label4.Location = new Point(123, 31);
            label4.Name = "label4";
            label4.Size = new Size(92, 54);
            label4.TabIndex = 3;
            label4.Text = "120";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(63, 0);
            label5.Name = "label5";
            label5.Size = new Size(227, 38);
            label5.TabIndex = 2;
            label5.Text = "Total Customers";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(20, 312);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 100);
            panel3.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Brown;
            label6.Location = new Point(94, 40);
            label6.Name = "label6";
            label6.Size = new Size(92, 54);
            label6.TabIndex = 3;
            label6.Text = "302";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(65, 0);
            label7.Name = "label7";
            label7.Size = new Size(165, 38);
            label7.TabIndex = 2;
            label7.Text = "Spare Parts";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(375, 311);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 100);
            panel4.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Purple;
            label8.Location = new Point(126, 40);
            label8.Name = "label8";
            label8.Size = new Size(69, 54);
            label8.TabIndex = 3;
            label8.Text = "17";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(72, 0);
            label9.Name = "label9";
            label9.Size = new Size(187, 38);
            label9.TabIndex = 2;
            label9.Text = "Maintenance";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(153, 593);
            label10.Name = "label10";
            label10.Size = new Size(565, 38);
            label10.TabIndex = 5;
            label10.Text = "Welcome to Business Center for Cars";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Click += label10_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2image__3_;
            pictureBox1.Location = new Point(135, 461);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(422, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
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
            lblTime.Location = new Point(49, 76);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(116, 37);
            lblTime.TabIndex = 7;
            lblTime.Text = "label11";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Microsoft Sans Serif", 16F);
            lblDate.ForeColor = Color.Blue;
            lblDate.Location = new Point(86, 122);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(118, 37);
            lblDate.TabIndex = 8;
            lblDate.Text = "label12";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // US_Home
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(lblDate);
            Controls.Add(lblTime);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "US_Home";
            Size = new Size(691, 653);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Label label10;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label lblTime;
        private Label lblDate;
    }
}
