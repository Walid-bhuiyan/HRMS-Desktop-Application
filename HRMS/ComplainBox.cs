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

namespace HRMS
{
    public partial class ComplainBox : Form
    {
        int employeeId;
        string userType = "";

        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";

        public ComplainBox(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
        }

        
       /* private void ComplainBox_Load(object sender, EventArgs e)
        {
            txtId.Text = employeeId.ToString();
            txtId.ReadOnly = true;

            dateTimePicker1.Value = DateTime.Today;

            LoadUserType();   
        }*/

       
        private void LoadUserType()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string q = "SELECT Role FROM Users WHERE UserId = @id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", employeeId);

                conn.Open();
                object r = cmd.ExecuteScalar();

                if (r != null)
                    userType = r.ToString();
                else
                    userType = "Employee";
            }
        }

        
       /* private void btnDrop_Click(object sender, EventArgs e)
        {
            if (txtSubject.Text.Trim() == "" || richTextBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please write subject and complain.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = @"INSERT INTO Complaints
                                (UserId, UserType, Subject, Description, Status, SubmittedAt)
                                 VALUES
                                (@uid, @utype, @sub, @des, 'Pending', @date)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", employeeId);
                cmd.Parameters.AddWithValue("@utype", userType);
                cmd.Parameters.AddWithValue("@sub", txtSubject.Text.Trim());
                cmd.Parameters.AddWithValue("@des", richTextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Complaint dropped successfully.");

            txtSubject.Clear();
            richTextBox1.Clear();
        }

        
        private void btnCheck_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = @"SELECT TOP 1 Status, SubmittedAt
                                 FROM Complaints
                                 WHERE UserId = @id
                                 ORDER BY SubmittedAt DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", employeeId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtCheckUpdate.Text = reader["Status"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(reader["SubmittedAt"]);
                }
                else
                {
                    MessageBox.Show("No complaints found.");
                }
            }
        }*/

        
        private void btnback_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard(employeeId);
            ed.Show();
            this.Hide();
        }

        private void ComplainBox_Load_1(object sender, EventArgs e)
        {
            txtId.Text = employeeId.ToString();
            txtId.ReadOnly = true;
            dateTimePicker1.Value = DateTime.Today;
            LoadUserType();
        }

        private void btnDropComplain_Click(object sender, EventArgs e)
        {
            

            if (txtSubject.Text.Trim() == "" || richTextBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please write subject and complain.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = @"INSERT INTO Complaints
                        (UserId, UserType, Subject, Description, Status, SubmittedAt)
                         VALUES
                        (@uid, @utype, @sub, @des, 'Pending', @date)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", employeeId);
                cmd.Parameters.AddWithValue("@utype", userType);
                cmd.Parameters.AddWithValue("@sub", txtSubject.Text.Trim());
                cmd.Parameters.AddWithValue("@des", richTextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Complaint dropped successfully.");

            txtSubject.Clear();
            richTextBox1.Clear();
        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = @"SELECT TOP 1 Status, SubmittedAt
                         FROM Complaints
                         WHERE UserId = @id
                         ORDER BY SubmittedAt DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", employeeId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtCheckUpdate.Text = reader["Status"].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(reader["SubmittedAt"]);
                }
                else
                {
                    MessageBox.Show("No complaints found.");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
