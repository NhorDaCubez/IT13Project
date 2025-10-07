using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProj
{
    public partial class Form1 : Form
    {
        // Using the server name from your screenshots for reliability
        private const string connectionString = "Data Source=LAPTOP-VHI1EE4Q\\SQLEXPRESS;Initial Catalog=FinalProjectDB;Integrated Security=True;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            // 1. Validate Employee ID input
            if (!int.TryParse(Username.Text, out int employeeId))
            {
                MessageBox.Show("Please enter a valid Employee ID (number).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string inputPassword = Password.Text.Trim();

            // 2. Authenticate and retrieve user data
            string userRanking = AuthenticateUserAndGetRole(employeeId, inputPassword);

            if (userRanking != null)
            {
                // Login successful.
                MessageBox.Show($"Login Successful. Role: {userRanking}", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 3. Open Mainform and pass the authenticated ID and Role
                Mainform Main = new Mainform(employeeId, userRanking);
                Main.Show();
                this.Hide();
            }
            else
            {
                // General failure message for invalid ID or password
                MessageBox.Show("Login failed. Invalid Employee ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -----------------------------------------------------------------
        // UPDATED METHOD: Authenticates user based on ID and checks password against full name for Managers.
        // -----------------------------------------------------------------
        private string AuthenticateUserAndGetRole(int employeeId, string inputPassword)
        {
            // Query selects the required authentication details and role
            string query = "SELECT First_name, Last_name, Ranking FROM Employee WHERE Employee_id = @EmployeeId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeId", employeeId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["First_name"].ToString().Trim();
                                string lastName = reader["Last_name"].ToString().Trim();
                                string ranking = reader["Ranking"].ToString().Trim();

                                // Calculate the required password (Full Name)
                                string requiredPassword = $"{firstName} {lastName}";

                                // Authentication Logic:
                                if (ranking == "Manager")
                                {
                                    // Manager: Password must match the Full Name
                                    if (inputPassword == requiredPassword)
                                    {
                                        return ranking;
                                    }
                                }
                                else // Staff or any other role
                                {
                                    // Staff/Other: Only needs a non-empty password (or you can remove this check)
                                    if (!string.IsNullOrEmpty(inputPassword))
                                    {
                                        return ranking;
                                    }
                                }
                            }
                            // If reader.Read() is false, the Employee ID was not found.
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
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