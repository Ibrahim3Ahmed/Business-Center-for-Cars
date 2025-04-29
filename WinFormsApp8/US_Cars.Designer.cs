namespace WinFormsApp8
{
    partial class US_Cars
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dataGridCars = new DataGridView();
            CarID = new DataGridViewTextBoxColumn();
            CarModel = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Details = new DataGridViewButtonColumn();
            txtSearch = new TextBox();
            btnsearch = new Button();
            label2 = new Label();
            panel1 = new Panel();
            addcar = new Button();
            txtcarid = new TextBox();
            txtmodel = new TextBox();
            txtstatus = new TextBox();
            txtprice = new TextBox();
            update = new Button();
            clear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridCars).BeginInit();
            SuspendLayout();
            // 
            // dataGridCars
            // 
            dataGridViewCellStyle7.BackColor = SystemColors.ButtonFace;
            dataGridCars.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCars.BorderStyle = BorderStyle.None;
            dataGridCars.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCars.Columns.AddRange(new DataGridViewColumn[] { CarID, CarModel, Status, Price, Edit, Details });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridCars.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridCars.EnableHeadersVisualStyles = false;
            dataGridCars.Location = new Point(0, 157);
            dataGridCars.Margin = new Padding(3, 2, 3, 2);
            dataGridCars.Name = "dataGridCars";
            dataGridCars.ReadOnly = true;
            dataGridCars.RowHeadersVisible = false;
            dataGridCars.RowHeadersWidth = 51;
            dataGridCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCars.Size = new Size(808, 386);
            dataGridCars.TabIndex = 1;
            dataGridCars.CellClick += dataGridCars_CellClick;
            dataGridCars.CellContentClick += dataGridCars_CellContentClick;
            // 
            // CarID
            // 
            CarID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CarID.DataPropertyName = "ID";
            CarID.HeaderText = "ID";
            CarID.MinimumWidth = 6;
            CarID.Name = "CarID";
            CarID.ReadOnly = true;
            CarID.Width = 80;
            // 
            // CarModel
            // 
            CarModel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CarModel.DataPropertyName = "model";
            CarModel.FillWeight = 435.8289F;
            CarModel.HeaderText = "Car Model";
            CarModel.MinimumWidth = 6;
            CarModel.Name = "CarModel";
            CarModel.ReadOnly = true;
            CarModel.Width = 200;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.FillWeight = 16.042778F;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.FillWeight = 16.042778F;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.FillWeight = 16.042778F;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Details
            // 
            Details.FillWeight = 16.042778F;
            Details.HeaderText = "Details";
            Details.MinimumWidth = 6;
            Details.Name = "Details";
            Details.ReadOnly = true;
            Details.UseColumnTextForButtonValue = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(99, 121);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(270, 31);
            txtSearch.TabIndex = 3;
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.FromArgb(33, 150, 243);
            btnsearch.FlatAppearance.BorderSize = 0;
            btnsearch.FlatStyle = FlatStyle.Flat;
            btnsearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsearch.ForeColor = Color.White;
            btnsearch.Location = new Point(376, 121);
            btnsearch.Margin = new Padding(3, 2, 3, 2);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(189, 32);
            btnsearch.TabIndex = 5;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnAddCar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 126);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 8;
            label2.Text = "Search Car :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 51);
            panel1.TabIndex = 9;
            // 
            // addcar
            // 
            addcar.BackColor = Color.DodgerBlue;
            addcar.ForeColor = Color.White;
            addcar.Location = new Point(503, 85);
            addcar.Name = "addcar";
            addcar.Size = new Size(99, 27);
            addcar.TabIndex = 10;
            addcar.Text = "AddCar";
            addcar.UseVisualStyleBackColor = false;
            addcar.Click += addcar_Click;
            // 
            // txtcarid
            // 
            txtcarid.Location = new Point(3, 71);
            txtcarid.Name = "txtcarid";
            txtcarid.Size = new Size(119, 23);
            txtcarid.TabIndex = 11;
            // 
            // txtmodel
            // 
            txtmodel.Location = new Point(128, 71);
            txtmodel.Name = "txtmodel";
            txtmodel.Size = new Size(125, 23);
            txtmodel.TabIndex = 12;
            // 
            // txtstatus
            // 
            txtstatus.Location = new Point(253, 71);
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new Size(119, 23);
            txtstatus.TabIndex = 13;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(378, 71);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(119, 23);
            txtprice.TabIndex = 14;
            // 
            // update
            // 
            update.BackColor = Color.DodgerBlue;
            update.ForeColor = Color.White;
            update.Location = new Point(503, 56);
            update.Name = "update";
            update.Size = new Size(99, 27);
            update.TabIndex = 15;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.DodgerBlue;
            clear.ForeColor = Color.White;
            clear.Location = new Point(608, 56);
            clear.Name = "clear";
            clear.Size = new Size(84, 56);
            clear.TabIndex = 16;
            clear.Text = "Delete Row";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // US_Cars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.WindowFrame;
            Controls.Add(clear);
            Controls.Add(update);
            Controls.Add(txtprice);
            Controls.Add(txtstatus);
            Controls.Add(txtmodel);
            Controls.Add(txtcarid);
            Controls.Add(addcar);
            Controls.Add(panel1);
            Controls.Add(btnsearch);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(dataGridCars);
            Margin = new Padding(3, 2, 3, 2);
            Name = "US_Cars";
            Size = new Size(811, 545);
            Load += US_Cars_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridCars;
        private TextBox txtSearch;
        private Button btnsearch;
        private Label label2;
        private Panel panel1;
        private Button addcar;
        private DataGridViewTextBoxColumn CarID;
        private DataGridViewTextBoxColumn CarModel;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Details;
        private TextBox txtcarid;
        private TextBox txtmodel;
        private TextBox txtstatus;
        private TextBox txtprice;
        private Button update;
        private Button clear;
    }
}
