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
    public partial class SupplyChainAndLogistics : Form
    {
        public SupplyChainAndLogistics()
        {
            InitializeComponent();
        }

        private void ExitSCnL(object sender, EventArgs e)
        {
            Mainform SCnlExit = new Mainform();
            SCnlExit.Show();
            this.Hide();
        }

        private void DeliverScheduling(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
