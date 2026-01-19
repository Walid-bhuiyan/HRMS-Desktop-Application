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
        private string name, email, phone, gender, address, securityans, pass;
        private DateTime dob;
        public AdminInsertionForm()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            AdminOperation admnoperations= new AdminOperation();
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


        private void button1_Click(object sender, EventArgs e)
        {
            name=txtname.Text;
            email=txtemail.Text;
            phone = txtphone.Text;
            address = richTextBox1.Text;
            securityans = txtquestionans.Text;
            pass = txtpass.Text;

            dob = Convert.ToDateTime(dateTimePicker1.Text);

            if (rbmale.Checked)
            {
                gender = "Male";
            }
            else if (rbfemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "";
            }

            

            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(gender) ||
                string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(securityans) ||
                string.IsNullOrEmpty(pass) )
            {
                MessageBox.Show("All fields are required!", "Validation Error");
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address!", "Validation Error");
                return;
            }

            
            if (dob == DateTime.Today)
            {
                MessageBox.Show("Date of birth cannot be today's date!", "Validation Error");
                return;
            }

            InsertIntoAdmin();


            MessageBox.Show("Admin inserted successfully!");

        }
    }
}
