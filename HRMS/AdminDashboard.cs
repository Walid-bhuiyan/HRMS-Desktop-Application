using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    public partial class btnadminoperations : Form
    {
        int adminId;
        string adminEmail;

        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";
        public btnadminoperations(int id, string email)
        {
            InitializeComponent();
            adminId = id;
            adminEmail = email;
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            resetpasspanel.Visible = false;

            lblwc.Text = "";
            lblwc.Dock = DockStyle.Fill;
            lblwc.TextAlign = ContentAlignment.MiddleCenter;
            lblwc.AutoSize = false;
            lblwc.Font = new Font("Segoe UI", 24, FontStyle.Bold);

            LoadAdminName();
        }

        private void LoadAdminName()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();

                    string query = "SELECT Name FROM Admins WHERE Id=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", adminId);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        lblwc.Text = "Welcome Admin - " + result.ToString();
                    }
                    else
                    {
                        lblwc.Text = "Welcome Admin";
                    }

                    conn.Close();
                }

                FitLabelText(lblwc);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admin name: " + ex.Message);
            }
        }
        private void FitLabelText(Label lbl)
        {
            if (string.IsNullOrEmpty(lbl.Text)) return;

            int maxWidth = lbl.Width - 20;
            int fontSize = 24;

            using (Graphics g = lbl.CreateGraphics())
            {
                while (fontSize > 8)
                {
                    Font testFont = new Font(lbl.Font.FontFamily, fontSize, lbl.Font.Style);
                    SizeF textSize = g.MeasureString(lbl.Text, testFont);

                    if (textSize.Width <= maxWidth)
                    {
                        lbl.Font = testFont;
                        break;
                    }
                    fontSize--;
                }
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            loginframe lg = new loginframe();
            lg.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminOperation admnoperation = new AdminOperation(adminId, adminEmail);
            admnoperation.Show();
            this.Hide();
        }
        private void btnresetpassword_Click(object sender, EventArgs e)
        {
            resetpasspanel.Visible = true;
            resetpasspanel.BringToFront();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            resetpasspanel.Visible = false;
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
        private void btnconfirm_Click(object sender, EventArgs e)
        {
            string oldPass = txtoldpass.Text.Trim();
            string newPass = txtnewpass.Text.Trim();
            string confirmPass = txtconfirmpass.Text.Trim();

            if (oldPass == "" || newPass == "" || confirmPass == "")
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("New password and Confirm password do not match!");
                return;
            }

            if (oldPass == newPass)
            {
                MessageBox.Show("New password cannot be the same as old password!");
                return;
            }

            string hashedOld = HashPassword(oldPass);
            string hashedNew = HashPassword(newPass);

            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();

                    string checkQuery = @"SELECT COUNT(*) FROM Users WHERE RefId=@id AND Role='Admin' AND Password=@old";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@id", adminId);
                    checkCmd.Parameters.AddWithValue("@old", hashedOld);

                    int ok = (int)checkCmd.ExecuteScalar();

                    if (ok == 0)
                    {
                        MessageBox.Show("Old password is incorrect!");
                        return;
                    }

                    string q1 = "UPDATE Users SET Password=@new WHERE RefId=@id AND Role='Admin'";
                    SqlCommand c1 = new SqlCommand(q1, conn);
                    c1.Parameters.AddWithValue("@new", hashedNew);
                    c1.Parameters.AddWithValue("@id", adminId);
                    c1.ExecuteNonQuery();

                    string q2 = "UPDATE Admins SET Password=@new WHERE Id=@id";
                    SqlCommand c2 = new SqlCommand(q2, conn);
                    c2.Parameters.AddWithValue("@new", hashedNew);
                    c2.Parameters.AddWithValue("@id", adminId);
                    c2.ExecuteNonQuery();

                    MessageBox.Show("Password updated successfully!");

                    txtoldpass.Clear();
                    txtnewpass.Clear();
                    txtconfirmpass.Clear();
                    resetpasspanel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnempoyeeoperations_Click(object sender, EventArgs e)
        {
            HR_EmployeeManagement emp = new HR_EmployeeManagement("ADMIN", adminId);
            emp.Show();
            this.Hide();
        }

        private void btnmangeroperations_Click(object sender, EventArgs e)
        {
            AdminOpHRManager admnhrmanager = new AdminOpHRManager(adminId, adminEmail);
            admnhrmanager.Show();
            this.Hide();
        }

        private void btnattendence_Click(object sender, EventArgs e)
        {
            AdminAttendence admnatdnc = new AdminAttendence();
            admnatdnc.Show();
            this.Hide();
        }
        private void txtusername_TextChanged(object sender, EventArgs e) 
        {
        
        }

        private void txtoldpass_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void txtnewpass_TextChanged(object sender, EventArgs e) 
        {
        
        }

        private void txtconfirmpass_TextChanged(object sender, EventArgs e) 
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e) 
        {
        
        }

        private void lblwelcome_Click(object sender, EventArgs e) 
        {
        
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) 
        {
        
        }

        private void btnaccountantoperations_Click(object sender, EventArgs e)
        {
            Admin_PayrollManagement n = new Admin_PayrollManagement(adminId,adminEmail);
            n.Show();
            this.Hide();
        }
    }
}
