using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace HRMS
{
    public partial class AdminInsertionForm : Form
    {
        int adminId;
        string adminEmail;

        private string name, email, phone, gender, address, securityans, pass;
        private DateTime dob;

        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";

        // ✅ REQUIRED CONSTRUCTOR
        public AdminInsertionForm(int id, string emailLogged)
        {
            InitializeComponent();
            adminId = id;
            adminEmail = emailLogged;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AdminOperation admnoperations= new AdminOperation(adminId, adminEmail);
            admnoperations.Show();
            this.Close();
        }

        private void AdminInsertionForm_Load(object sender, EventArgs e)
        {

        }

        private SqlConnection Connect()
        {
            string connectionString = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";
            SqlConnection conn= new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        /* private void InsertIntoAdmin()
         {
             string hashedPass = HashPassword(pass);
             SqlConnection conn = Connect();
             // string query = "Insert into Admins (Name,Email,phone,Gender,Address,dob,securityans,password) values('Faria','f@gmail.com','01601566663','Female','Address','2000-01-01','tomy','1234')";
             string query = "Insert into Admins (name,email,phone,gender,address,dob,securityans,password) " +
                "values('" + name + "','" + email + "','" + phone + "','" + gender + "','" + address + "','" + dob + "','" + securityans + "','" + hashedPass + "'); " +
                "SELECT SCOPE_IDENTITY();";

             SqlCommand cmd =new SqlCommand(query, conn);
             int adminId = Convert.ToInt32(cmd.ExecuteScalar());
             InsertIntoUsers(adminId, "Admin");
         }

         private void InsertIntoUsers(int refId, string role)
         {
             SqlConnection conn = Connect();

             string query = "INSERT INTO Users (RefId, Role, Email, Password, SecurityAns) " +
                            "VALUES (" + refId + ", '" + role + "', '" + email + "', '" + HashPassword(pass) + "', '" + securityans + "')";

             SqlCommand cmd = new SqlCommand(query, conn);
             cmd.ExecuteNonQuery();
         }

         */

        private void InsertIntoAdmin()
        {
            try
            {
                string hashedPass = HashPassword(pass);
                SqlConnection conn = Connect();

                string query = "INSERT INTO Admins (name,email,phone,gender,address,dob,securityans,password) " +
                               "VALUES ('" + name + "','" + email + "','" + phone + "','" + gender + "','" + address + "','" + dob + "','" + securityans + "','" + hashedPass + "'); " +
                               "SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);
                int adminId = Convert.ToInt32(cmd.ExecuteScalar());

                InsertIntoUsers(adminId, "Admin");

            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("This email already exists! Please use a different email.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Database error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertIntoUsers(int refId, string role)
        {
            try
            {
                SqlConnection conn = Connect();

                string query = "INSERT INTO Users (RefId, Role, Email, Password, SecurityAns) " +
                               "VALUES (" + refId + ", '" + role + "', '" + email + "', '" + HashPassword(pass) + "', '" + securityans + "')";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627) 
                {
                    MessageBox.Show("This email already exists in Users table! Insert failed.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Database error in Users table: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Users table: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            foreach (char c in email)
            {
                if (char.IsUpper(c))
                    return false;
            }
            int atCount = 0;
            foreach (char c in email)
            {
                if (c == '@')
                    atCount++;
            }
            if (atCount != 1)
                return false;

            string[] parts = email.Split('@');
            string local = parts[0];
            string domainFull = parts[1];

            if (local.Length < 2) 
                return false;

            char[] specialChars = { '.', '_', '-', '+' };

            if (specialChars.Contains(local[0]) || specialChars.Contains(local[local.Length - 1]))
                return false;

            for (int i = 0; i < local.Length; i++)
            {
                char c = local[i];
                if (!(char.IsLower(c) || char.IsDigit(c) || specialChars.Contains(c)))
                    return false;

                if (i > 0 && c == '.' && local[i - 1] == '.')
                    return false; 
            }

            string[] domainParts = domainFull.Split('.');
            if (domainParts.Length != 2)
                return false;

            string domain = domainParts[0];
            string tld = domainParts[1];

            string[] allowedDomains = { "gmail", "yahoo", "icloud", "hotmail", "outlook" };
            string[] allowedTlds = { "com", "org", "net", "edu" };

            if (!allowedDomains.Contains(domain))
                return false;

            if (!allowedTlds.Contains(tld))
                return false;

            foreach (char c in domain)
            {
                if (!(char.IsLower(c) || char.IsDigit(c) || c == '-'))
                    return false;
            }

            return true; 
        }



        private void button1_Click(object sender, EventArgs e)
        {
            lblerrorname.Text = lblerrorphone.Text = lblerrorpasswod.Text = lblerrorsecurityans.Text =
            lblerroraddress.Text = lblerrordob.Text = lblerrorgender.Text = "";

            bool hasEmptyFields = false;

            name = txtname.Text;
            email = txtemail.Text;
            phone = txtphone.Text;
            address = richTextBox1.Text;
            securityans = txtquestionans.Text;
            pass = txtpass.Text;
            dob = Convert.ToDateTime(dateTimePicker1.Text);

            if (rbmale.Checked) gender = "Male";
            else if (rbfemale.Checked) gender = "Female";
            else gender = "";

            if (string.IsNullOrWhiteSpace(name))
            {
                lblerrorname.Text = "Please enter name";
                hasEmptyFields = true;
            }
            if (string.IsNullOrWhiteSpace(phone))
            {
                lblerrorphone.Text = "Please enter phone number";
                hasEmptyFields = true;
            }
            if (string.IsNullOrWhiteSpace(pass))
            {
                lblerrorpasswod.Text = "Please enter password";
                hasEmptyFields = true;
            }
            if (string.IsNullOrWhiteSpace(securityans))
            {
                lblerrorsecurityans.Text = "Please enter security answer";
                hasEmptyFields = true;
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                lblerroraddress.Text = "Please enter address";
                hasEmptyFields = true;
            }
            if (dob == DateTime.Today)
            {
                lblerrordob.Text = "Invalid DOB ";
                hasEmptyFields = true;
            }
            if (string.IsNullOrWhiteSpace(gender))
            {
                lblerrorgender.Text = "Please select gender";
                hasEmptyFields = true;
            }

            if (hasEmptyFields) return;

            foreach (char c in name)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Name can contain only letters and spaces!", "Invalid Name");
                    return;
                }
            }

            if (phone.Length < 6 || phone.Length > 15 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must be 6-15 digits and digits only!", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pass.Length < 4 || !pass.Any(c => "#@$%&*".Contains(c)))
            {
                MessageBox.Show("Password must be at least 4 characters and contain at least one special character (#,@,$,%,&,*).", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address!", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            InsertIntoAdmin();
            MessageBox.Show("Admin inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtname.Clear();
            txtemail.Clear();
            txtphone.Clear();
            richTextBox1.Clear();
            txtquestionans.Clear();
            txtpass.Clear();
            rbmale.Checked = rbfemale.Checked = false;
            dateTimePicker1.Value = DateTime.Today;
        }



    }
}
