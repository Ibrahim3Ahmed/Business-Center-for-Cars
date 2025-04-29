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
            order_id = new DataGridViewTextBoxColumn();
            Customer_Name = new DataGridViewTextBoxColumn();
            Service_Type = new DataGridViewTextBoxColumn();
            Car_Model = new DataGridViewTextBoxColumn();
            Request_Status = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            comboBox4 = new ComboBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Maintenance_Services;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(745, 49);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 101);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
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
            comboBox1.Location = new Point(191, 101);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(279, 23);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Oil Change", "Filter Replacement", "Mechanics", "Electrical" });
            comboBox2.Location = new Point(192, 139);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(278, 23);
            comboBox2.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(192, 176);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(279, 23);
            comboBox3.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 248);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 23);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 176);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 6;
            label2.Text = "Car Model";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 248);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 7;
            label3.Text = "Cost";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 141);
            label4.Name = "label4";
            label4.Size = new Size(150, 21);
            label4.TabIndex = 8;
            label4.Text = "Service Requested";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(266, 275);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(120, 34);
            button1.TabIndex = 9;
            button1.Text = "Save Request";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { order_id, Customer_Name, Service_Type, Car_Model, Request_Status, Cost });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 313);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(745, 177);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // order_id
            // 
            order_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            order_id.HeaderText = "Order ID ";
            order_id.MinimumWidth = 6;
            order_id.Name = "order_id";
            order_id.ReadOnly = true;
            order_id.Width = 80;
            // 
            // Customer_Name
            // 
            Customer_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Customer_Name.HeaderText = "Customer Name";
            Customer_Name.MinimumWidth = 6;
            Customer_Name.Name = "Customer_Name";
            Customer_Name.ReadOnly = true;
            Customer_Name.Width = 125;
            // 
            // Service_Type
            // 
            Service_Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Service_Type.HeaderText = "Service Requested";
            Service_Type.MinimumWidth = 6;
            Service_Type.Name = "Service_Type";
            Service_Type.ReadOnly = true;
            Service_Type.Width = 125;
            // 
            // Car_Model
            // 
            Car_Model.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Car_Model.HeaderText = "Car Model";
            Car_Model.MinimumWidth = 6;
            Car_Model.Name = "Car_Model";
            Car_Model.ReadOnly = true;
            Car_Model.Width = 120;
            // 
            // Request_Status
            // 
            Request_Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Request_Status.HeaderText = "Request Status";
            Request_Status.MinimumWidth = 6;
            Request_Status.Name = "Request_Status";
            Request_Status.ReadOnly = true;
            Request_Status.Width = 80;
            // 
            // Cost
            // 
            Cost.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 6;
            Cost.Name = "Cost";
            Cost.ReadOnly = true;
            Cost.Width = 80;
            // 
            // comboBox4
            // 
            comboBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox4.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "", "Pending", "In Progress", "Completed", "Delayed" });
            comboBox4.Location = new Point(192, 212);
            comboBox4.Margin = new Padding(3, 2, 3, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(279, 23);
            comboBox4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 210);
            label5.Name = "label5";
            label5.Size = new Size(122, 21);
            label5.TabIndex = 13;
            label5.Text = "Request Status";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(191, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 23);
            textBox2.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(73, 64);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 15;
            label6.Text = "Order ID";
            // 
            // US_Maintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
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
            Name = "US_Maintenance";
            Size = new Size(745, 490);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridViewTextBoxColumn order_id;
        private DataGridViewTextBoxColumn Customer_Name;
        private DataGridViewTextBoxColumn Service_Type;
        private DataGridViewTextBoxColumn Car_Model;
        private DataGridViewTextBoxColumn Request_Status;
        private DataGridViewTextBoxColumn Cost;
    }
}
