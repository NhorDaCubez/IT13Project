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
    public partial class PayrollTracking : Form
    {
        public PayrollTracking()
        {
            InitializeComponent();
        }

        private void PayrollExitBtn_Click(object sender, EventArgs e)
        {
            HumanResources ExitPayroll = new HumanResources();
            ExitPayroll.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
