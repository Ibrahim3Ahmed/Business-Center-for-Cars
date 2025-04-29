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
        string connectionString = "Data Source=DESKTOP-RHRQ9VP\\SQLEXPRESS;Initial Catalog=Toyota system;Integrated Security=True";
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
            comboBox2.Items.Clear();

          
            comboBox2.Items.Add("");

            
            comboBox2.Items.Add("Oil Change");
            comboBox2.Items.Add("Brake Inspection and Service");
            comboBox2.Items.Add("Engine Tune-Up");
            comboBox2.Items.Add("Battery Check and Replacement");
            comboBox2.Items.Add("Transmission Service");
            comboBox2.Items.Add("Tire Rotation and Alignment");
            comboBox2.Items.Add("Air Filter Replacement");
            comboBox2.Items.Add("Cabin Air Filter Replacement");
            comboBox2.Items.Add("Coolant Flush");
            comboBox2.Items.Add("Spark Plug Replacement");
            comboBox2.Items.Add("Timing Belt Replacement");
            comboBox2.Items.Add("Suspension Check");
            comboBox2.Items.Add("Wheel Balancing");
            comboBox2.Items.Add("AC System Service");
            comboBox2.Items.Add("Exhaust System Inspection");
            comboBox2.Items.Add("Fuel System Cleaning");
            comboBox2.Items.Add("Power Steering Service");
            comboBox2.Items.Add("Hybrid System Check");

          
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDown;

            string connectionString = @"Data Source=DESKTOP-RHRQ9VP\SQLEXPRESS;Initial Catalog=toyota system;Integrated Security=True";
            string query = "SELECT Username FROM Customers";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            comboBox1.Items.Add(""); // أول اختيار فاضي

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Username"].ToString());
            }

            reader.Close();
            connection.Close();

            
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
        }
        private void LoadCarModels()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT model FROM Cars", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                comboBox3.Items.Clear();
                comboBox3.Items.Add("");

                while (reader.Read())
                {
                    if (reader["model"] != DBNull.Value)
                    {
                        comboBox3.Items.Add(reader["model"].ToString());
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
            serviceRequestedColumn.Name = "service requested";
            serviceRequestedColumn.HeaderText = "Service Requested";
            serviceRequestedColumn.DataPropertyName = "service requested";
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

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void LoadMaintenanceServices()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, customername, [service requested], carmodel, status, cost FROM [Maintenance Services]";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}