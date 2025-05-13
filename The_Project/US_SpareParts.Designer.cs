namespace WinFormsApp8
{
    partial class US_Spare_parts
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox3 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            panel2 = new Panel();
            comboBox4 = new ComboBox();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            dataGridViewParts = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BackgroundImage = Properties.Resources.spa;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(0, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(805, 75);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "", "TOYOTA" });
            comboBox1.Location = new Point(507, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(153, 171);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "", "•Engine Parts ", "", "•Brakes ", "", "•Suspension ", "", "•Electrical ", "", "•Filters ", "", "•Cooling System", "", "•Transmission" });
            comboBox3.Location = new Point(507, 35);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(507, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 27);
            textBox3.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(153, 227);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(152, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(comboBox4);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(comboBox2);
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(797, 299);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(153, 109);
            comboBox4.Margin = new Padding(3, 4, 3, 4);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label10.ForeColor = Color.Coral;
            label10.Location = new Point(397, 240);
            label10.Name = "label10";
            label10.Size = new Size(51, 25);
            label10.TabIndex = 19;
            label10.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(462, 238);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label9.ForeColor = Color.Coral;
            label9.Location = new Point(53, 35);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 17;
            label9.Text = "Part ID";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 35);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 27);
            textBox4.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label8.ForeColor = Color.Coral;
            label8.Location = new Point(397, 103);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 15;
            label8.Text = "Supplier";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label7.ForeColor = Color.Coral;
            label7.Location = new Point(391, 174);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 14;
            label7.Text = "Unit Price";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.Coral;
            label6.Location = new Point(23, 229);
            label6.Name = "label6";
            label6.Size = new Size(122, 25);
            label6.TabIndex = 13;
            label6.Text = "QuantitySold";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.Coral;
            label5.Location = new Point(391, 35);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 12;
            label5.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(33, 172);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 11;
            label4.Text = "Car Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 99);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(33, 112);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 8;
            label1.Text = "Part Name";
            // 
            // dataGridViewParts
            // 
            dataGridViewParts.BackgroundColor = SystemColors.ControlText;
            dataGridViewParts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewParts.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewParts.Dock = DockStyle.Bottom;
            dataGridViewParts.EnableHeadersVisualStyles = false;
            dataGridViewParts.Location = new Point(0, 470);
            dataGridViewParts.Name = "dataGridViewParts";
            dataGridViewParts.RowHeadersVisible = false;
            dataGridViewParts.RowHeadersWidth = 51;
            dataGridViewParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewParts.Size = new Size(752, 183);
            dataGridViewParts.TabIndex = 9;
            dataGridViewParts.CellClick += dataGridViewParts_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(33, 150, 243);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.Location = new Point(23, 368);
            button1.Name = "button1";
            button1.Size = new Size(100, 36);
            button1.TabIndex = 10;
            button1.Text = "Add Part";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(33, 150, 243);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.Location = new Point(179, 368);
            button2.Name = "button2";
            button2.Size = new Size(102, 36);
            button2.TabIndex = 11;
            button2.Text = "Update Part";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(33, 150, 243);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button3.Location = new Point(367, 368);
            button3.Name = "button3";
            button3.Size = new Size(97, 36);
            button3.TabIndex = 12;
            button3.Text = "Delete Part";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(33, 150, 243);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button4.Location = new Point(534, 368);
            button4.Name = "button4";
            button4.Size = new Size(90, 36);
            button4.TabIndex = 13;
            button4.Text = "Clear Fields";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 433);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 27);
            textBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(83, 432);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 15;
            label2.Text = "Search Part :";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(33, 150, 243);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(441, 428);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(84, 38);
            button5.TabIndex = 18;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // US_Spare_parts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_2025_05_04_01_39_474;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridViewParts);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "US_Spare_parts";
            Size = new Size(752, 653);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox3;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridViewParts;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label2;
        private Label label9;
        private TextBox textBox4;
        private Button button5;
        private Label label10;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox4;
    }
}
