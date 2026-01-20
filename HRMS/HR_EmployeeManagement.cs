using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRMS
{
    public partial class HR_EmployeeManagement : Form
    {
        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True;";
        string selectedTable = ""; // "EMP" or "ACC"

        // 🔑 who opened this form
        string callerRole = "";   // "ADMIN" or "HR"
        int callerId = 0;         // adminId or hrId

        // ================= DEFAULT (NOT USED FOR HR FLOW) =================
        public HR_EmployeeManagement(int hrid)
        {
            InitializeComponent();
            dataGridViewEmployees.DataSource = null;
            dataGridViewAccountants.DataSource = null;

            callerRole = "HR";
            callerId = hrid;
        }
        public HR_EmployeeManagement()
        {
            InitializeComponent();
            dataGridViewEmployees.DataSource = null;
            dataGridViewAccountants.DataSource = null;
        }

        // ================= ADMIN / HR CONSTRUCTOR =================
        public HR_EmployeeManagement(string role, int id)
        {
            InitializeComponent();
            dataGridViewEmployees.DataSource = null;
            dataGridViewAccountants.DataSource = null;

            callerRole = role;   // "ADMIN" or "HR"
            callerId = id;       // adminId or hrId
        }

        // ================= SHOW EMPLOYEES =================
        private void ShowEmployees()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = @"SELECT EmployeeID, FullName, Email, Gender, DOB, Phone, Address,
                                 Department, JobTitle, EmploymentType, JoinDate, Salary
                                 FROM Employees_Info";

                SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridViewEmployees.DataSource = dt;
            }
        }

        // ================= SHOW ACCOUNTANTS =================
        private void ShowAccountants()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = @"SELECT AccountantID, FullName, Email, Gender, DOB, Phone, Address,
                                 Department, JobTitle, EmploymentType, JoinDate, Salary
                                 FROM Accountants";

                SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridViewAccountants.DataSource = dt;
            }
        }

        // ================= BUTTONS =================
        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            ShowEmployees();
            selectedTable = "EMP";
        }

        private void btnShowAccountants_Click(object sender, EventArgs e)
        {
            ShowAccountants();
            selectedTable = "ACC";
        }

        // ================= GRID CLICK =================
        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedTable = "EMP";
            DataGridViewRow row = dataGridViewEmployees.Rows[e.RowIndex];

            txtId.Text = row.Cells["EmployeeID"].Value.ToString();
            txtName.Text = row.Cells["FullName"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtGender.Text = row.Cells["Gender"].Value.ToString();
            txtDob.Text = Convert.ToDateTime(row.Cells["DOB"].Value).ToString("yyyy-MM-dd");
            txtPhone.Text = row.Cells["Phone"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value.ToString();
        }

        private void dataGridViewAccountants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedTable = "ACC";
            DataGridViewRow row = dataGridViewAccountants.Rows[e.RowIndex];

            txtId.Text = row.Cells["AccountantID"].Value.ToString();
            txtName.Text = row.Cells["FullName"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtGender.Text = row.Cells["Gender"].Value.ToString();
            txtDob.Text = Convert.ToDateTime(row.Cells["DOB"].Value).ToString("yyyy-MM-dd");
            txtPhone.Text = row.Cells["Phone"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value.ToString();
        }

        // ================= CLEAR =================
        private void ClearBoxes()
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtGender.Clear();
            txtDob.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            selectedTable = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        // ================= UPDATE =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || selectedTable == "")
            {
                MessageBox.Show("Please select a record first.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlCommand cmd;

                if (selectedTable == "EMP")
                {
                    cmd = new SqlCommand(@"UPDATE Employees_Info 
                                           SET FullName=@name, Email=@email, Gender=@gender,
                                               DOB=@dob, Phone=@phone, Address=@address
                                           WHERE EmployeeID=@id", conn);
                }
                else
                {
                    cmd = new SqlCommand(@"UPDATE Accountants 
                                           SET FullName=@name, Email=@email, Gender=@gender,
                                               DOB=@dob, Phone=@phone, Address=@address
                                           WHERE AccountantID=@id", conn);
                }

                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@dob", DateTime.Parse(txtDob.Text));
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully.");

                if (selectedTable == "EMP") ShowEmployees();
                else ShowAccountants();
            }
        }

        // ================= SEARCH =================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please enter an ID.");
                return;
            }

            if (!int.TryParse(txtId.Text.Trim(), out int id))
            {
                MessageBox.Show("ID must be numeric.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();

                // try employee
                string empQuery = @"SELECT EmployeeID, FullName, Email, Gender, DOB, Phone, Address
                                    FROM Employees_Info WHERE EmployeeID=@id";

                SqlDataAdapter adp = new SqlDataAdapter(empQuery, conn);
                adp.SelectCommand.Parameters.AddWithValue("@id", id);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    FillFieldsFromRow(dt.Rows[0], "EMP");
                    dataGridViewEmployees.DataSource = dt;
                    dataGridViewAccountants.DataSource = null;
                    return;
                }

                // try accountant
                string accQuery = @"SELECT AccountantID, FullName, Email, Gender, DOB, Phone, Address
                                    FROM Accountants WHERE AccountantID=@id";

                SqlDataAdapter adp2 = new SqlDataAdapter(accQuery, conn);
                adp2.SelectCommand.Parameters.AddWithValue("@id", id);
                DataTable dt2 = new DataTable();
                adp2.Fill(dt2);

                if (dt2.Rows.Count > 0)
                {
                    FillFieldsFromRow(dt2.Rows[0], "ACC");
                    dataGridViewAccountants.DataSource = dt2;
                    dataGridViewEmployees.DataSource = null;
                    return;
                }

                MessageBox.Show("No record found.");
            }
        }

        private void FillFieldsFromRow(DataRow r, string type)
        {
            selectedTable = type;

            txtId.Text = (type == "EMP") ? r["EmployeeID"].ToString() : r["AccountantID"].ToString();
            txtName.Text = r["FullName"].ToString();
            txtEmail.Text = r["Email"].ToString();
            txtGender.Text = r["Gender"].ToString();
            txtDob.Text = Convert.ToDateTime(r["DOB"]).ToString("yyyy-MM-dd");
            txtPhone.Text = r["Phone"].ToString();
            txtAddress.Text = r["Address"].ToString();
        }

        // ================= DELETE =================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || selectedTable == "")
            {
                MessageBox.Show("Please select a record first.");
                return;
            }

            DialogResult dr = MessageBox.Show(
                "This will permanently delete the record and related data. Continue?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    if (selectedTable == "EMP")
                    {
                        // ✅ DELETE LOGIN FIRST
                        new SqlCommand(
                            "DELETE FROM Users WHERE RefId=@id AND Role='Employee'",
                            conn, tran)
                        { Parameters = { new SqlParameter("@id", txtId.Text) } }
                        .ExecuteNonQuery();

                        // other related tables
                        new SqlCommand("DELETE FROM Payment WHERE EmployeeID=@id", conn, tran)
                        { Parameters = { new SqlParameter("@id", txtId.Text) } }.ExecuteNonQuery();

                        new SqlCommand("DELETE FROM Payroll WHERE EmployeeID=@id", conn, tran)
                        { Parameters = { new SqlParameter("@id", txtId.Text) } }.ExecuteNonQuery();

                        new SqlCommand("DELETE FROM Attendance WHERE UserID=@id AND UserType='Employee'", conn, tran)
                        { Parameters = { new SqlParameter("@id", txtId.Text) } }.ExecuteNonQuery();

                        new SqlCommand("DELETE FROM LeaveRequests WHERE EmployeeID=@id", conn, tran)
                        { Parameters = { new SqlParameter("@id", txtId.Text) } }.ExecuteNonQuery();

                        // main table last
                        new SqlCommand("DELETE FROM Employees_Info WHERE EmployeeID=@id", conn, tran)
                        { Parameters = { new SqlParameter("@id", txtId.Text) } }.ExecuteNonQuery();
                    }
                    else
                    {
                        // ✅ DELETE LOGIN FIRST
                        new SqlCommand(
                            "DELETE FROM Users WHERE RefId=@id AND Role='Accountant'",
                            conn, tran)
                        { Parameters = { new SqlParameter("@id", txtId.Text) } }
                        .ExecuteNonQuery();

                        new SqlCommand("DELETE FROM Accountants WHERE AccountantID=@id", conn, tran)
                        { Parameters = { new SqlParameter("@id", txtId.Text) } }.ExecuteNonQuery();
                    }

                    tran.Commit();
                    MessageBox.Show("Deleted successfully.");

                    ClearBoxes();

                    if (selectedTable == "EMP") ShowEmployees();
                    else ShowAccountants();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Delete failed: " + ex.Message);
                }
            }
        }


        // ================= BACK =================
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (callerRole == "ADMIN")
                new btnadminoperations(callerId, "").Show();
            else
                new HRManagerDashboard(callerId).Show();

            this.Hide();
        }

        // ================= ADD =================
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            RegisterForm b = new RegisterForm(callerRole, callerId);
            b.Show();
            this.Hide();
        }
    }
}
