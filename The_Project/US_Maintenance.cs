using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class US_Maintenance : UserControl
    {
        string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
        public US_Maintenance()
        {
            InitializeComponent();
            this.Load += US_Maintenance_Load;
            LoadCarModels();
        }


        private void US_Maintenance_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadMaintenanceServices();
            LoadCarModels();
            Loadcustomer();
            Loadservice();
           
        }
        private void Loadcustomer()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Username FROM Customers";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow empty = dt.NewRow();
                empty["Username"] = "";
                dt.Rows.InsertAt(empty, 0);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Username";
                comboBox1.ValueMember = "Username";
                comboBox1.SelectedIndex = 0;
            }
        }
        private void Loadservice()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT service FROM Inventory";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow empty = dt.NewRow();
                empty["service"] = "";
                dt.Rows.InsertAt(empty, 0);
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "sercive";
                comboBox2.ValueMember = "service";
                comboBox2.SelectedIndex = 0;
            }
        }
        private void LoadCarModels()
        {
            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT carmodel FROM Inventory", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                comboBox3.Items.Clear();
                comboBox3.Items.Add("");

                while (reader.Read())
                {
                    if (reader["carmodel"] != DBNull.Value)
                    {
                        comboBox3.Items.Add(reader["carmodel"].ToString());
                    }
                }

                reader.Close();
            }

            comboBox3.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox3.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ID";
            idColumn.HeaderText = "Order ID";
            idColumn.DataPropertyName = "ID";
            dataGridView1.Columns.Add(idColumn);

            DataGridViewTextBoxColumn customerNameColumn = new DataGridViewTextBoxColumn();
            customerNameColumn.Name = "customername";
            customerNameColumn.HeaderText = "Customer Name";
            customerNameColumn.DataPropertyName = "customername";
            dataGridView1.Columns.Add(customerNameColumn);

            DataGridViewTextBoxColumn serviceRequestedColumn = new DataGridViewTextBoxColumn();
            serviceRequestedColumn.Name = "servicerequested";
            serviceRequestedColumn.HeaderText = "Servicerequested";
            serviceRequestedColumn.DataPropertyName = "servicerequested";
            dataGridView1.Columns.Add(serviceRequestedColumn);

            DataGridViewTextBoxColumn carModelColumn = new DataGridViewTextBoxColumn();
            carModelColumn.Name = "carmodel";
            carModelColumn.HeaderText = "Car Model";
            carModelColumn.DataPropertyName = "carmodel";
            dataGridView1.Columns.Add(carModelColumn);

            DataGridViewTextBoxColumn statusColumn = new DataGridViewTextBoxColumn();
            statusColumn.Name = "status";
            statusColumn.HeaderText = "Request Status";
            statusColumn.DataPropertyName = "status";
            dataGridView1.Columns.Add(statusColumn);

            DataGridViewTextBoxColumn costColumn = new DataGridViewTextBoxColumn();
            costColumn.Name = "cost";
            costColumn.HeaderText = "Cost";
            costColumn.DataPropertyName = "cost";
            dataGridView1.Columns.Add(costColumn);

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.Name = "date";
            dateColumn.HeaderText = "Date";
            dateColumn.DataPropertyName = "date";
            dataGridView1.Columns.Add(dateColumn);

            DataGridViewTextBoxColumn soldColumn = new DataGridViewTextBoxColumn();
            soldColumn.Name = "Quantitysold";
            soldColumn.HeaderText = "QuantitySold";
            soldColumn.DataPropertyName = "Quantitysold";
            dataGridView1.Columns.Add(soldColumn);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void LoadMaintenanceServices()
        {
            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, customername, servicerequested, carmodel, status, cost,Quantitysold,date FROM [Maintenance Services]";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-LULQNSK\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. إدخال بيانات الصيانة
                    string insertQuery = "INSERT INTO [Maintenance Services] (ID, carmodel, status, customername, cost, servicerequested, Quantitysold, date) " +
                                         "VALUES (@orderid, @Carmodel, @Requeststatus, @Customername, @Cost, @Servicerequested, @QuantitySold, @Date)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction);
                    insertCmd.Parameters.AddWithValue("@orderid", textBox2.Text);
                    insertCmd.Parameters.AddWithValue("@Customername", comboBox1.Text);
                    insertCmd.Parameters.AddWithValue("@Servicerequested", comboBox2.Text);
                    insertCmd.Parameters.AddWithValue("@Carmodel", comboBox3.Text);
                    insertCmd.Parameters.AddWithValue("@Requeststatus", comboBox4.Text);
                    insertCmd.Parameters.AddWithValue("@Cost", textBox1.Text);
                    insertCmd.Parameters.AddWithValue("@QuantitySold", numericUpDown1.Value);
                    insertCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);
                    insertCmd.ExecuteNonQuery();

                    // 2. تقليل المخزون من جدول inventory
                    string updateInventory = "UPDATE inventory SET serviceinstock = serviceinstock - @qty WHERE service = @Servicerequested";
                    SqlCommand updateCmd = new SqlCommand(updateInventory, conn, transaction);
                    updateCmd.Parameters.AddWithValue("@qty", numericUpDown1.Value);
                    updateCmd.Parameters.AddWithValue("@Servicerequested", comboBox2.Text);
                    updateCmd.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("تمت إضافة الصيانة وتحديث المخزون بنجاح!");
                    LoadMaintenanceServices();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("حصل خطأ أثناء الإضافة: " + ex.Message);
                }
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void US_Maintenance_Load_1(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}