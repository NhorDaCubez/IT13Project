using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProj
{
    public partial class Inventory : Form
    {
        // *** CRITICAL: If LAPTOP-VHI1EE4Q fails, try the local instance shortcut: '.\SQLEXPRESS' ***
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

                    // --- CALCULATE STATUS ---
                    inventoryTable.Columns.Add("Status", typeof(string));
                    int lowStockThreshold = 10;
                    int outOfStockThreshold = 1;

                    foreach (DataRow row in inventoryTable.Rows)
                    {
                        int quantity = (int)row["Quantity"];

                        if (quantity < outOfStockThreshold)
                            row["Status"] = "Out of Stock";
                        else if (quantity <= lowStockThreshold)
                            row["Status"] = "Low Stock";
                        else
                            row["Status"] = "In Stock";
                    }

                    // --- ADD LOCATION (UI column) ---
                    inventoryTable.Columns.Add("Location", typeof(string), "'Main Warehouse'");

                    // --- BIND DATA ---
                    // This assumes the DataGridView is named dgvInventory.
                    dgvInventory.DataSource = inventoryTable;

                    // --- FORMAT HEADERS (To match your UI design columns) ---
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
            CreatePurchaseOrder Form = new CreatePurchaseOrder();
            Form.Show();
            this.Hide();
        }
    }
}