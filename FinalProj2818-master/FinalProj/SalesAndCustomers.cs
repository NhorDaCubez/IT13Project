using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProj
{
    public partial class SalesAndCustomers : Form
    {
        // Using the most reliable connection string format
        private const string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=FinalProjectDB;Integrated Security=True;TrustServerCertificate=True";

        public SalesAndCustomers()
        {
            InitializeComponent();
            // Call the data loading function when the form loads
            this.Load += new EventHandler(SalesAndCustomers_Load);
        }

        private void SalesAndCustomers_Load(object sender, EventArgs e)
        {
            LoadSalesData();
        }

        // -----------------------------------------------------------------
        // NEW METHOD: Fetches all sales-related data and metrics
        // -----------------------------------------------------------------
        private void LoadSalesData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // --- 1. Load Order Management Grid ---
                    // Assuming 'Order' table contains Order_id, Employee_id, order_date, delivery_date
                    // NOTE: Since you don't have a Customer table yet, the 'Customer' column will be NULL/empty.
                    string orderQuery = @"
                        SELECT 
                            Order_id, 
                            Employee_id AS Customer, -- Placeholder: Replace with actual Customer Name later
                            order_date
                        FROM dbo.[Order]";

                    SqlDataAdapter orderAdapter = new SqlDataAdapter(orderQuery, connection);
                    DataTable ordersTable = new DataTable();
                    orderAdapter.Fill(ordersTable);

                    // CRITICAL: Assuming your Order Management DataGridView is named 'dgvOrders'
                    // If your grid is named 'dataGridView1', you must rename it or change the line below.
                    dgvOrders.DataSource = ordersTable;
                    dgvOrders.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    // --- 2. Calculate Metrics (Orders Today & Total Orders/Customers) ---
                    // NOTE: This assumes orders are sales orders, not purchase orders.

                    // a) Calculate Total Orders Today
                    string todayOrderQuery = @"
                        SELECT COUNT(Order_id) 
                        FROM dbo.[Order] 
                        WHERE CAST(order_date AS DATE) = CAST(GETDATE() AS DATE)";

                    using (SqlCommand todayOrderCmd = new SqlCommand(todayOrderQuery, connection))
                    {
                        object result = todayOrderCmd.ExecuteScalar();
                        // CRITICAL: Assuming your "Orders Today" label is named 'lblOrdersToday'
                        // You must rename your label or change the line below.
                        lblOrdersToday.Text = result?.ToString() ?? "0";
                    }

                    // b) Calculate Total Customers/Orders (Used for Total Customers box)
                    string totalOrderQuery = "SELECT COUNT(Order_id) FROM dbo.[Order]";

                    using (SqlCommand totalOrderCmd = new SqlCommand(totalOrderQuery, connection))
                    {
                        object result = totalOrderCmd.ExecuteScalar();
                        // Assuming your "Total Customers" label is named 'lblTotalCustomers'
                        // This metric is simplistic right now, as it's just a count of all orders.
                        lblTotalCustomers.Text = result?.ToString() ?? "0";
                    }

                    // c) Outstanding (You need a Status column in the Order table for this to work properly)
                    // For now, let's keep it simple: assume all orders are outstanding until marked delivered.
                    // If you added a 'Status' column to Order table:
                    // string outstandingQuery = "SELECT COUNT(Order_id) FROM dbo.[Order] WHERE Status = 'Outstanding'";

                    // Assuming your "Outstanding" label is named 'lblOutstanding'
                    lblOutstanding.Text = "0"; // Defaulting to 0 until proper tracking is set up

                }
                catch (Exception ex)
                {
                    // Displays connection errors if the connectionString or server fails
                    MessageBox.Show("Error loading sales data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // -----------------------------------------------------------------
        // EXISTING CODE
        // -----------------------------------------------------------------
        private void Exx_Click(object sender, EventArgs e)
        {
            // The Mainform constructor now needs the ID and Ranking, 
            // but since this is navigation from the Mainform, we call the parameterless version.
            Mainform ScExit = new Mainform();
            ScExit.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Keeping the original name for your Customer Database DataGridView
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Existing handler
        }
    }
}