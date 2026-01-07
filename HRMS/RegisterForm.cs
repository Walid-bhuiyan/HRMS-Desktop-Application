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
using System.Configuration;

namespace HRMS
{
    public partial class RegisterForm : Form
    {
        private string fullName, email, dob, gender, phone, address;
        private string securityQuestion, securityAnswer, department, jobTitle, employmentType;
        private decimal salary;

        //  Connection string from App.config
        private readonly string cs =
            ConfigurationManager.ConnectionStrings["HRMS_DB"].ConnectionString;



        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
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

            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = @"
                        INSERT INTO dbo.Employees_Info
                        (FullName, Email, Gender, DOB, Phone, Address, Department,
                         JobTitle, EmploymentType, JoinDate, Salary, SecurityQuestion, SecurityAnswer)
                        VALUES
                        (@FullName, @Email, @Gender, @DOB, @Phone, @Address, @Department,
                         @JobTitle, @EmploymentType, @JoinDate, @Salary, @SecurityQuestion, @SecurityAnswer)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
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
                    }
                }

                MessageBox.Show("Employee added successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
