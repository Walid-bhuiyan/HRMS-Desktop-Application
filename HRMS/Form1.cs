using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    public partial class loginframe : Form
    {
        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";

        public loginframe()
        {
            InitializeComponent();
        }

        // ================= HASH =================
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

        // ================= LOGIN =================
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuname.Text.Trim() == "" || txtpass.Text.Trim() == "")
            {
                MessageBox.Show("Username and Password required!");
                return;
            }

            if (cmbLoginAs.SelectedIndex == -1)
            {
                MessageBox.Show("Please select role!");
                return;
            }

            string email = txtuname.Text.Trim();
            string password = HashPassword(txtpass.Text.Trim());
            string role = cmbLoginAs.Text.Trim();

            if (role == "HR Manager") role = "HRManager";

            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();

                    string query = @"SELECT RefId, Role FROM Users 
                                     WHERE Email=@Email AND Password=@Password AND Role=@Role";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        int refId = Convert.ToInt32(dr["RefId"]);
                        dr.Close();

                        MessageBox.Show("Login Successful!");

                        if (role == "Admin")
                            new btnadminoperations(refId, email).Show();
                        else if (role == "Employee")
                            new EmployeeDashboard(refId).Show();
                        else if (role == "HRManager")
                            new HRManagerDashboard(refId).Show();
                        else if (role == "Accountant")
                            new AccountantDashboard().Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login information!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
        }

        // ================= SHOW / HIDE PASSWORD =================
        private void chbshowpass_CheckedChanged(object sender, EventArgs e)
        {
            txtpass.PasswordChar = chbshowpass.Checked ? '\0' : '*';
        }

        // ================= FORGOT PASSWORD =================
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

                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();

                    string checkQuery = @"SELECT RefId FROM Users 
                                          WHERE Email=@Email AND SecurityAns=@SecAns";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Email", email);
                    checkCmd.Parameters.AddWithValue("@SecAns", secAns);

                    SqlDataReader dr = checkCmd.ExecuteReader();

                    if (dr.Read())
                    {
                        dr.Close();

                        string updateUserQuery = @"UPDATE Users SET Password=@NewPass WHERE Email=@Email";
                        SqlCommand updateUserCmd = new SqlCommand(updateUserQuery, conn);
                        updateUserCmd.Parameters.AddWithValue("@NewPass", hashedNewPass);
                        updateUserCmd.Parameters.AddWithValue("@Email", email);
                        updateUserCmd.ExecuteNonQuery();

                        MessageBox.Show("Password updated successfully!");
                        Forgetpasspanel.Visible = false;
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Invalid email or security answer!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ================= UI =================
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            Forgetpasspanel.Visible = true;
        }

        private void loginframe_Load(object sender, EventArgs e)
        {
            Forgetpasspanel.Visible = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Forgetpasspanel.Visible = false;
            PanelLogin.Visible = true;
        }

        // =====================================================
        // 🔧 DESIGNER FIX METHODS (EMPTY BUT REQUIRED)
        // =====================================================

        private void Forgetpasspanel_Paint(object sender, PaintEventArgs e) { }

        private void txtemail_TextChanged(object sender, EventArgs e) { }

        private void txtsecurityans_TextChanged(object sender, EventArgs e) { }

        private void cmbLoginAs_SelectedIndexChanged(object sender, EventArgs e) { }

        private void lblLoginAs_Click(object sender, EventArgs e) { }

        private void txtemail_TextChanged_1(object sender, EventArgs e) { }

        private void txtuname_TextChanged(object sender, EventArgs e) { }

        private void txtpass_TextChanged(object sender, EventArgs e) { }
    }
}
