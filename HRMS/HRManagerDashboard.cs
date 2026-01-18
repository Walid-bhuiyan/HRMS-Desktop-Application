using System;
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

        // ---------------- LOGOUT ----------------

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginframe login = new loginframe();
            login.Show();
            this.Hide();
        }

        // ---------------- PROFILE ----------------

        private void btnProfile_Click(object sender, EventArgs e)
        {
            // Open HR profile and pass HR id
            HRProfile p = new HRProfile(hrId);
            p.Show();
        }

        // ---------------- EMPLOYEES ----------------

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            HR_EmployeeManagement empForm = new HR_EmployeeManagement();
            empForm.Show();
            this.Hide();
        }

        // ❌ REMOVE duplicate empty handler if designer created it
        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            btnProfile_Click(sender, e);
        }

        private void btnDashboardSB_Click(object sender, EventArgs e)
        {

        }
    }
}
