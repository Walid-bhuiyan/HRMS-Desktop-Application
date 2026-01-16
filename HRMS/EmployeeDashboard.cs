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
    public partial class EmployeeDashboard : Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginframe login = new loginframe();
            login.Show();
            this.Hide();

        }

        private void btnupdateprofile_Click(object sender, EventArgs e)
        {
            UpdateProfile up = new UpdateProfile();
            up.Show();
            this.Hide();
        }

        private void btnsalarydetails_Click(object sender, EventArgs e)
        {
            SalaryDetails SD=new SalaryDetails();
            SD.Show();
            this.Hide();
        }

        private void btnProfileDetails_Click(object sender, EventArgs e)
        {
            Profile pf= new Profile();
            pf.Show();
            this.Hide();
        }

        private void btnchangepass_Click(object sender, EventArgs e)
        {
            ChangePassword cp=new ChangePassword();
            cp.Show();
            this.Hide();
        }

        private void btndeptjobrule_Click(object sender, EventArgs e)
        {
            DepartmentAndJobRule djr=new DepartmentAndJobRule();
            djr.Show();
            this.Hide();
        }

        private void btnattendancerecord_Click(object sender, EventArgs e)
        {
            AttendanceRecord ar= new AttendanceRecord();
            ar.Show();
            this.Hide();
        }

        private void btnapplyforleave_Click(object sender, EventArgs e)
        {
            ApplyforLeave al = new ApplyforLeave();
            al.Show();
            this.Hide();
        }

        private void btnleavestatus_Click(object sender, EventArgs e)
        {
            LeaveStatus ls=new LeaveStatus(); 
            ls.Show();
            this.Hide();
        }

        private void btnpayslip_Click(object sender, EventArgs e)
        {
            Payslip PS=new Payslip();
            PS.Show();
            this.Hide();
        }

        private void btnnotice_Click(object sender, EventArgs e)
        {
            Notice notice=new Notice();
            notice.Show();
            this.Hide();
        }

        private void btncomplainbox_Click(object sender, EventArgs e)
        {
            ComplainBox CB=new ComplainBox();
            CB.Show();
            this.Hide();
        }
    }
}
