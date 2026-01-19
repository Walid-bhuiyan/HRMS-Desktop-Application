using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    public partial class HRChangePassword : Form
    {
        int hrId;

        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True;";

        // ✅ Constructor must receive hrId
        public HRChangePassword(int id)
        {
            InitializeComponent();
            hrId = id;
        }

        // 🔐 HASH FUNCTION (same as login)
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

        // ✅ CHANGE PASSWORD BUTTON
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text == "" || txtNewPass.Text == "" || txtConfirmPass.Text == "")
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            if (txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("New password and confirm password do not match!");
                return;
            }

            string oldHash = HashPassword(txtOldPass.Text.Trim());
            string newHash = HashPassword(txtNewPass.Text.Trim());

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    // 1️⃣ Check old password from Users
                    string checkQuery = @"SELECT COUNT(*) FROM Users 
                                          WHERE RefId=@id AND Role='HRManager' AND Password=@oldpass";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@id", hrId);
                    checkCmd.Parameters.AddWithValue("@oldpass", oldHash);

                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists == 0)
                    {
                        MessageBox.Show("Old password is incorrect!");
                        return;
                    }

                    // 2️⃣ Update Users table
                    string updateUsers = @"UPDATE Users SET Password=@newpass 
                                           WHERE RefId=@id AND Role='HRManager'";

                    SqlCommand cmd1 = new SqlCommand(updateUsers, con);
                    cmd1.Parameters.AddWithValue("@newpass", newHash);
                    cmd1.Parameters.AddWithValue("@id", hrId);
                    cmd1.ExecuteNonQuery();

                    // 3️⃣ Update HRManagers table
                    string updateHR = @"UPDATE HRManagers SET Password=@newpass 
                                        WHERE hrId=@id";

                    SqlCommand cmd2 = new SqlCommand(updateHR, con);
                    cmd2.Parameters.AddWithValue("@newpass", newHash);
                    cmd2.Parameters.AddWithValue("@id", hrId);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Password changed successfully!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // 🔙 BACK / LOGOUT BUTTON
        private void btnLogout_Click(object sender, EventArgs e)
        {
            HRManagerDashboard n = new HRManagerDashboard();
            n.Show();
            this.Hide();
        }

        private void chbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPass.Checked)
            {
                txtOldPass.PasswordChar = '\0';
                txtNewPass.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                txtOldPass.PasswordChar = '*';
                txtNewPass.PasswordChar = '*';
                txtConfirmPass.PasswordChar = '*';
            }
        }
    }
}
