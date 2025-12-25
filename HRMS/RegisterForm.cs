using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        private string securityQuestion, securityAnswer, department, jobTitle, employmentType;

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            rtbAddress.Clear();
            txtSecurityQuestion.Clear();
            txtSecurityAnswer.Clear();
            txtSalary.Clear();

            cmbDepartment.SelectedIndex = -1;
            cmbJobTitle.SelectedIndex = -1;
            cmbEmploymentType.SelectedIndex = -1;

            rbMale.Checked = false;
            rbFemale.Checked = false;

            dtpDOB.Value = DateTime.Today;
            dtpJoiningDate.Value = DateTime.Today;
        }

        private decimal salary;

        SqlConnection con = new SqlConnection(
            @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True"
        );

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            fullName = txtFullName.Text.Trim();
            email = txtEmail.Text.Trim();
            phone = txtPhone.Text.Trim();
            address = rtbAddress.Text.Trim();
            securityQuestion = txtSecurityQuestion.Text.Trim();
            securityAnswer = txtSecurityAnswer.Text.Trim();
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

            if (securityQuestion == "")
            {
                MessageBox.Show("Please enter security question.");
                return;
            }

            if (securityAnswer == "")
            {
                MessageBox.Show("Please enter security answer.");
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

            if (employmentType == "")
            {
                MessageBox.Show("Please select employment type.");
                return;
            }

            if (dtpJoiningDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Joining date cannot be in the future.");
                return;
            }

            if (!decimal.TryParse(txtSalary.Text, out salary))
            {
                MessageBox.Show("Please enter a valid numeric salary.");
                return;
            }

            try
            {
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO dbo.Employees_Info
                    (FullName, Email, Gender, DOB, Phone, Address, Department,
                     JobTitle, EmploymentType, JoinDate, Salary, SecurityQuestion, SecurityAnswer)
                    VALUES
                    (@FullName, @Email, @Gender, @DOB, @Phone, @Address, @Department,
                     @JobTitle, @EmploymentType, @JoinDate, @Salary, @SecurityQuestion, @SecurityAnswer)",
                    con
                );

                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Department", department);
                cmd.Parameters.AddWithValue("@JobTitle", jobTitle);
                cmd.Parameters.AddWithValue("@EmploymentType", employmentType);
                cmd.Parameters.AddWithValue("@JoinDate", dtpJoiningDate.Value);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.Parameters.AddWithValue("@SecurityQuestion", securityQuestion);
                cmd.Parameters.AddWithValue("@SecurityAnswer", securityAnswer);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Employee added successfully!");

                ClearForm();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            rtbAddress.Clear();
            txtSecurityQuestion.Clear();
            txtSecurityAnswer.Clear();
            txtSalary.Clear();

            cmbDepartment.SelectedIndex = -1;
            cmbJobTitle.SelectedIndex = -1;
            cmbEmploymentType.SelectedIndex = -1;

            rbMale.Checked = false;
            rbFemale.Checked = false;

            dtpDOB.Value = DateTime.Today;
            dtpJoiningDate.Value = DateTime.Today;
        }
    }
}
