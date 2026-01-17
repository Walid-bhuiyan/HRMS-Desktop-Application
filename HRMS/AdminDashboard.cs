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
    public partial class btnadminoperations : Form
    {
        private static string LoggedInAdminEmailStatic; 
        private string loggedInAdminEmail;
        public btnadminoperations()
        {
            InitializeComponent();
            loggedInAdminEmail = LoggedInAdminEmailStatic; 
        }
        public btnadminoperations(string email)
        {
            InitializeComponent();
            loggedInAdminEmail = email;
            LoggedInAdminEmailStatic = email; 
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




        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            resetpasspanel.Visible = false;

            lblwc.Text = "";
            lblwc.Dock = DockStyle.Fill;
            lblwc.TextAlign = ContentAlignment.MiddleCenter;
            lblwc.AutoSize = false;
            lblwc.Font = new Font("Segoe UI", 24, FontStyle.Bold);

            if (!string.IsNullOrEmpty(loggedInAdminEmail))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(
                        @"Data Source=DESKTOP-GC7C78E;Initial Catalog=hrmsDB;Integrated Security=True;"))
                    {
                        conn.Open();

                        string query = "SELECT name FROM Admins WHERE email = @email";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@email", loggedInAdminEmail);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            lblwc.Text = "Welcome Admin - " + result.ToString();
                        else
                            lblwc.Text = "Welcome Admin";

                        conn.Close();
                    }

                    FitLabelText(lblwc);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading admin name: " + ex.Message);
                }
            }
            else
            {
                lblwc.Text = "Welcome Admin";
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            
            loginframe lg = new loginframe();
            lg.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminOperation admnoperation=new AdminOperation();
            admnoperation.Show();
            this.Hide();
        }

        private void btnresetpassword_Click(object sender, EventArgs e)
        {
            resetpasspanel.Visible = true; 
            resetpasspanel.BringToFront();
        }

        private string HashPassword(string password)
        {
            using (System.Security.Cryptography.SHA256 sha = System.Security.Cryptography.SHA256.Create())
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
            string username = txtusername.Text.Trim();
            string oldPass = txtoldpass.Text.Trim();
            string newPass = txtnewpass.Text.Trim();
            string confirmPass = txtconfirmpass.Text.Trim();

            if (username == "" || oldPass == "" || newPass == "" || confirmPass == "")
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

            string hashedOldPass = HashPassword(oldPass);
            string hashedNewPass = HashPassword(newPass);

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GC7C78E;Initial Catalog=hrmsDB;Integrated Security=True;"))
                {
                    conn.Open();

                    string checkQuery = "SELECT RefId FROM Users WHERE Email='" + username + "' AND Password='" + hashedOldPass + "' AND Role='Admin'";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    object result = checkCmd.ExecuteScalar();

                    if (result != null) 
                    {
                        int refId = Convert.ToInt32(result);

                        string updateUserQuery = "UPDATE Users SET Password='" + hashedNewPass + "' WHERE RefId=" + refId + " AND Role='Admin';";

                        string updateAdminQuery = "UPDATE Admins SET Password='" + hashedNewPass + "' WHERE Id=" + refId + ";";

                        string combinedQuery = updateUserQuery + updateAdminQuery;
                        SqlCommand updateCmd = new SqlCommand(combinedQuery, conn);
                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Password updated successfully!");

                        resetpasspanel.Visible = false;
                        txtusername.Clear();
                        txtoldpass.Clear();
                        txtnewpass.Clear();
                        txtconfirmpass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Username or old password is incorrect!");
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            resetpasspanel.Visible = false;
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblwelcome_Click(object sender, EventArgs e)
        {


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnattendence_Click(object sender, EventArgs e)
        {
            AdminAttendence admnatdnc = new AdminAttendence();
            admnatdnc.Show();
            this.Close();
        }
    }
}
