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
    public partial class HRManagerDashboard : Form
    {
        int hrId;
        public HRManagerDashboard()
        {
            InitializeComponent();
            hrId = 0;
        }

        public HRManagerDashboard(int id)
        {
            InitializeComponent();
            hrId = id;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginframe login = new loginframe();   
            login.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            HR_EmployeeManagement empForm = new HR_EmployeeManagement();
            empForm.Show();
            this.Hide();

        }

        private void btnDashboardSB_Click(object sender, EventArgs e)
        {

        }
    }
}
