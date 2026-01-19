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
        // -------------------- FIELDS --------------------

        private string fullName, email, gender, phone, address;
        private string securityQuestion, securityAnswer, department, jobTitle, employmentType;
        private string password;
        private decimal salary;

        private readonly string cs =
            ConfigurationManager.ConnectionStrings["HRMS_DB"].ConnectionString;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e) { }

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

        // -------------------- SUBMIT --------------------

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

            if (rbMale.Checked) gender = "Male";
            else if (rbFemale.Checked) gender = "Female";
            else gender = "";

            // -------- VALIDATION --------

            if (string.IsNullOrEmpty(fullName)) { MessageBox.Show("Enter full name"); return; }
            if (gender == "") { MessageBox.Show("Select gender"); return; }
            if (dtpDOB.Value.Date >= DateTime.Today) { MessageBox.Show("Invalid DOB"); return; }
            if (string.IsNullOrEmpty(email)) { MessageBox.Show("Enter email"); return; }
            if (string.IsNullOrEmpty(phone)) { MessageBox.Show("Enter phone"); return; }
            if (string.IsNullOrEmpty(address)) { MessageBox.Show("Enter address"); return; }
            if (string.IsNullOrEmpty(securityQuestion)) { MessageBox.Show("Enter security question"); return; }
            if (string.IsNullOrEmpty(securityAnswer)) { MessageBox.Show("Enter security answer"); return; }
            if (string.IsNullOrEmpty(department)) { MessageBox.Show("Select department"); return; }
            if (string.IsNullOrEmpty(jobTitle)) { MessageBox.Show("Select job title"); return; }
            if (string.IsNullOrEmpty(employmentType)) { MessageBox.Show("Select employment type"); return; }
            if (dtpJoiningDate.Value.Date > DateTime.Today) { MessageBox.Show("Invalid joining date"); return; }
            if (!decimal.TryParse(txtSalary.Text, out salary)) { MessageBox.Show("Invalid salary"); return; }
            if (string.IsNullOrEmpty(txtPassword.Text)) { MessageBox.Show("Enter password"); return; }

            password = HashPassword(txtPassword.Text.Trim());

            InsertEmployeeWithRole();
        }

        // -------------------- MAIN INSERT LOGIC --------------------

        private void InsertEmployeeWithRole()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    // ✅ 1. INSERT INTO Employees_Info
                    string q1 = @"
                    INSERT INTO Employees_Info
                    (FullName, Email, Gender, DOB, Phone, Address, Department,
                     JobTitle, EmploymentType, JoinDate, Salary)
                    VALUES
                    (@FullName, @Email, @Gender, @DOB, @Phone, @Address, @Department,
                     @JobTitle, @EmploymentType, @JoinDate, @Salary);
                    SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd1 = new SqlCommand(q1, con, tran);
                    FillCommonParameters(cmd1);

                    int empId = Convert.ToInt32(cmd1.ExecuteScalar());

                    // ✅ 2. IF ACCOUNTANT → INSERT INTO Accountants
                    if (jobTitle.Trim().ToLower() == "accountant")
                    {
                        string q2 = @"INSERT INTO Accountants(EmployeeID) VALUES(@EmployeeID)";
                        SqlCommand cmd2 = new SqlCommand(q2, con, tran);
                        cmd2.Parameters.AddWithValue("@EmployeeID", empId);
                        cmd2.ExecuteNonQuery();
                    }

                    // ✅ 3. INSERT INTO Users
                    InsertIntoUsers(empId,
                        jobTitle.Trim().ToLower() == "accountant" ? "Accountant" : "Employee",
                        con, tran);

                    tran.Commit();

                    MessageBox.Show("✅ Registration successful!");
                    ClearForm();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("❌ Error: " + ex.Message);
                }
            }
        }

        // -------------------- USERS --------------------

        private void InsertIntoUsers(int refId, string role, SqlConnection con, SqlTransaction tran)
        {
            string query = @"INSERT INTO Users (RefId, Role, Email, Password, SecurityAns)
                             VALUES (@RefId, @Role, @Email, @Password, @SecurityAns)";

            SqlCommand cmd = new SqlCommand(query, con, tran);
            cmd.Parameters.AddWithValue("@RefId", refId);
            cmd.Parameters.AddWithValue("@Role", role);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@SecurityAns", securityAnswer);

            cmd.ExecuteNonQuery();
        }

        // -------------------- COMMON PARAMETERS --------------------

        private void FillCommonParameters(SqlCommand cmd)
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
        }

        // -------------------- CLEAR --------------------

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
