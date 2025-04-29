namespace WinFormsApp8
{
    partial class US_Reports
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
            tabControl1 = new TabControl();
            tabInvoices = new TabPage();
            tabsales = new TabPage();
            tabPage1 = new TabPage();
            tabAlerts = new TabPage();
            dgvInvoices = new DataGridView();
            button2 = new Button();
            InvoiceID = new DataGridViewTextBoxColumn();
            Customer2Name = new DataGridViewTextBoxColumn();
            Typeofservice = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            dgvSparePartsSales = new DataGridView();
            SparePartName = new DataGridViewTextBoxColumn();
            SupplierName = new DataGridViewTextBoxColumn();
            InStockQuantity = new DataGridViewTextBoxColumn();
            QuantitySold = new DataGridViewTextBoxColumn();
            TotalSalesAmount = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            ServiceName = new DataGridViewTextBoxColumn();
            ServiceCount = new DataGridViewTextBoxColumn();
            TotalServiceSales = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            SparePartName2 = new DataGridViewTextBoxColumn();
            QuantityAvailabel = new DataGridViewTextBoxColumn();
            tabProfit = new TabPage();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabInvoices.SuspendLayout();
            tabsales.SuspendLayout();
            tabPage1.SuspendLayout();
            tabAlerts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSparePartsSales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Reports_Managemenk;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 65);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(168, 11);
            label1.Name = "label1";
            label1.Size = new Size(289, 38);
            label1.TabIndex = 0;
            label1.Text = "Report Management";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabInvoices);
            tabControl1.Controls.Add(tabsales);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabAlerts);
            tabControl1.Controls.Add(tabProfit);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 65);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(691, 588);
            tabControl1.TabIndex = 7;
            // 
            // tabInvoices
            // 
            tabInvoices.BackColor = Color.Transparent;
            tabInvoices.Controls.Add(button2);
            tabInvoices.Controls.Add(dgvInvoices);
            tabInvoices.ForeColor = Color.Coral;
            tabInvoices.Location = new Point(4, 29);
            tabInvoices.Name = "tabInvoices";
            tabInvoices.Padding = new Padding(3);
            tabInvoices.Size = new Size(683, 555);
            tabInvoices.TabIndex = 0;
            tabInvoices.Text = "Invoices";
            // 
            // tabsales
            // 
            tabsales.Controls.Add(dgvSparePartsSales);
            tabsales.Location = new Point(4, 29);
            tabsales.Name = "tabsales";
            tabsales.Padding = new Padding(3);
            tabsales.Size = new Size(683, 555);
            tabsales.TabIndex = 1;
            tabsales.Text = "Spare Parts Sales";
            tabsales.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(683, 555);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Maintenance Services Sales";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabAlerts
            // 
            tabAlerts.Controls.Add(dataGridView2);
            tabAlerts.Location = new Point(4, 29);
            tabAlerts.Name = "tabAlerts";
            tabAlerts.Size = new Size(683, 555);
            tabAlerts.TabIndex = 3;
            tabAlerts.Text = "Inventory Alerts";
            tabAlerts.UseVisualStyleBackColor = true;
            // 
            // dgvInvoices
            // 
            dgvInvoices.BorderStyle = BorderStyle.Fixed3D;
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoices.Columns.AddRange(new DataGridViewColumn[] { InvoiceID, Customer2Name, Typeofservice, Date, Price });
            dgvInvoices.Dock = DockStyle.Top;
            dgvInvoices.Location = new Point(3, 3);
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.RowHeadersVisible = false;
            dgvInvoices.RowHeadersWidth = 51;
            dgvInvoices.Size = new Size(677, 511);
            dgvInvoices.TabIndex = 0;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(267, 520);
            button2.Name = "button2";
            button2.Size = new Size(143, 29);
            button2.TabIndex = 2;
            button2.Text = "Print the invoice";
            button2.UseVisualStyleBackColor = true;
            // 
            // InvoiceID
            // 
            InvoiceID.Frozen = true;
            InvoiceID.HeaderText = "InvoiceID";
            InvoiceID.MinimumWidth = 6;
            InvoiceID.Name = "InvoiceID";
            InvoiceID.Width = 125;
            // 
            // Customer2Name
            // 
            Customer2Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Customer2Name.Frozen = true;
            Customer2Name.HeaderText = "Customer Name";
            Customer2Name.MinimumWidth = 6;
            Customer2Name.Name = "Customer2Name";
            Customer2Name.Width = 150;
            // 
            // Typeofservice
            // 
            Typeofservice.Frozen = true;
            Typeofservice.HeaderText = "Type of service";
            Typeofservice.MinimumWidth = 6;
            Typeofservice.Name = "Typeofservice";
            Typeofservice.Width = 150;
            // 
            // Date
            // 
            Date.Frozen = true;
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // Price
            // 
            Price.Frozen = true;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // dgvSparePartsSales
            // 
            dgvSparePartsSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSparePartsSales.Columns.AddRange(new DataGridViewColumn[] { SparePartName, SupplierName, InStockQuantity, QuantitySold, TotalSalesAmount });
            dgvSparePartsSales.Dock = DockStyle.Fill;
            dgvSparePartsSales.Location = new Point(3, 3);
            dgvSparePartsSales.Name = "dgvSparePartsSales";
            dgvSparePartsSales.RowHeadersVisible = false;
            dgvSparePartsSales.RowHeadersWidth = 51;
            dgvSparePartsSales.Size = new Size(677, 549);
            dgvSparePartsSales.TabIndex = 0;
            // 
            // SparePartName
            // 
            SparePartName.Frozen = true;
            SparePartName.HeaderText = "Spare Part Name";
            SparePartName.MinimumWidth = 6;
            SparePartName.Name = "SparePartName";
            SparePartName.Width = 150;
            // 
            // SupplierName
            // 
            SupplierName.Frozen = true;
            SupplierName.HeaderText = "Supplier Name";
            SupplierName.MinimumWidth = 6;
            SupplierName.Name = "SupplierName";
            SupplierName.Width = 125;
            // 
            // InStockQuantity
            // 
            InStockQuantity.Frozen = true;
            InStockQuantity.HeaderText = "In Stock Quantity";
            InStockQuantity.MinimumWidth = 6;
            InStockQuantity.Name = "InStockQuantity";
            InStockQuantity.Width = 125;
            // 
            // QuantitySold
            // 
            QuantitySold.Frozen = true;
            QuantitySold.HeaderText = "Quantity Sold";
            QuantitySold.MinimumWidth = 6;
            QuantitySold.Name = "QuantitySold";
            QuantitySold.Width = 150;
            // 
            // TotalSalesAmount
            // 
            TotalSalesAmount.Frozen = true;
            TotalSalesAmount.HeaderText = "Total Sales Amount";
            TotalSalesAmount.MinimumWidth = 6;
            TotalSalesAmount.Name = "TotalSalesAmount";
            TotalSalesAmount.Width = 150;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ServiceName, ServiceCount, TotalServiceSales });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(683, 555);
            dataGridView1.TabIndex = 0;
            // 
            // ServiceName
            // 
            ServiceName.Frozen = true;
            ServiceName.HeaderText = "Service Name";
            ServiceName.MinimumWidth = 6;
            ServiceName.Name = "ServiceName";
            ServiceName.Width = 125;
            // 
            // ServiceCount
            // 
            ServiceCount.Frozen = true;
            ServiceCount.HeaderText = "Service Count";
            ServiceCount.MinimumWidth = 6;
            ServiceCount.Name = "ServiceCount";
            ServiceCount.Width = 125;
            // 
            // TotalServiceSales
            // 
            TotalServiceSales.Frozen = true;
            TotalServiceSales.HeaderText = "Total Service Sales";
            TotalServiceSales.MinimumWidth = 6;
            TotalServiceSales.Name = "TotalServiceSales";
            TotalServiceSales.Width = 125;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { SparePartName2, QuantityAvailabel });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(683, 555);
            dataGridView2.TabIndex = 0;
            // 
            // SparePartName2
            // 
            SparePartName2.Frozen = true;
            SparePartName2.HeaderText = "Spare Part Name";
            SparePartName2.MinimumWidth = 6;
            SparePartName2.Name = "SparePartName2";
            SparePartName2.Width = 125;
            // 
            // QuantityAvailabel
            // 
            QuantityAvailabel.Frozen = true;
            QuantityAvailabel.HeaderText = "Quantity Availabel";
            QuantityAvailabel.MinimumWidth = 6;
            QuantityAvailabel.Name = "QuantityAvailabel";
            QuantityAvailabel.Width = 125;
            // 
            // tabProfit
            // 
            tabProfit.Location = new Point(4, 29);
            tabProfit.Name = "tabProfit";
            tabProfit.Size = new Size(683, 555);
            tabProfit.TabIndex = 4;
            tabProfit.Text = "Profit Reports";
            tabProfit.UseVisualStyleBackColor = true;
            // 
            // US_Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            ForeColor = Color.Coral;
            Margin = new Padding(3, 4, 3, 4);
            Name = "US_Reports";
            Size = new Size(691, 653);
            Load += US_Reports_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabInvoices.ResumeLayout(false);
            tabsales.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabAlerts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSparePartsSales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabInvoices;
        private TabPage tabsales;
        private TabPage tabPage1;
        private TabPage tabAlerts;
        private Button button2;
        private DataGridView dgvInvoices;
        private DataGridViewTextBoxColumn InvoiceID;
        private DataGridViewTextBoxColumn Customer2Name;
        private DataGridViewTextBoxColumn Typeofservice;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Price;
        private DataGridView dgvSparePartsSales;
        private DataGridViewTextBoxColumn SparePartName;
        private DataGridViewTextBoxColumn SupplierName;
        private DataGridViewTextBoxColumn InStockQuantity;
        private DataGridViewTextBoxColumn QuantitySold;
        private DataGridViewTextBoxColumn TotalSalesAmount;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ServiceName;
        private DataGridViewTextBoxColumn ServiceCount;
        private DataGridViewTextBoxColumn TotalServiceSales;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn SparePartName2;
        private DataGridViewTextBoxColumn QuantityAvailabel;
        private TabPage tabProfit;
    }
}
