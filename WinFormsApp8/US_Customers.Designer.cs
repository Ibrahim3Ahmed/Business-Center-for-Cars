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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            txtsearch = new TextBox();
            label3 = new Label();
            search = new Button();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Update = new Button();
            Add = new Button();
            DeleteRow = new Button();
            txtid = new TextBox();
            txtname = new TextBox();
            txtphone = new TextBox();
            txtaddress = new TextBox();
            txtservice = new TextBox();
            txtprice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icons8_toyota_50;
            pictureBox1.Location = new Point(495, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(196, 21);
            label1.TabIndex = 1;
            label1.Text = "Customers Management";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 76);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(515, 53);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 2;
            label2.Text = "Toyota";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(145, 164);
            txtsearch.Margin = new Padding(3, 2, 3, 2);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(146, 24);
            txtsearch.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 169);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
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
            search.Location = new Point(296, 160);
            search.Margin = new Padding(3, 2, 3, 2);
            search.Name = "search";
            search.Size = new Size(161, 26);
            search.TabIndex = 5;
            search.Text = "Search Customers\r\n";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 189);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(780, 301);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 75;
            // 
            // Update
            // 
            Update.Location = new Point(586, 124);
            Update.Margin = new Padding(2);
            Update.Name = "Update";
            Update.Size = new Size(79, 20);
            Update.TabIndex = 7;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // Add
            // 
            Add.Location = new Point(586, 148);
            Add.Margin = new Padding(2);
            Add.Name = "Add";
            Add.Size = new Size(79, 20);
            Add.TabIndex = 8;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // DeleteRow
            // 
            DeleteRow.Location = new Point(668, 126);
            DeleteRow.Margin = new Padding(2);
            DeleteRow.Name = "DeleteRow";
            DeleteRow.Size = new Size(79, 20);
            DeleteRow.TabIndex = 9;
            DeleteRow.Text = "Delete Row";
            DeleteRow.UseVisualStyleBackColor = true;
            DeleteRow.Click += DeleteRow_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(59, 81);
            txtid.Margin = new Padding(2);
            txtid.Name = "txtid";
            txtid.Size = new Size(106, 23);
            txtid.TabIndex = 10;
            // 
            // txtname
            // 
            txtname.Location = new Point(168, 81);
            txtname.Margin = new Padding(2);
            txtname.Name = "txtname";
            txtname.Size = new Size(106, 23);
            txtname.TabIndex = 11;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(277, 81);
            txtphone.Margin = new Padding(2);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(106, 23);
            txtphone.TabIndex = 12;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(387, 81);
            txtaddress.Margin = new Padding(2);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(106, 23);
            txtaddress.TabIndex = 13;
            // 
            // txtservice
            // 
            txtservice.Location = new Point(495, 81);
            txtservice.Margin = new Padding(2);
            txtservice.Name = "txtservice";
            txtservice.Size = new Size(106, 23);
            txtservice.TabIndex = 14;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(608, 81);
            txtprice.Margin = new Padding(2);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(106, 23);
            txtprice.TabIndex = 15;
            // 
            // US_Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtprice);
            Controls.Add(txtservice);
            Controls.Add(txtaddress);
            Controls.Add(txtphone);
            Controls.Add(txtname);
            Controls.Add(txtid);
            Controls.Add(DeleteRow);
            Controls.Add(Add);
            Controls.Add(Update);
            Controls.Add(dataGridView1);
            Controls.Add(search);
            Controls.Add(label3);
            Controls.Add(txtsearch);
            Controls.Add(panel1);
            Name = "US_Customers";
            Size = new Size(780, 490);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox txtsearch;
        private Label label3;
        private Button search;
        private DataGridView dataGridView1;
        private Button Update;
        private Button Add;
        private Button DeleteRow;
        private TextBox txtid;
        private TextBox txtname;
        private TextBox txtphone;
        private TextBox txtaddress;
        private TextBox txtservice;
        private TextBox txtprice;
        private DataGridViewButtonColumn Edit;
    }
}
