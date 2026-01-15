using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace HRMS
{
    public partial class loginframe : Form
    {
        private string uname = "walid";
        private string pass = "walid@@@";
        public loginframe()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
        }

        private void lblpass_Click(object sender, EventArgs e)
        {

        }

        private void LoginInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

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


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuname.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Username and Password required!");
                return;
            }

            if (cmbLoginAs.SelectedIndex == -1)
            {
                MessageBox.Show("Please select role!");
                return;
            }

            string email = txtuname.Text;
            string password = HashPassword(txtpass.Text);
            string role = cmbLoginAs.Text;

            SqlConnection conn = new SqlConnection(
                @"Data Source=DESKTOP-GC7C78E;Initial Catalog=hrmsDB;Integrated Security=True;"
            );
            conn.Open();

            string query = "SELECT * FROM Users WHERE Email='" + email +
                           "' AND Password='" + password +
                           "' AND Role='" + role + "'";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Login Successful!");

                if (role == "Admin")
                    new btnadminoperations().Show();
                else if (role == "Employee")
                    new EmployeeDashboard().Show();
                else if (role == "HR Manager")
                    new HRManagerDashboard().Show();
                else if (role == "Accountant")
                    new AccountantDashboard().Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login information!");
            }

            conn.Close();
        }





        private void lblLoginAs_Click(object sender, EventArgs e)
        {

        }

        private void cmbLoginAs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chbshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbshowpass.Checked)
            {
                txtpass.PasswordChar = '\0';  
            }
            else
            {
                txtpass.PasswordChar = '*';   
            }
        }


        private void txtsecurityans_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupdatepass_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text.Trim();
            string secAns = txtsecurityans.Text.Trim();
            string newPass = txtnewpass.Text.Trim();

            if (email == "" || secAns == "" || newPass == "")
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            try
            {
                string hashedNewPass = HashPassword(newPass);

                using (SqlConnection conn = new SqlConnection(
                    @"Data Source=DESKTOP-GC7C78E;Initial Catalog=hrmsDB;Integrated Security=True;"))
                {
                    conn.Open();

                   
                    string checkQuery = "SELECT RefId, Role FROM Users WHERE Email=@Email AND SecurityAns=@SecAns";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Email", email);
                    checkCmd.Parameters.AddWithValue("@SecAns", secAns);

                    SqlDataReader dr = checkCmd.ExecuteReader();

                    if (dr.Read())
                    {
                        int refId = Convert.ToInt32(dr["RefId"]);
                        string role = dr["Role"].ToString();
                        dr.Close();

                       
                        string updateUserQuery = "UPDATE Users SET Password=@NewPass WHERE Email=@Email";
                        SqlCommand updateUserCmd = new SqlCommand(updateUserQuery, conn);
                        updateUserCmd.Parameters.AddWithValue("@NewPass", hashedNewPass);
                        updateUserCmd.Parameters.AddWithValue("@Email", email);
                        updateUserCmd.ExecuteNonQuery();

                        
                        string tableName = "";
                        if (role == "Admin") tableName = "Admins";
                        else if (role == "Employee") tableName = "Employees";
                        else if (role == "HR Manager") tableName = "HRManagers";
                        else if (role == "Accountant") tableName = "Accountants";

                        if (tableName != "")
                        {
                            string updateOriginalQuery = $"UPDATE {tableName} SET Password=@NewPass WHERE Id=@RefId";
                            SqlCommand updateOriginalCmd = new SqlCommand(updateOriginalQuery, conn);
                            updateOriginalCmd.Parameters.AddWithValue("@NewPass", hashedNewPass);
                            updateOriginalCmd.Parameters.AddWithValue("@RefId", refId);
                            updateOriginalCmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Password updated successfully!");
                        Forgetpasspanel.Visible = false;
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Invalid email or security answer!");
                    }

                    conn.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            Forgetpasspanel.Visible = true;
        }

        private void loginframe_Load(object sender, EventArgs e)
        {
            Forgetpasspanel.Visible = false;
        }

        private void Forgetpasspanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
