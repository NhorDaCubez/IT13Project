using System.Windows.Forms;
using System;

namespace FinalProj
{
    public partial class Mainform : Form
    {
        // --------------------------------------------------------
        // NEW: Variables to store the logged-in user's data
        // --------------------------------------------------------
        private int CurrentEmployeeId;
        private string CurrentUserRanking;

        // --------------------------------------------------------
        // NEW: Constructor that accepts the Employee ID and Ranking
        // The Login form (Form1) will call this one.
        // --------------------------------------------------------
        public Mainform(int employeeId, string userRanking)
        {
            InitializeComponent();
            CurrentEmployeeId = employeeId;
            CurrentUserRanking = userRanking;

            // Immediately apply the permissions when the form loads
            ApplyPermissions();

            // Optional: Show the logged-in user's role/ID on the form somewhere
            // Example: lblWelcomeUser.Text = $"Welcome, {CurrentUserRanking}!";
        }

        // Keep the default parameterless constructor for navigation 
        // (e.g., if another form calls new Mainform())
        public Mainform()
        {
            InitializeComponent();
            // Since we don't know the rank here, permissions won't be applied, 
            // so only call this from forms where the user is already authenticated.
        }

        // --------------------------------------------------------
        // NEW METHOD: Controls which buttons/features are visible
        // --------------------------------------------------------
        private void ApplyPermissions()
        {
            // You can use these examples to hide buttons for non-managers.
            // You must use the actual NAME of the buttons on your form.

            if (CurrentUserRanking == "Manager")
            {
                // Managers see everything (default visibility is fine)
                // OpenSSBtn.Visible = true; // Example if SystemSettings is restricted
                // OpenReportsAndAnalytics.Visible = true; // Example if Reports is restricted
            }
            else // This covers 'Staff', 'Detailer', or any other roles
            {
                // Example 1: Only Managers see the Financial button
                // If your financial button control is named 'FinancialBtnControl', you would do:
                // FinancialBtnControl.Visible = false;

                // Example 2: Only Managers can access System Settings
                // If your system settings button control is named 'OpenSSBtn', you would do:
                // OpenSSBtn.Visible = false; 

                // Example 3: Only Managers can access HR
                // HumanResourceBtn.Visible = false;
            }
        }

        // --------------------------------------------------------
        // EXISTING CODE (UNCHANGED)
        // --------------------------------------------------------

        // Consolidated function to handle opening a new form and hiding the current one.
        private void OpenNewForm<T>() where T : Form, new()
        {
            T newForm = new T();
            newForm.Show();
            this.Hide();
        }

        private void Logout(object sender, EventArgs e)
        {
            OpenNewForm<Form1>();
        }

        private void FinancialBtn(object sender, EventArgs e)
        {
            OpenNewForm<Financial>();
        }

        private void InventoryBtn(object sender, EventArgs e)
        {
            OpenNewForm<Inventory>();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            // If you need form loading logic, you can call ApplyPermissions() here too, 
            // but calling it in the constructor is usually enough.
        }

        private void SalesNCustomers(object sender, EventArgs e)
        {
            OpenNewForm<SalesAndCustomers>();
        }

        private void SupplyChainAndLogistics_Click(object sender, EventArgs e)
        {
            OpenNewForm<SupplyChainAndLogistics>();
        }

        private void HumanResourceBtn(object sender, EventArgs e)
        {
            OpenNewForm<HumanResources>();
        }

        private void OpenSSBtn(object sender, EventArgs e)
        {
            OpenNewForm<SystemSettings>();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // This is also empty, typically for drawing custom elements.
        }

        private void OpenReportsAndAnalytics(object sender, EventArgs e)
        {
            OpenNewForm<ReportsAndAnalytics>();
        }
    }
}