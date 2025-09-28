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
    public partial class SystemSettings : Form
    {
        public SystemSettings()
        {
            InitializeComponent();

        }

        private void ExitSS(object sender, EventArgs e)
        {
            Mainform SSexit = new Mainform();
            SSexit.Show();
            this.Hide();
        }

        private void SystemSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
