using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRMS
{
    public partial class AdminAttendence : Form
    {
        public AdminAttendence()
        {
            InitializeComponent();
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            btnadminoperations btnatndc = new btnadminoperations();
            btnatndc.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tableName = "";
                string userType = "";
                string idColumn = "";
                string nameColumn = "name";

                switch (chbdept.Text)
                {
                    case "Admin":
                        tableName = "Admins";
                        userType = "Admin";
                        idColumn = "id";
                        break;

                    case "Manager":
                        tableName = "HRManagers";
                        userType = "HRManager";
                        idColumn = "hrId";
                        break;

                    case "Employee":
                        tableName = "Employees";
                        userType = "Employee";
                        idColumn = "Id";
                        nameColumn = "Name";
                        break;

                    case "Accountant":
                        tableName = "Accountants";
                        userType = "Accountant";
                        idColumn = "id";
                        break;

                    default:
                        MessageBox.Show("Please select a department!");
                        return;
                }
                using (SqlConnection conn = new SqlConnection(
                    @"Data Source=DESKTOP-GC7C78E;Initial Catalog=hrmsDB;Integrated Security=True;"))
                {
                    conn.Open();

                    string query = $"SELECT {idColumn} AS Id, {nameColumn} AS Name FROM {tableName}";
                    SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    if (!dt.Columns.Contains("UserType"))
                        dt.Columns.Add("UserType", typeof(string));

                    foreach (DataRow row in dt.Rows)
                        row["UserType"] = userType;

                    if (!dt.Columns.Contains("Present"))
                        dt.Columns.Add("Present", typeof(bool));

                    DateTime selectedDate = dateTimePicker1.Value.Date;
                    foreach (DataRow row in dt.Rows)
                    {
                        int userId = Convert.ToInt32(row["Id"]);

                        string checkQuery =
                            "SELECT Status FROM Attendance WHERE UserId=@UserId AND UserType=@UserType AND AttendanceDate=@AttendanceDate";

                        SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                        checkCmd.Parameters.AddWithValue("@UserId", userId);
                        checkCmd.Parameters.AddWithValue("@UserType", userType);
                        checkCmd.Parameters.AddWithValue("@AttendanceDate", selectedDate);

                        object result = checkCmd.ExecuteScalar();
                        row["Present"] = (result != null && result.ToString() == "Present");
                    }

                    dataGridView1.DataSource = dt;

                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                        col.Visible = false;

                    dataGridView1.Columns["Id"].Visible = true;
                    dataGridView1.Columns["Name"].Visible = true;
                    dataGridView1.Columns["UserType"].Visible = true;
                    dataGridView1.Columns["Present"].Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }
        private void btnconfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No data to save!");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(
                    @"Data Source=DESKTOP-GC7C78E;Initial Catalog=hrmsDB;Integrated Security=True;"))
                {
                    conn.Open();
                    DateTime selectedDate = dateTimePicker1.Value.Date;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int userId = Convert.ToInt32(row.Cells["Id"].Value);
                        string name = row.Cells["Name"].Value.ToString();
                        string userType = row.Cells["UserType"].Value.ToString();
                        bool isPresent = Convert.ToBoolean(row.Cells["Present"].Value);
                        string status = isPresent ? "Present" : "Absent";

                        string checkQuery =
                            "SELECT COUNT(*) FROM Attendance WHERE UserId=@UserId AND UserType=@UserType AND AttendanceDate=@AttendanceDate";

                        SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                        checkCmd.Parameters.AddWithValue("@UserId", userId);
                        checkCmd.Parameters.AddWithValue("@UserType", userType);
                        checkCmd.Parameters.AddWithValue("@AttendanceDate", selectedDate);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            string updateQuery =
                                "UPDATE Attendance SET Status=@Status WHERE UserId=@UserId AND UserType=@UserType AND AttendanceDate=@AttendanceDate";

                            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                            updateCmd.Parameters.AddWithValue("@Status", status);
                            updateCmd.Parameters.AddWithValue("@UserId", userId);
                            updateCmd.Parameters.AddWithValue("@UserType", userType);
                            updateCmd.Parameters.AddWithValue("@AttendanceDate", selectedDate);
                            updateCmd.ExecuteNonQuery();
                        }
                        else
                        {
                            string insertQuery =
                                "INSERT INTO Attendance (UserId,UserType,Name,Status,AttendanceDate) VALUES (@UserId,@UserType,@Name,@Status,@AttendanceDate)";

                            SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                            insertCmd.Parameters.AddWithValue("@UserId", userId);
                            insertCmd.Parameters.AddWithValue("@UserType", userType);
                            insertCmd.Parameters.AddWithValue("@Name", name);
                            insertCmd.Parameters.AddWithValue("@Status", status);
                            insertCmd.Parameters.AddWithValue("@AttendanceDate", selectedDate);
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Attendance saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving attendance: " + ex.Message);
            }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(
                    @"Data Source=DESKTOP-GC7C78E;Initial Catalog=hrmsDB;Integrated Security=True;"))
                {
                    conn.Open();
                    DateTime selectedDate = dateTimePicker1.Value.Date;

                    string query =
                        "SELECT AttendanceId AS Id, UserId, Name, Status, AttendanceDate FROM Attendance WHERE AttendanceDate=@AttendanceDate";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@AttendanceDate", selectedDate);

                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    dataGridView1.DataSource = dt;

                    foreach (DataGridViewColumn col in dataGridView1.Columns)
                        col.Visible = false;

                    dataGridView1.Columns["Id"].Visible = true;
                    dataGridView1.Columns["UserId"].Visible = true;
                    dataGridView1.Columns["Name"].Visible = true;
                    dataGridView1.Columns["Status"].Visible = true;
                    dataGridView1.Columns["AttendanceDate"].Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error viewing attendance: " + ex.Message);
            }
        }
        private void chbdept_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
