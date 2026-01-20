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

        // 🔑 who opened this form
        string callerRole = "";   // "ADMIN" or "HR"
        int callerId = 0;

        private readonly string cs =
            ConfigurationManager.ConnectionStrings["HRMS_DB"].ConnectionString;

        // -------------------- CONSTRUCTORS --------------------

        public RegisterForm()
        {
            InitializeComponent();
        }

        public RegisterForm(string role, int id)
        {
            InitializeComponent();
            callerRole = role;
            callerId = id;
        }

        // -------------------- NAVIGATION --------------------

        private void btnBack_Click(object sender, EventArgs e)
        {
            HR_EmployeeManagement w = new HR_EmployeeManagement(callerRole, callerId);
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

        // -------------------- EMAIL HELPERS --------------------

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool EmailExists(string email)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string q = "SELECT COUNT(*) FROM Users WHERE Email=@em";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@em", email);
                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
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
            if (dtpDOB.Value.Date >= DateTime.Today) { MessageBox.Show("Invalid date of birth"); return; }

            if (string.IsNullOrEmpty(email)) { MessageBox.Show("Enter email"); return; }
            if (!IsValidEmail(email)) { MessageBox.Show("Enter a valid email address"); return; }
            if (EmailExists(email)) { MessageBox.Show("This email is already registered"); return; }

            if (string.IsNullOrEmpty(phone)) { MessageBox.Show("Enter phone number"); return; }
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

            InsertPerson();
        }

        // -------------------- MAIN INSERT LOGIC --------------------

        private void InsertPerson()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlTransaction tran = con.BeginTransaction();

                try
                {
                    int refId = 0;
                    string role = "";

                    if (jobTitle.Trim().ToLower() == "accountant")
                    {
                        string q = @"
                        INSERT INTO Accountants
                        (FullName, Email, Gender, DOB, Phone, Address, Department,
                         JobTitle, EmploymentType, JoinDate, Salary)
                        VALUES
                        (@FullName, @Email, @Gender, @DOB, @Phone, @Address, @Department,
                         @JobTitle, @EmploymentType, @JoinDate, @Salary);
                        SELECT SCOPE_IDENTITY();";

                        SqlCommand cmd = new SqlCommand(q, con, tran);
                        FillCommonParameters(cmd);

                        refId = Convert.ToInt32(cmd.ExecuteScalar());
                        role = "Accountant";
                    }
                    else
                    {
                        string q = @"
                        INSERT INTO Employees_Info
                        (FullName, Email, Gender, DOB, Phone, Address, Department,
                         JobTitle, EmploymentType, JoinDate, Salary)
                        VALUES
                        (@FullName, @Email, @Gender, @DOB, @Phone, @Address, @Department,
                         @JobTitle, @EmploymentType, @JoinDate, @Salary);
                        SELECT SCOPE_IDENTITY();";

                        SqlCommand cmd = new SqlCommand(q, con, tran);
                        FillCommonParameters(cmd);

                        refId = Convert.ToInt32(cmd.ExecuteScalar());
                        role = "Employee";
                    }

                    string uq = @"INSERT INTO Users (RefId, Role, Email, Password, SecurityAns)
                                  VALUES (@RefId, @Role, @Email, @Password, @SecurityAns)";

                    SqlCommand ucmd = new SqlCommand(uq, con, tran);
                    ucmd.Parameters.AddWithValue("@RefId", refId);
                    ucmd.Parameters.AddWithValue("@Role", role);
                    ucmd.Parameters.AddWithValue("@Email", email);
                    ucmd.Parameters.AddWithValue("@Password", password);
                    ucmd.Parameters.AddWithValue("@SecurityAns", securityAnswer);

                    ucmd.ExecuteNonQuery();

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
