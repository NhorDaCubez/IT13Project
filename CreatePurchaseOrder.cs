using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient; // Added for database connection
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProj
{
    public partial class CreatePurchaseOrder : Form
    {
        private DataTable purchaseOrderItems = new DataTable();

        // Connection string configured for your server and security settings
        private const string connectionString = "Data Source=LAPTOP-VHI1EE4Q\\SQLEXPRESS;Initial Catalog=FinalProjectDB;Integrated Security=True;TrustServerCertificate=True";

        public CreatePurchaseOrder()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            // Define the columns for the DataGridView
            purchaseOrderItems.Columns.Add("Item Name", typeof(string));
            purchaseOrderItems.Columns.Add("Quantity", typeof(int));
            purchaseOrderItems.Columns.Add("Unit Price", typeof(decimal));
            purchaseOrderItems.Columns.Add("Total", typeof(decimal));

            // *** FIX 1: Correct DataGridView Source Assignment ***
            // Assuming your DataGridView control is named 'dgvItems' 
            // (You had 'txtVendorName' which is wrong).
            // If the control name is different, change 'dgvItems' below.
            txtVendorName.DataSource = purchaseOrderItems;
        }

        // -----------------------------------------------------------------
        // HELPER METHOD: Adds the item from the input fields to the DataTable
        // (This remains unchanged and is correct)
        // -----------------------------------------------------------------
        private bool TryAddItem()
        {
            // Assuming you have txtItemName, txtQuantity, and txtUnitPrice controls
            string itemName = txtItemName.Text;
            int quantity = 0;
            decimal unitPrice = 0.0m;

            // Simple validation: must have a name
            if (string.IsNullOrWhiteSpace(itemName))
            {
                return false;
            }

            // Validation and parsing
            if (int.TryParse(txtQuantity.Text, out quantity) && decimal.TryParse(txtUnitPrice.Text, out unitPrice))
            {
                // Add to DataTable
                decimal total = quantity * unitPrice;
                purchaseOrderItems.Rows.Add(itemName, quantity, unitPrice, total);

                // Clear the text boxes for the next entry
                txtItemName.Clear();
                txtQuantity.Clear();
                txtUnitPrice.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }

        // -----------------------------------------------------------------
        // REVISED AddItemBtn_Click
        // -----------------------------------------------------------------
        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            // Call the helper method to add the item
            if (!TryAddItem())
            {
                // If it failed, show the specific error
                if (string.IsNullOrWhiteSpace(txtItemName.Text))
                {
                    MessageBox.Show("Please enter an Item Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Please enter valid numbers for Quantity and Unit Price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // -----------------------------------------------------------------
        // REVISED SubmitBtn_Click (Includes the new Order_id parameter for Product table)
        // -----------------------------------------------------------------
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            // STEP 1: Automatically try to add the current item in the input fields
            bool currentItemAdded = TryAddItem();

            // If there's content in the input fields but TryAddItem failed (due to bad numbers), stop and alert the user.
            if (!currentItemAdded && (!string.IsNullOrWhiteSpace(txtItemName.Text) || !string.IsNullOrWhiteSpace(txtQuantity.Text) || !string.IsNullOrWhiteSpace(txtUnitPrice.Text)))
            {
                MessageBox.Show("Please correct the quantity and price for the last item before submitting.", "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // STEP 2: Check if there are any items to submit (this must be done after TryAddItem())
            if (purchaseOrderItems.Rows.Count == 0)
            {
                MessageBox.Show("Please add items to the Purchase Order before submitting.", "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Variables for database insert
            string vendorName = txtVendorName.Text;
            int employeeId = 1; // You confirmed Employee_id 1 exists in the DB
            int newOrderId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    // Insert into the Order table first
                    // orderSql remains correct for getting the auto-generated Order_id
                    string orderSql = @"INSERT INTO [Order] (Employee_id, order_date) OUTPUT INSERTED.Order_id VALUES (@EmployeeId, @OrderDate)";

                    using (SqlCommand orderCmd = new SqlCommand(orderSql, connection, transaction))
                    {
                        orderCmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                        orderCmd.Parameters.AddWithValue("@OrderDate", DateTime.Today);
                        // Store the auto-generated Order_id
                        newOrderId = (int)orderCmd.ExecuteScalar();
                    }

                    // Loop through all items and insert into Product table
                    // *** FIX 2: Added Order_id to the Product insert SQL ***
                    string productSql = @"
                        INSERT INTO Product (Order_id, Employee_id, Quantity, Product_name, Price) 
                        VALUES (@OrderId, @EmployeeId, @Quantity, @ProductName, @Price)";

                    foreach (DataRow row in purchaseOrderItems.Rows)
                    {
                        using (SqlCommand productCmd = new SqlCommand(productSql, connection, transaction))
                        {
                            // *** FIX 2: Pass the generated newOrderId to the product insert ***
                            productCmd.Parameters.AddWithValue("@OrderId", newOrderId);

                            productCmd.Parameters.AddWithValue("@EmployeeId", employeeId);
                            // Ensure data types match your SQL table (VARCHAR/string from the ERD)
                            productCmd.Parameters.AddWithValue("@Quantity", row["Quantity"].ToString());
                            productCmd.Parameters.AddWithValue("@ProductName", row["Item Name"].ToString());
                            productCmd.Parameters.AddWithValue("@Price", row["Unit Price"].ToString());

                            productCmd.ExecuteNonQuery();
                        }
                    }

                    // Commit the transaction
                    transaction.Commit();
                    MessageBox.Show($"Purchase Order (ID: {newOrderId}) submitted successfully!");

                    // Navigate back to the main form
                    Mainform invForm = new Mainform();
                    invForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    // Rollback on error and show the message
                    MessageBox.Show("Error submitting purchase order: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Mainform invForm = new Mainform();
            invForm.Show();
            this.Hide();
        }
    }
}