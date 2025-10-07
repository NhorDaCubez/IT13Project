using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProj
{
    public partial class HumanResources : Form
    {
        // Connection String is assumed correct.
        private const string connectionString = "Data Source=LAPTOP-VHI1EE4Q\\SQLEXPRESS;Initial Catalog=FinalProjectDB;Integrated Security=True;TrustServerCertificate=True";

        public HumanResources()
        {
            InitializeComponent();
            this.Load += new EventHandler(HumanResources_Load);
        }

        private void HumanResources_Load(object sender, EventArgs e)
        {
            LoadHrData();
        }

        private void LoadHrData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // --- 1. Calculate Metrics ---

                    // a) Total Employees
                    string totalEmpQuery = "SELECT COUNT(Employee_id) FROM dbo.Employee";
                    using (SqlCommand cmd = new SqlCommand(totalEmpQuery, connection))
                    {
                        lblTotalEmployees.Text = cmd.ExecuteScalar()?.ToString() ?? "0";
                    }

                    // b) Present Today (Set to 0 to avoid Invalid Column errors from dbo.Attendance)
                    // You still need to confirm the correct column names in dbo.Attendance (e.g., 'Attendance_Date', 'Status').
                    lblPresentToday.Text = "0";

                    // c) Monthly Payroll - FIXING Invalid Column Name. Now correctly using 'Salary'
                    string payrollQuery = "SELECT ISNULL(SUM(Salary), 0) FROM dbo.Salary";

                    using (SqlCommand cmd = new SqlCommand(payrollQuery, connection))
                    {
                        // Note: The Salary column is decimal(9, 2), so casting to decimal is safe.
                        decimal payroll = (decimal)cmd.ExecuteScalar();
                        lblMonthlyPayroll.Text = payroll.ToString("C2"); // Formats as currency
                    }

                    // d) AVG Performance (Placeholder)
                    lblAvgPerformance.Text = "N/A";

                    // --- 2. Load Employee Attendance Tracking Grid ---

                    // Using SELECT * to bypass 'Invalid column name' errors for Attendance columns
                    string attendanceQuery = "SELECT * FROM dbo.Attendance";

                    SqlDataAdapter attendanceAdapter = new SqlDataAdapter(attendanceQuery, connection);
                    DataTable attendanceTable = new DataTable();
                    attendanceAdapter.Fill(attendanceTable);

                    // Assuming you have fixed the designer (Panel replaced with DataGridView named 'dgvAttendance')
                    dgvAttendance.DataSource = attendanceTable;
                    dgvAttendance.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                catch (Exception ex)
                {
                    // Displays connection errors 
                    MessageBox.Show("Error loading HR data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- Rest of the form code (unchanged) ---
        private void HrExit(object sender, EventArgs e)
        {
            Mainform ExitHR = new Mainform();
            ExitHR.Show();
            this.Hide();
        }

        private void InitializeHorizontalScroll(object sender, ScrollEventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeManagement OpenEM = new EmployeeManagement();
            OpenEM.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PayrollTracking OpenPT = new PayrollTracking();
            OpenPT.Show();
            this.Hide();
        }
    }
}