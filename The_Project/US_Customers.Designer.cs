namespace WinFormsApp8
{
    partial class US_Customers
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtsearch = new TextBox();
            label3 = new Label();
            search = new Button();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Update = new Button();
            Add = new Button();
            txtid = new TextBox();
            txtname = new TextBox();
            txtphone = new TextBox();
            txtaddress = new TextBox();
            txtservice = new TextBox();
            panel1 = new Panel();
            txtprice = new TextBox();
            DeleteRow = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(208, 248);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(197, 31);
            txtsearch.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(15, 247);
            label3.Name = "label3";
            label3.Size = new Size(173, 25);
            label3.TabIndex = 4;
            label3.Text = "Search Customers :";
            // 
            // search
            // 
            search.BackColor = SystemColors.ActiveCaption;
            search.FlatAppearance.BorderSize = 0;
            search.FlatStyle = FlatStyle.Flat;
            search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search.ForeColor = Color.Black;
            search.Location = new Point(426, 244);
            search.Name = "search";
            search.Size = new Size(151, 35);
            search.TabIndex = 5;
            search.Text = "Search Customers\r\n";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlText;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 328);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(891, 325);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Edit.Frozen = true;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 75;
            // 
            // Update
            // 
            Update.BackColor = SystemColors.ActiveCaption;
            Update.FlatStyle = FlatStyle.Flat;
            Update.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update.ForeColor = SystemColors.ActiveCaptionText;
            Update.Location = new Point(208, 173);
            Update.Margin = new Padding(2, 3, 2, 3);
            Update.Name = "Update";
            Update.Size = new Size(91, 37);
            Update.TabIndex = 7;
            Update.Text = "Update";
            Update.TextAlign = ContentAlignment.TopCenter;
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // Add
            // 
            Add.BackColor = SystemColors.ActiveCaption;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add.ForeColor = SystemColors.ActiveCaptionText;
            Add.Location = new Point(93, 174);
            Add.Margin = new Padding(2, 3, 2, 3);
            Add.Name = "Add";
            Add.Size = new Size(95, 36);
            Add.TabIndex = 8;
            Add.Text = "Add";
            Add.TextAlign = ContentAlignment.TopCenter;
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(15, 108);
            txtid.Margin = new Padding(2, 3, 2, 3);
            txtid.Name = "txtid";
            txtid.PlaceholderText = "ID";
            txtid.Size = new Size(61, 27);
            txtid.TabIndex = 10;
            txtid.TextAlign = HorizontalAlignment.Center;
            // 
            // txtname
            // 
            txtname.Location = new Point(81, 108);
            txtname.Margin = new Padding(2, 3, 2, 3);
            txtname.Name = "txtname";
            txtname.PlaceholderText = "Name";
            txtname.Size = new Size(69, 27);
            txtname.TabIndex = 11;
            txtname.TextAlign = HorizontalAlignment.Center;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(155, 108);
            txtphone.Margin = new Padding(2, 3, 2, 3);
            txtphone.Name = "txtphone";
            txtphone.PlaceholderText = "Phone";
            txtphone.Size = new Size(75, 27);
            txtphone.TabIndex = 12;
            txtphone.TextAlign = HorizontalAlignment.Center;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(235, 108);
            txtaddress.Margin = new Padding(2, 3, 2, 3);
            txtaddress.Name = "txtaddress";
            txtaddress.PlaceholderText = "Address";
            txtaddress.Size = new Size(90, 27);
            txtaddress.TabIndex = 13;
            txtaddress.TextAlign = HorizontalAlignment.Center;
            // 
            // txtservice
            // 
            txtservice.Location = new Point(330, 108);
            txtservice.Margin = new Padding(2, 3, 2, 3);
            txtservice.Name = "txtservice";
            txtservice.PlaceholderText = "Service";
            txtservice.Size = new Size(90, 27);
            txtservice.TabIndex = 14;
            txtservice.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Customer_Management;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 68);
            panel1.TabIndex = 16;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(426, 108);
            txtprice.Margin = new Padding(3, 4, 3, 4);
            txtprice.Name = "txtprice";
            txtprice.PlaceholderText = "       Price";
            txtprice.Size = new Size(86, 27);
            txtprice.TabIndex = 17;
            // 
            // DeleteRow
            // 
            DeleteRow.BackColor = Color.Transparent;
            DeleteRow.CustomizableEdges = customizableEdges1;
            DeleteRow.DisabledState.BorderColor = Color.DarkGray;
            DeleteRow.DisabledState.CustomBorderColor = Color.DarkGray;
            DeleteRow.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DeleteRow.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DeleteRow.FillColor = SystemColors.ActiveCaption;
            DeleteRow.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteRow.ForeColor = Color.Black;
            DeleteRow.Location = new Point(325, 174);
            DeleteRow.Name = "DeleteRow";
            DeleteRow.PressedColor = Color.Bisque;
            DeleteRow.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DeleteRow.Size = new Size(95, 36);
            DeleteRow.TabIndex = 18;
            DeleteRow.Text = "Delete";
            DeleteRow.Click += DeleteRow_Click_1;
            // 
            // US_Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.photo_2025_05_04_01_39_472;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(DeleteRow);
            Controls.Add(txtprice);
            Controls.Add(panel1);
            Controls.Add(txtservice);
            Controls.Add(txtaddress);
            Controls.Add(txtphone);
            Controls.Add(txtname);
            Controls.Add(txtid);
            Controls.Add(Add);
            Controls.Add(Update);
            Controls.Add(dataGridView1);
            Controls.Add(search);
            Controls.Add(label3);
            Controls.Add(txtsearch);
            ForeColor = SystemColors.ActiveCaption;
            Margin = new Padding(3, 4, 3, 4);
            Name = "US_Customers";
            Size = new Size(891, 653);
            Load += US_Customers_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtsearch;
        private Label label3;
        private Button search;
        private DataGridView dataGridView1;
        private Button Update;
        private Button Add;
        private TextBox txtid;
        private TextBox txtname;
        private TextBox txtphone;
        private TextBox txtaddress;
        private TextBox txtservice;
        private Panel panel1;
        private DataGridViewTextBoxColumn ID_Customer;
        private DataGridViewTextBoxColumn Customer_Name;
        private DataGridViewTextBoxColumn Phone_Customer;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Service_Customer;
        private DataGridViewButtonColumn Edit;
        private TextBox txtprice;
        private Guna.UI2.WinForms.Guna2Button DeleteRow;
    }
}
