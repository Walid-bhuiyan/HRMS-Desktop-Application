using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    public partial class HRChangePassword : Form
    {
        private int hrId;

        private string conStr =
            @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True;";

        // ✅ Constructor must receive hrId
        public HRChangePassword(int id)
        {
            InitializeComponent();
            hrId = id;
        }

        // 🔐 HASH FUNCTION
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

        // ✅ CHANGE PASSWORD
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

            // 🚫 Prevent same old & new password
            if (txtOldPass.Text.Trim() == txtNewPass.Text.Trim())
            {
                MessageBox.Show("New password cannot be the same as old password!");
                return;
            }

            string oldHash = HashPassword(txtOldPass.Text.Trim());
            string newHash = HashPassword(txtNewPass.Text.Trim());

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    // 1️⃣ Check old password
                    string checkQuery = @"SELECT COUNT(*) FROM Users 
                                          WHERE RefId=@id AND Role='HRManager' AND Password=@oldpass";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@id", hrId);
                    checkCmd.Parameters.AddWithValue("@oldpass", oldHash);

                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (exists == 0)
                    {
                        MessageBox.Show("Old password is incorrect!");
                        return;
                    }

                    // 2️⃣ Update Users
                    string updateUsers = @"UPDATE Users 
                                           SET Password=@newpass 
                                           WHERE RefId=@id AND Role='HRManager'";

                    SqlCommand cmd1 = new SqlCommand(updateUsers, con);
                    cmd1.Parameters.AddWithValue("@newpass", newHash);
                    cmd1.Parameters.AddWithValue("@id", hrId);
                    cmd1.ExecuteNonQuery();

                    // 3️⃣ Update HRManagers
                    string updateHR = @"UPDATE HRManagers 
                                        SET Password=@newpass 
                                        WHERE hrId=@id";

                    SqlCommand cmd2 = new SqlCommand(updateHR, con);
                    cmd2.Parameters.AddWithValue("@newpass", newHash);
                    cmd2.Parameters.AddWithValue("@id", hrId);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("✅ Password changed successfully!");

                    new HRManagerDashboard(hrId).Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // 🔙 LOGOUT
        private void btnLogout_Click(object sender, EventArgs e)
        {
            new HRManagerDashboard(hrId).Show();
            this.Hide();
        }

        // 👁 SHOW / HIDE PASSWORD
        private void chbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            char c = chbShowPass.Checked ? '\0' : '*';
            txtOldPass.PasswordChar = c;
            txtNewPass.PasswordChar = c;
            txtConfirmPass.PasswordChar = c;
        }

        // 🔙 BACK
        private void btnBack_Click(object sender, EventArgs e)
        {
            new HRManagerDashboard(hrId).Show();
            this.Hide();
        }
    }
}
