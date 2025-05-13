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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridCars = new DataGridView();
            CarID = new DataGridViewTextBoxColumn();
            CarModel = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            txtSearch = new TextBox();
            btnsearch = new Button();
            label2 = new Label();
            panel1 = new Panel();
            addcar = new Button();
            txtcarid = new TextBox();
            txtstatus = new TextBox();
            txtprice = new TextBox();
            update = new Button();
            clear = new Button();
            txtcustomername = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridCars
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridCars.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCars.BackgroundColor = SystemColors.ControlText;
            dataGridCars.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCars.Columns.AddRange(new DataGridViewColumn[] { CarID, CarModel, Status, Price, Edit });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridCars.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridCars.EnableHeadersVisualStyles = false;
            dataGridCars.Location = new Point(0, 451);
            dataGridCars.Name = "dataGridCars";
            dataGridCars.ReadOnly = true;
            dataGridCars.RowHeadersVisible = false;
            dataGridCars.RowHeadersWidth = 51;
            dataGridCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCars.Size = new Size(1063, 518);
            dataGridCars.TabIndex = 1;
            dataGridCars.CellClick += dataGridCars_CellClick;
            dataGridCars.CellContentClick += dataGridCars_CellContentClick;
            // 
            // CarID
            // 
            CarID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CarID.DataPropertyName = "ID";
            CarID.HeaderText = "Car ID";
            CarID.MinimumWidth = 6;
            CarID.Name = "CarID";
            CarID.ReadOnly = true;
            CarID.Width = 90;
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
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Status.DataPropertyName = "Status";
            Status.FillWeight = 16.042778F;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 130;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Price.DataPropertyName = "Price";
            Price.FillWeight = 16.042778F;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 150;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Edit.FillWeight = 16.042778F;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 125;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(144, 331);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(293, 36);
            txtSearch.TabIndex = 3;
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.FromArgb(33, 150, 243);
            btnsearch.FlatAppearance.BorderSize = 0;
            btnsearch.FlatStyle = FlatStyle.Flat;
            btnsearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsearch.ForeColor = Color.Black;
            btnsearch.Location = new Point(469, 331);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(128, 36);
            btnsearch.TabIndex = 5;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnAddCar_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(20, 335);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 8;
            label2.Text = "Search Car :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources._1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1063, 68);
            panel1.TabIndex = 9;
            // 
            // addcar
            // 
            addcar.BackColor = SystemColors.ActiveCaption;
            addcar.FlatAppearance.BorderSize = 0;
            addcar.FlatStyle = FlatStyle.Flat;
            addcar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addcar.ForeColor = Color.Black;
            addcar.Location = new Point(129, 234);
            addcar.Margin = new Padding(3, 4, 3, 4);
            addcar.Name = "addcar";
            addcar.Size = new Size(117, 36);
            addcar.TabIndex = 10;
            addcar.Text = "Add Car";
            addcar.UseVisualStyleBackColor = false;
            addcar.Click += addcar_Click;
            // 
            // txtcarid
            // 
            txtcarid.Location = new Point(32, 149);
            txtcarid.Margin = new Padding(3, 4, 3, 4);
            txtcarid.Name = "txtcarid";
            txtcarid.PlaceholderText = "ID";
            txtcarid.Size = new Size(52, 27);
            txtcarid.TabIndex = 11;
            txtcarid.TextAlign = HorizontalAlignment.Center;
            // 
            // txtstatus
            // 
            txtstatus.Location = new Point(321, 148);
            txtstatus.Margin = new Padding(3, 4, 3, 4);
            txtstatus.Name = "txtstatus";
            txtstatus.PlaceholderText = "Status";
            txtstatus.Size = new Size(73, 27);
            txtstatus.TabIndex = 13;
            txtstatus.TextAlign = HorizontalAlignment.Center;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(400, 148);
            txtprice.Margin = new Padding(3, 4, 3, 4);
            txtprice.Name = "txtprice";
            txtprice.PlaceholderText = "Price";
            txtprice.Size = new Size(73, 27);
            txtprice.TabIndex = 14;
            txtprice.TextAlign = HorizontalAlignment.Center;
            // 
            // update
            // 
            update.BackColor = SystemColors.ActiveCaption;
            update.FlatAppearance.BorderSize = 0;
            update.FlatStyle = FlatStyle.Flat;
            update.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update.ForeColor = Color.Black;
            update.Location = new Point(480, 234);
            update.Margin = new Padding(3, 4, 3, 4);
            update.Name = "update";
            update.Size = new Size(117, 36);
            update.TabIndex = 15;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // clear
            // 
            clear.BackColor = SystemColors.ActiveCaption;
            clear.FlatAppearance.BorderSize = 0;
            clear.FlatStyle = FlatStyle.Flat;
            clear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.ForeColor = Color.Black;
            clear.Location = new Point(296, 234);
            clear.Margin = new Padding(3, 4, 3, 4);
            clear.Name = "clear";
            clear.Size = new Size(125, 36);
            clear.TabIndex = 16;
            clear.Text = "Delete Row";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // txtcustomername
            // 
            txtcustomername.Location = new Point(90, 149);
            txtcustomername.Margin = new Padding(3, 4, 3, 4);
            txtcustomername.Name = "txtcustomername";
            txtcustomername.PlaceholderText = "CustomerName";
            txtcustomername.Size = new Size(103, 27);
            txtcustomername.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(587, 148);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(215, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(480, 148);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(101, 27);
            numericUpDown1.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(199, 148);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(113, 28);
            comboBox1.TabIndex = 20;
            // 
            // US_Cars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.WindowFrame;
            BackgroundImage = Properties.Resources.photo_2025_05_04_01_39_471;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtcustomername);
            Controls.Add(clear);
            Controls.Add(update);
            Controls.Add(txtprice);
            Controls.Add(txtstatus);
            Controls.Add(txtcarid);
            Controls.Add(addcar);
            Controls.Add(panel1);
            Controls.Add(btnsearch);
            Controls.Add(label2);
            Controls.Add(txtSearch);
            Controls.Add(dataGridCars);
            Name = "US_Cars";
            Size = new Size(1066, 972);
            Load += US_Cars_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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

        private TextBox txtcarid;
        private TextBox txtstatus;
        private TextBox txtprice;
        private Button update;
        private Button clear;
        private TextBox txtcustomername;
        private DateTimePicker dateTimePicker1;
        private DataGridViewTextBoxColumn CarID;
        private DataGridViewTextBoxColumn CarModel;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewButtonColumn Edit;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
    }
}
