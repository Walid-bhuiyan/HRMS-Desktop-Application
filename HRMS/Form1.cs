using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    public partial class loginframe : Form
    {// ---------------- CONNECTION STRING ----------------

        // 🔴 OLD (Pronoy PC) CONNECTION STRING - DO NOT USE
        private string conStr = @"Data Source=DESKTOP-GC7C78E;Initial Catalog=hrmsDB;Integrated Security=True;";

        // ✅ YOUR CURRENT CONNECTION STRING

        //private string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True;";

        public loginframe()
        {
            InitializeComponent();
        }

        // ---------------- EMPTY EVENT HANDLERS (DESIGNER FIX) ----------------

        private void txtsecurityans_TextChanged(object sender, EventArgs e) { }
        private void cmbLoginAs_SelectedIndexChanged(object sender, EventArgs e) { }
        private void lblLoginAs_Click(object sender, EventArgs e) { }
        private void Forgetpasspanel_Paint(object sender, PaintEventArgs e) { }
        private void txtemail_TextChanged(object sender, EventArgs e) { }

        // ---------------- PASSWORD HASH ----------------

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

        // ---------------- LOGIN ----------------

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

            string email = txtuname.Text.Trim();
            string password = HashPassword(txtpass.Text.Trim());
            string role = cmbLoginAs.Text.Trim();

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = @"SELECT RefId, Role 
                                 FROM Users 
                                 WHERE Email=@Email AND Password=@Password AND Role=@Role";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int refId = Convert.ToInt32(dr["RefId"]);

                    MessageBox.Show("Login Successful!");

                    if (role == "Admin")
                        new btnadminoperations().Show();
                    else if (role == "Employee")
                        new EmployeeDashboard().Show();
                    else if (role == "HR Manager")
                        new HRManagerDashboard(refId).Show();   // ✅ FIXED
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

        // ---------------- SHOW / HIDE PASSWORD ----------------

        private void chbshowpass_CheckedChanged(object sender, EventArgs e)
        {
            txtpass.PasswordChar = chbshowpass.Checked ? '\0' : '*';
        }

        // ---------------- FORGOT PASSWORD ----------------

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

                    string checkQuery = @"SELECT RefId 
                                          FROM Users 
                                          WHERE Email=@Email 
                                          AND LTRIM(RTRIM(SecurityAns)) = LTRIM(RTRIM(@SecAns))";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Email", email);
                    checkCmd.Parameters.AddWithValue("@SecAns", secAns);

                    SqlDataReader dr = checkCmd.ExecuteReader();

                    if (dr.Read())
                    {
                        dr.Close();

                        string updateUserQuery = "UPDATE Users SET Password=@NewPass WHERE Email=@Email";
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

        // ---------------- UI ----------------

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            Forgetpasspanel.Visible = true;
        }

        private void loginframe_Load(object sender, EventArgs e)
        {
            Forgetpasspanel.Visible = false;
        }
    }
}
