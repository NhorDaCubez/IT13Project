using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProj
{
    public partial class SalesAndCustomers : Form
    {
        // Connection String
        private const string connectionString = "Data Source=LAPTOP-VHI1EE4Q\\SQLEXPRESS;Initial Catalog=FinalProjectDB;Integrated Security=True;TrustServerCertificate=True";

        public SalesAndCustomers()
        {
            InitializeComponent();
            this.Load += new EventHandler(SalesAndCustomers_Load);
        }

        private void SalesAndCustomers_Load(object sender, EventArgs e)
        {
            LoadSalesData();
        }

        private void LoadSalesData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // --- 1. Load Order Management Grid with Order Total ---
                    // This query calculates the total value for each order (Quantity * Price)
                    // and groups the results by Order_id.
                    string orderQuery = @"
                        SELECT  
                            T1.Order_id, 
                            T1.Employee_id AS Creator_ID, -- Employee who created the order
                            T1.order_date,
                            SUM(CAST(T2.Quantity AS INT) * CAST(T2.Price AS DECIMAL(5, 2))) AS Total_Amount 
                        FROM dbo.[Order] T1
                        JOIN dbo.Product T2 ON T1.Order_id = T2.Order_id
                        GROUP BY T1.Order_id, T1.Employee_id, T1.order_date
                        ORDER BY T1.order_date DESC";

                    SqlDataAdapter orderAdapter = new SqlDataAdapter(orderQuery, connection);
                    DataTable ordersTable = new DataTable();
                    orderAdapter.Fill(ordersTable);

                    // CRITICAL: Assuming your Order Management DataGridView is named 'dgvOrderManagement'
                    // If this name is wrong, you will get an error. Check your designer.
                    dgvOrderManagement.DataSource = ordersTable;

                    // Format the Total Amount column as currency
                    dgvOrderManagement.Columns["Total_Amount"].DefaultCellStyle.Format = "C2";

                    dgvOrderManagement.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                    // --- 2. Calculate Metrics (Orders Today & Total Orders/Customers) ---

                    // a) Calculate Total Orders Today
                    string todayOrderQuery = @"
                        SELECT COUNT(Order_id) 
                        FROM dbo.[Order] 
                        WHERE CAST(order_date AS DATE) = CAST(GETDATE() AS DATE)";

                    using (SqlCommand todayOrderCmd = new SqlCommand(todayOrderQuery, connection))
                    {
                        object result = todayOrderCmd.ExecuteScalar();
                        // label7 for "Orders Today"
                        label7.Text = result?.ToString() ?? "0";
                    }

                    // b) Calculate Total Orders (Used for Total Customers box)
                    string totalOrderQuery = "SELECT COUNT(Order_id) FROM dbo.[Order]";

                    using (SqlCommand totalOrderCmd = new SqlCommand(totalOrderQuery, connection))
                    {
                        object result = totalOrderCmd.ExecuteScalar();
                        // label5 for "Total Customers" (currently counting all orders)
                        label5.Text = result?.ToString() ?? "0";
                    }

                    // c) Outstanding (Placeholder)
                    // If your 'Outstanding' label is, for example, label9, uncomment and set its text.
                    // label9.Text = "0"; 

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading sales data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // -----------------------------------------------------------------
        // EXISTING CODE
        // -----------------------------------------------------------------
        private void Exx_Click(object sender, EventArgs e)
        {
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