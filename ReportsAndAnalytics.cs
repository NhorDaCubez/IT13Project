using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProj
{
    public partial class ReportsAndAnalytics : Form
    {
        public ReportsAndAnalytics()
        {
            InitializeComponent();
        }

        private void InvExit_Click(object sender, EventArgs e)
        {
            Mainform ExitReportAndAnalytics = new Mainform();
            ExitReportAndAnalytics.Show();
            this.Hide();
        }
    }
}
