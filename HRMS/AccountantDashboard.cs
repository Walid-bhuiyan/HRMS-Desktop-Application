using HRMS.Resources;
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
    public partial class AccountantDashboard : Form
    {

        string connectionString = @"Data Source=localhost;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;";
        public AccountantDashboard()
        {
            InitializeComponent();
        }

        private void AccountantDashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            auditLogs al = new auditLogs();
            al.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            finantialReports fr = new finantialReports();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginframe lf = new loginframe();
            lf.Show();
            this.Hide();
        }

        private void btnsalary_Click(object sender, EventArgs e)
        {
            salaryManagement sm = new salaryManagement();
            sm.Show();
            this.Hide();
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            profile p = new profile();
            p.Show();
            this.Hide();
        }

        private void btnpayroll_Click(object sender, EventArgs e)
        {
            payrollProcessing pp = new payrollProcessing();
            pp.Show();
            this.Hide();
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            paymentManagement pm = new paymentManagement();
            pm.Show();
            this.Hide();
        }

        private void btnpayslip_Click(object sender, EventArgs e)
        {
            payslipGeneration pg = new payslipGeneration();
            pg.Show();
            this.Hide();
        }

        private void btnattendance_Click(object sender, EventArgs e)
        {
            attendance a = new attendance();
            a.Show();
            this.Hide();
        }

        private void btnchangepassword_Click(object sender, EventArgs e)
        {
            changePassword cp = new changePassword();
            cp.Show();
            this.Hide();
        }

        private void btndeduction_Click(object sender, EventArgs e)
        {
            deductionManagement dm = new deductionManagement();
            dm.Show();
            this.Hide();
        }

        private void lblemployees_Click(object sender, EventArgs e)
        {

        }

        private void lblemployeesnumber_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblmonthlypayrolltk_Click(object sender, EventArgs e)
        {

        }
    }
}
