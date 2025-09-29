using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Linq; // Added for easy counting of low/in/out stock items

namespace FinalProj
{
    public partial class Inventory : Form
    {
        // Connection String
        private const string connectionString = "Data Source=LAPTOP-VHI1EE4Q\\SQLEXPRESS;Initial Catalog=FinalProjectDB;Integrated Security=True;TrustServerCertificate=True";

        public Inventory()
        {
            InitializeComponent();
            this.Load += new EventHandler(Inventory_Load);
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            LoadInventoryData();
        }

        private void LoadInventoryData()
        {
            // Query aggregates stock from the Product table
            string query = @"
                SELECT 
                    MIN(T1.Employee_id) AS Employee_ID, 
                    T1.Product_name AS Product,
                    SUM(CAST(T1.Quantity AS INT)) AS Quantity, -- Calculate total stock
                    CAST(AVG(CAST(T1.Price AS DECIMAL(5, 2))) AS DECIMAL(5, 2)) AS Price -- Calculate average price
                FROM Product T1
                GROUP BY T1.Product_name
                HAVING SUM(CAST(T1.Quantity AS INT)) >= 0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable inventoryTable = new DataTable();
                    adapter.Fill(inventoryTable);

                    // --- 1. CALCULATE STATUS AND INVENTORY METRICS ---
                    inventoryTable.Columns.Add("Status", typeof(string));
                    int lowStockThreshold = 10;
                    int outOfStockThreshold = 1;

                    int lowStockCount = 0;
                    int inStockCount = 0;
                    int outOfStockCount = 0;

                    foreach (DataRow row in inventoryTable.Rows)
                    {
                        int quantity = (int)row["Quantity"];
                        string status = "";

                        if (quantity < outOfStockThreshold)
                        {
                            status = "Out of Stock";
                            outOfStockCount++;
                        }
                        else if (quantity <= lowStockThreshold)
                        {
                            status = "Low Stock";
                            lowStockCount++;
                        }
                        else
                        {
                            status = "In Stock";
                            inStockCount++;
                        }
                        row["Status"] = status;
                    }

                    // --- 2. UPDATE LABELS (Low Stock=label4, Stock In=label5, Stock Out=label10) ---
                    // **CRITICAL: Ensure your designer labels are named label4, label5, and label10.**
                    label4.Text = lowStockCount.ToString(); // Low Stock
                    label5.Text = inStockCount.ToString();  // Stock In
                    label10.Text = outOfStockCount.ToString(); // Stock Out

                    // --- 3. ADD LOCATION (UI column) ---
                    inventoryTable.Columns.Add("Location", typeof(string), "'Main Warehouse'");

                    // --- 4. BIND DATA ---
                    // This assumes the DataGridView is named dgvInventory.
                    dgvInventory.DataSource = inventoryTable;

                    // --- 5. FORMAT HEADERS (To match your UI design columns) ---
                    dgvInventory.Columns["Employee_ID"].HeaderText = "Employee";
                    dgvInventory.Columns["Product"].HeaderText = "Product";
                    dgvInventory.Columns["Quantity"].HeaderText = "Stock Level";
                    dgvInventory.Columns["Price"].HeaderText = "Pricing";
                    dgvInventory.Columns["Location"].HeaderText = "Location";
                    dgvInventory.Columns["Status"].HeaderText = "Status";

                    dgvInventory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                }
                catch (Exception ex)
                {
                    // This error message is essential for debugging
                    MessageBox.Show("Error loading inventory data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InvExit_Click(object sender, EventArgs e)
        {
            Mainform ExitInv = new Mainform();
            ExitInv.Show();
            this.Hide();
        }

        private void CreatePurchaseOrderBtn_Click(object sender, EventArgs e)
        {
            // *** CRITICAL: You must pass the Employee ID to CreatePurchaseOrder here ***
            CreatePurchaseOrder Form = new CreatePurchaseOrder();
            Form.Show();
            this.Hide();
        }
    }
}