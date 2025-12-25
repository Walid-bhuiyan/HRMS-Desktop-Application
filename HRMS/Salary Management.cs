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
    public partial class salaryManagement : Form
    {
        public salaryManagement()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accountantDashboard ad = new accountantDashboard();
            ad.Show();
            this.Hide();
        }
    }
}
