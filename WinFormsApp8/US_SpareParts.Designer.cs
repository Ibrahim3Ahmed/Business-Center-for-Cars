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
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            panel2 = new Panel();
            dataGridViewParts = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Part_ID = new DataGridViewTextBoxColumn();
            Part_Name = new DataGridViewTextBoxColumn();
            Car_Model = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Unit_Price = new DataGridViewTextBoxColumn();
            Supplier = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.spa;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(0, -9);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 83);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(476, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(155, 103);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(476, 35);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(476, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 27);
            textBox3.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(156, 167);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 7;
            // 
            // panel2
            // 
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
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(comboBox2);
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(691, 226);
            panel2.TabIndex = 8;
            // 
            // dataGridViewParts
            // 
            dataGridViewParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParts.Columns.AddRange(new DataGridViewColumn[] { Part_ID, Part_Name, Car_Model, Category, Quantity, Unit_Price, Supplier });
            dataGridViewParts.Dock = DockStyle.Bottom;
            dataGridViewParts.Location = new Point(0, 392);
            dataGridViewParts.Name = "dataGridViewParts";
            dataGridViewParts.RowHeadersVisible = false;
            dataGridViewParts.RowHeadersWidth = 51;
            dataGridViewParts.Size = new Size(691, 261);
            dataGridViewParts.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 8;
            label1.Text = "Part Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 98);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 106);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 11;
            label4.Text = "Car Model";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(382, 35);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 12;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 173);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 13;
            label6.Text = "Quantity in Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(367, 173);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 14;
            label7.Text = "Unit Price";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(382, 106);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 15;
            label8.Text = "Supplier";
            // 
            // Part_ID
            // 
            Part_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Part_ID.HeaderText = "Part ID";
            Part_ID.MinimumWidth = 6;
            Part_ID.Name = "Part_ID";
            Part_ID.ReadOnly = true;
            Part_ID.Width = 80;
            // 
            // Part_Name
            // 
            Part_Name.HeaderText = "Part Name";
            Part_Name.MinimumWidth = 6;
            Part_Name.Name = "Part_Name";
            Part_Name.ReadOnly = true;
            Part_Name.Width = 125;
            // 
            // Car_Model
            // 
            Car_Model.HeaderText = "Car Model";
            Car_Model.MinimumWidth = 6;
            Car_Model.Name = "Car_Model";
            Car_Model.ReadOnly = true;
            Car_Model.Width = 110;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 110;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 70;
            // 
            // Unit_Price
            // 
            Unit_Price.HeaderText = "Unit Price";
            Unit_Price.MinimumWidth = 6;
            Unit_Price.Name = "Unit_Price";
            Unit_Price.ReadOnly = true;
            Unit_Price.Width = 102;
            // 
            // Supplier
            // 
            Supplier.HeaderText = "Supplier";
            Supplier.MinimumWidth = 6;
            Supplier.Name = "Supplier";
            Supplier.ReadOnly = true;
            Supplier.Width = 90;
            // 
            // button1
            // 
            button1.Location = new Point(8, 295);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Add Part";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(179, 295);
            button2.Name = "button2";
            button2.Size = new Size(109, 29);
            button2.TabIndex = 11;
            button2.Text = "Update Part";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(367, 295);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Delete Part";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(533, 295);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 13;
            button4.Text = "Clear Fields";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 347);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 27);
            textBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 350);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 15;
            label2.Text = "Search Part :";
            // 
            // US_Spare_parts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Size = new Size(691, 653);
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
        private TextBox textBox2;
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
        private DataGridViewTextBoxColumn Part_ID;
        private DataGridViewTextBoxColumn Part_Name;
        private DataGridViewTextBoxColumn Car_Model;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Unit_Price;
        private DataGridViewTextBoxColumn Supplier;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label2;
    }
}
