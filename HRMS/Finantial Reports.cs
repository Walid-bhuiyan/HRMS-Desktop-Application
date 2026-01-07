using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class finantialReports : Form
    {
        public finantialReports()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            AccountantDashboard ad = new AccountantDashboard();
            ad.Show();
            this.Hide();
        }
    }
}
