using System;
using System.Data;
using Microsoft.Data.SqlClient; // Required for database connection
using System.Windows.Forms;

namespace FinalProj
{
    public partial class Form1 : Form
    {
        // Using the most reliable connection string format
        private const string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=FinalProjectDB;Integrated Security=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            // The code reads from txtEmployeeId, which is the box you should label "Employee Number"
            if (!int.TryParse(Username.Text, out int employeeId))
            {
                MessageBox.Show("Please enter a valid Employee Number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Authenticate and retrieve the user's role (Ranking)
            string userRanking = AuthenticateUserAndGetRole(employeeId);

            if (userRanking != null)
            {
                // Login successful.
                MessageBox.Show($"Login Successful. Role: {userRanking}", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 3. Open Mainform and pass the authenticated ID and Role
                // This requires the updated Mainform constructor: public Mainform(int employeeId, string userRanking)
                Mainform Main = new Mainform(employeeId, userRanking);
                Main.Show();
                this.Hide();
            }
            else
            {
                // Login failed or Database Error (message shown inside AuthenticateUserAndGetRole)
                // Only show a generic failure message here if the database didn't display an error.
                if (string.IsNullOrEmpty(Username.Text))
                {
                    MessageBox.Show("Login failed. Employee Number not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // -----------------------------------------------------------------
        // NEW METHOD: Checks database for employee and returns their role
        // -----------------------------------------------------------------
        private string AuthenticateUserAndGetRole(int employeeId)
        {
            // Query selects the Ranking column you added to the Employee table
            string query = "SELECT Ranking FROM Employee WHERE Employee_id = @EmployeeId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            return result.ToString(); // Returns the ranking (e.g., "Manager", "Staff")
                        }
                        return null; // Employee not found
                    }
                }
                catch (Exception ex)
                {
                    // This is essential for debugging the connection issues (like error 40 or certificate)
                    MessageBox.Show("Database Connection Error during login: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            // You can leave this empty.
        }
    }
}