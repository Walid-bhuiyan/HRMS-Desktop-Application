using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    public partial class ChangePassword : Form
    {
        int employeeId;

        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True;";

        // ✅ MUST receive employeeId
        public ChangePassword(int id)
        {
            InitializeComponent();
            employeeId = id;
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

            string oldHash = HashPassword(txtOldPass.Text.Trim());
            string newHash = HashPassword(txtNewPass.Text.Trim());

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    // 1️⃣ CHECK OLD PASSWORD
                    string checkQuery = @"SELECT COUNT(*) FROM Users 
                                          WHERE RefId=@id AND Role='Employee' AND Password=@oldpass";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@id", employeeId);
                    checkCmd.Parameters.AddWithValue("@oldpass", oldHash);

                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists == 0)
                    {
                        MessageBox.Show("Old password is incorrect!");
                        return;
                    }

                    // 2️⃣ UPDATE USERS
                    string updateUsers = @"UPDATE Users 
                                           SET Password=@newpass 
                                           WHERE RefId=@id AND Role='Employee'";

                    SqlCommand cmd = new SqlCommand(updateUsers, con);
                    cmd.Parameters.AddWithValue("@newpass", newHash);
                    cmd.Parameters.AddWithValue("@id", employeeId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Password changed successfully ✅");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // 🔙 BACK
        private void btnback_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard(employeeId);
            ed.Show();
            this.Hide();
        }

        // 👁 SHOW PASSWORD
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
