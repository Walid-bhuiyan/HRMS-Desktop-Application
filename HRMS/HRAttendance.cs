using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRMS
{
    public partial class HRAttendance : Form
    {
        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";
        int hrId;

        // ================= CONSTRUCTOR =================
        public HRAttendance(int id)
        {
            InitializeComponent();
            hrId = id;
        }

        // ================= BACK =================
        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        // ================= LOAD USERS =================
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string tableName = "";
                string userType = "";
                string idColumn = "";
                string nameColumn = "";

                switch (cmbDepartment.Text)
                {
                    case "Admin":
                        tableName = "Admins";
                        userType = "Admin";
                        idColumn = "id";
                        nameColumn = "name";
                        break;

                    case "Manager":
                        tableName = "HRManagers";
                        userType = "HRManager";
                        idColumn = "hrId";
                        nameColumn = "Name";
                        break;

                    case "Employee":
                        tableName = "Employees_Info";
                        userType = "Employee";
                        idColumn = "EmployeeID";
                        nameColumn = "FullName";
                        break;

                    case "Accountant":
                        tableName = "Accountants";
                        userType = "Accountant";
                        idColumn = "AccountantID";
                        nameColumn = "FullName";
                        break;

                    default:
                        MessageBox.Show("Please select a department!");
                        return;
                }

                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();

                    string query = $"SELECT {idColumn} AS Id, {nameColumn} AS Name FROM {tableName}";
                    SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    dt.Columns.Add("UserType", typeof(string));
                    dt.Columns.Add("Present", typeof(bool));

                    DateTime selectedDate = dtpDate.Value.Date;

                    foreach (DataRow row in dt.Rows)
                    {
                        row["UserType"] = userType;
                        int userId = Convert.ToInt32(row["Id"]);

                        string checkQuery = @"SELECT Status FROM Attendance 
                                              WHERE UserId=@uid AND UserType=@ut AND AttendanceDate=@dt";

                        SqlCommand cmd = new SqlCommand(checkQuery, conn);
                        cmd.Parameters.AddWithValue("@uid", userId);
                        cmd.Parameters.AddWithValue("@ut", userType);
                        cmd.Parameters.AddWithValue("@dt", selectedDate);

                        object result = cmd.ExecuteScalar();
                        row["Present"] = (result != null && result.ToString() == "Present");
                    }

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        // ================= SAVE ATTENDANCE =================
        private void btnSaveAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();
                    DateTime selectedDate = dtpDate.Value.Date;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int userId = Convert.ToInt32(row.Cells["Id"].Value);
                        string name = row.Cells["Name"].Value.ToString();
                        string userType = row.Cells["UserType"].Value.ToString();
                        bool present = Convert.ToBoolean(row.Cells["Present"].Value);
                        string status = present ? "Present" : "Absent";

                        string check = @"SELECT COUNT(*) FROM Attendance 
                                         WHERE UserId=@uid AND UserType=@ut AND AttendanceDate=@dt";

                        SqlCommand checkCmd = new SqlCommand(check, conn);
                        checkCmd.Parameters.AddWithValue("@uid", userId);
                        checkCmd.Parameters.AddWithValue("@ut", userType);
                        checkCmd.Parameters.AddWithValue("@dt", selectedDate);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            string update = @"UPDATE Attendance SET Status=@st 
                                              WHERE UserId=@uid AND UserType=@ut AND AttendanceDate=@dt";

                            SqlCommand up = new SqlCommand(update, conn);
                            up.Parameters.AddWithValue("@st", status);
                            up.Parameters.AddWithValue("@uid", userId);
                            up.Parameters.AddWithValue("@ut", userType);
                            up.Parameters.AddWithValue("@dt", selectedDate);
                            up.ExecuteNonQuery();
                        }
                        else
                        {
                            string insert = @"INSERT INTO Attendance 
                            (UserId,UserType,Name,Status,AttendanceDate)
                            VALUES(@uid,@ut,@nm,@st,@dt)";

                            SqlCommand ins = new SqlCommand(insert, conn);
                            ins.Parameters.AddWithValue("@uid", userId);
                            ins.Parameters.AddWithValue("@ut", userType);
                            ins.Parameters.AddWithValue("@nm", name);
                            ins.Parameters.AddWithValue("@st", status);
                            ins.Parameters.AddWithValue("@dt", selectedDate);
                            ins.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Attendance saved successfully ✅");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving attendance: " + ex.Message);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            new HRManagerDashboard(hrId).Show();
            this.Hide();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a department!");
                return;
            }

            string userType = "";

            switch (cmbDepartment.Text)
            {
                case "Admin": userType = "Admin"; break;
                case "Manager": userType = "HRManager"; break;
                case "Employee": userType = "Employee"; break;
                case "Accountant": userType = "Accountant"; break;
                default:
                    MessageBox.Show("Invalid department!");
                    return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    UserId AS ID,
                    Name,
                    UserType,
                    Status,
                    AttendanceDate
                FROM Attendance
                WHERE UserType = @ut
                  AND AttendanceDate = @dt";

                    SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                    adp.SelectCommand.Parameters.AddWithValue("@ut", userType);
                    adp.SelectCommand.Parameters.AddWithValue("@dt", dtpDate.Value.Date);

                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No attendance found for this date and department.");
                    }

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error viewing attendance: " + ex.Message);
            }
        }

    }
}
