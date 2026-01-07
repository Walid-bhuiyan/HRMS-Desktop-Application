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
    public partial class EmployeeOperation : Form
    {
        public EmployeeOperation()
        {
            InitializeComponent();
        }

        private void EmployeeOperation_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HRManagerDashboard hrdb = new HRManagerDashboard();
            hrdb.Show();
            this.Hide();
        }
    }
}
