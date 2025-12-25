using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HRMS
{
    public partial class RegisterForm : Form
    {
        private string fullName, email, dob, gender, phone, address;

        private void lblDOB_Click(object sender, EventArgs e)
        {

        }

        private string employeeId, department, jobTitle, employmentType;
        private decimal salary;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void tblPersonalInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            fullName = txtFullName.Text;
            email = txtEmail.Text;
            phone = txtPhone.Text;
            address = rtbAddress.Text;

            employeeId = txtEmpId.Text;
            department = cmbDepartment.Text;
            jobTitle = cmbJobTitle.Text;
            employmentType = cmbEmploymentType.Text;

            dob = dtpDOB.Text;

            if (rbMale.Checked)
                gender = "Male";
            else if (rbFemale.Checked)
                gender = "Female";
            else
                gender = "";

            if (fullName == "")
            {
                MessageBox.Show("Please enter full name.");
                return;
            }

            if (gender == "")
            {
                MessageBox.Show("Please select gender.");
                return;
            }

            if (dtpDOB.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Please enter a valid Date of Birth.");
                return;
            }

            if (email == "")
            {
                MessageBox.Show("Please enter email.");
                return;
            }

            if (phone == "")
            {
                MessageBox.Show("Please enter phone number.");
                return;
            }

            if (address == "")
            {
                MessageBox.Show("Please enter address.");
                return;
            }

            if (employeeId == "")
            {
                MessageBox.Show("Please enter Employee ID.");
                return;
            }

            if (department == "")
            {
                MessageBox.Show("Please select department.");
                return;
            }
            if (jobTitle == "")
            {
                MessageBox.Show("Please select job title.");
                return;
            }

            if (dtpJoiningDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Joining date cannot be in the future.");
                return;
            }
            if (employmentType == "")
            {
                MessageBox.Show("Please select employment type.");
                return;
            }

            if (txtSalary.Text == "")
            {
                MessageBox.Show("Please enter salary.");
                return;
            }


            MessageBox.Show(
                "Name: " + fullName + "\nGender: " + gender +"\nDOB: " + dtpDOB.Text +"\nEmail: " + email +
                "\nPhone: " + phone +"\nAddress: " + address +"\nEmployee ID: " + employeeId +
                "\nDepartment: " + department +"\nJob Title: " + jobTitle +"\nEmployment Type: " + employmentType +
                "\nJoining Date: " + dtpJoiningDate.Text +"\nSalary: " + salary

            );
        }
    }
}
