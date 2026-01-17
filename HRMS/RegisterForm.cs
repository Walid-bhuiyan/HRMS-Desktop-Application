using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    public partial class RegisterForm : Form
    {
        // Employee info
        private string fullName, email, gender, phone, address;
        private string securityQuestion, securityAnswer, department, jobTitle, employmentType;
        private string password;
        private decimal salary;

        // Connection string from App.config
        private readonly string cs =
            ConfigurationManager.ConnectionStrings["HRMS_DB"].ConnectionString;

        public RegisterForm()
        {
            InitializeComponent();
        }

        // -------------------- NAVIGATION --------------------

        private void btnBack_Click(object sender, EventArgs e)
        {
            HR_EmployeeManagement w = new HR_EmployeeManagement();
            w.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        // -------------------- PASSWORD HASH --------------------

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        // -------------------- SUBMIT BUTTON --------------------

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

            if (rbMale.Checked)
                gender = "Male";
            else if (rbFemale.Checked)
                gender = "Female";
            else
                gender = "";

            // -------- VALIDATION --------

            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Please enter full name."); return;
            }

            if (gender == "")
            {
                MessageBox.Show("Please select gender."); return;
            }

            if (dtpDOB.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Please enter a valid Date of Birth."); return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter email."); return;
            }

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Please enter phone number."); return;
            }

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter address."); return;
            }

            if (string.IsNullOrEmpty(securityQuestion))
            {
                MessageBox.Show("Please enter security question."); return;
            }

            if (string.IsNullOrEmpty(securityAnswer))
            {
                MessageBox.Show("Please enter security answer."); return;
            }

            if (string.IsNullOrEmpty(department))
            {
                MessageBox.Show("Please select department."); return;
            }

            if (string.IsNullOrEmpty(jobTitle))
            {
                MessageBox.Show("Please select job title."); return;
            }

            if (string.IsNullOrEmpty(employmentType))
            {
                MessageBox.Show("Please select employment type."); return;
            }

            if (dtpJoiningDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Joining date cannot be in the future."); return;
            }

            if (!decimal.TryParse(txtSalary.Text, out salary))
            {
                MessageBox.Show("Please enter a valid numeric salary."); return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter password."); return;
            }

            password = HashPassword(txtPassword.Text.Trim());

            // -------- DATABASE --------
            InsertIntoEmployee();
        }

        // -------------------- INSERT EMPLOYEE --------------------

        private void InsertIntoEmployee()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = @"
                        INSERT INTO Employees_Info
                        (FullName, Email, Gender, DOB, Phone, Address, Department,
                         JobTitle, EmploymentType, JoinDate, Salary)
                        VALUES
                        (@FullName, @Email, @Gender, @DOB, @Phone, @Address, @Department,
                         @JobTitle, @EmploymentType, @JoinDate, @Salary);
                        SELECT SCOPE_IDENTITY();";

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

                        con.Open();
                        int empId = Convert.ToInt32(cmd.ExecuteScalar());

                        InsertIntoUsers(empId, "Employee");
                    }
                }

                MessageBox.Show("Employee added successfully & user account created!");
                ClearForm();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("This email already exists!");
                }
                else
                {
                    MessageBox.Show("Database error: " + sqlEx.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // -------------------- INSERT USERS --------------------

        private void InsertIntoUsers(int refId, string role)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"
                    INSERT INTO Users (RefId, Role, Email, Password, SecurityAns)
                    VALUES (@RefId, @Role, @Email, @Password, @SecurityAns)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@RefId", refId);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@SecurityAns", securityAnswer);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // -------------------- CLEAR FORM --------------------

        private void ClearForm()
        {
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            rtbAddress.Clear();
            txtSecurityQuestion.Clear();
            txtSecurityAnswer.Clear();
            txtSalary.Clear();
            txtPassword.Clear();

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
