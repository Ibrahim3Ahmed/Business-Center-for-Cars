namespace WinFormsApp8
{
    partial class US_Maintenance
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            orderid = new DataGridViewTextBoxColumn();
            QuantitySold = new DataGridViewTextBoxColumn();
            Customername = new DataGridViewTextBoxColumn();
            Servicerequested = new DataGridViewTextBoxColumn();
            Carmodel = new DataGridViewTextBoxColumn();
            Requeststatus = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            comboBox4 = new ComboBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Maintenance_Services;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 65);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(353, 86);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 1;
            label1.Text = "Customer Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(517, 87);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(155, 28);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Oil Change", "Filter Replacement", "Mechanics", "Electrical" });
            comboBox2.Location = new Point(192, 167);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(155, 28);
            comboBox2.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(517, 167);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(155, 28);
            comboBox3.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(517, 252);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 27);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(370, 169);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 6;
            label2.Text = "Car Model";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(405, 255);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 7;
            label3.Text = "Cost";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(0, 164);
            label4.Name = "label4";
            label4.Size = new Size(186, 28);
            label4.TabIndex = 8;
            label4.Text = "Service Requested";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(305, 366);
            button1.Name = "button1";
            button1.Size = new Size(153, 45);
            button1.TabIndex = 9;
            button1.Text = "Save Request";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlText;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { orderid, QuantitySold, Customername, Servicerequested, Carmodel, Requeststatus, Cost, Date });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 417);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(885, 236);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // orderid
            // 
            orderid.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            orderid.Frozen = true;
            orderid.HeaderText = "Order ID ";
            orderid.MinimumWidth = 6;
            orderid.Name = "orderid";
            orderid.ReadOnly = true;
            orderid.Width = 70;
            // 
            // QuantitySold
            // 
            QuantitySold.Frozen = true;
            QuantitySold.HeaderText = "QuantitySold";
            QuantitySold.MinimumWidth = 6;
            QuantitySold.Name = "QuantitySold";
            QuantitySold.Width = 125;
            // 
            // Customername
            // 
            Customername.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Customername.Frozen = true;
            Customername.HeaderText = "Customer Name";
            Customername.MinimumWidth = 6;
            Customername.Name = "Customername";
            Customername.ReadOnly = true;
            Customername.Width = 110;
            // 
            // Servicerequested
            // 
            Servicerequested.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Servicerequested.Frozen = true;
            Servicerequested.HeaderText = "Service Requested";
            Servicerequested.MinimumWidth = 6;
            Servicerequested.Name = "Servicerequested";
            Servicerequested.ReadOnly = true;
            Servicerequested.Width = 125;
            // 
            // Carmodel
            // 
            Carmodel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Carmodel.Frozen = true;
            Carmodel.HeaderText = "Car Model";
            Carmodel.MinimumWidth = 6;
            Carmodel.Name = "Carmodel";
            Carmodel.ReadOnly = true;
            Carmodel.Width = 120;
            // 
            // Requeststatus
            // 
            Requeststatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Requeststatus.Frozen = true;
            Requeststatus.HeaderText = "Request Status";
            Requeststatus.MinimumWidth = 6;
            Requeststatus.Name = "Requeststatus";
            Requeststatus.ReadOnly = true;
            Requeststatus.Width = 70;
            // 
            // Cost
            // 
            Cost.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Cost.Frozen = true;
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 6;
            Cost.Name = "Cost";
            Cost.ReadOnly = true;
            Cost.Width = 60;
            // 
            // Date
            // 
            Date.Frozen = true;
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // comboBox4
            // 
            comboBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox4.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "", "Pending", "In Progress", "Completed", "Delayed" });
            comboBox4.Location = new Point(192, 249);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(155, 28);
            comboBox4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Coral;
            label5.Location = new Point(3, 249);
            label5.Name = "label5";
            label5.Size = new Size(153, 28);
            label5.TabIndex = 13;
            label5.Text = "Request Status";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 87);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 27);
            textBox2.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Coral;
            label6.Location = new Point(38, 87);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 15;
            label6.Text = "Order ID";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Coral;
            label7.Location = new Point(50, 323);
            label7.Name = "label7";
            label7.Size = new Size(57, 28);
            label7.TabIndex = 16;
            label7.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(125, 320);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(517, 320);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(155, 27);
            numericUpDown1.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Coral;
            label8.Location = new Point(370, 320);
            label8.Name = "label8";
            label8.Size = new Size(136, 28);
            label8.TabIndex = 19;
            label8.Text = "QuantitySold";
            // 
            // US_Maintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.DarkCyan;
            BackgroundImage = Properties.Resources.photo_2025_05_04_01_39_473;
            Controls.Add(label8);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(comboBox4);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "US_Maintenance";
            Size = new Size(885, 653);
            Load += US_Maintenance_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox comboBox4;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private Label label8;
        private DataGridViewTextBoxColumn orderid;
        private DataGridViewTextBoxColumn QuantitySold;
        private DataGridViewTextBoxColumn Customername;
        private DataGridViewTextBoxColumn Servicerequested;
        private DataGridViewTextBoxColumn Carmodel;
        private DataGridViewTextBoxColumn Requeststatus;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewTextBoxColumn Date;
    }
}
