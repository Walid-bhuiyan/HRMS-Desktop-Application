using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRMS
{
    public partial class HR_EmployeeManagement : Form
    {
        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True;";

        public HR_EmployeeManagement()
        {
            InitializeComponent();

            // IMPORTANT: keep grids empty at start
            dataGridViewEmployees.DataSource = null;
            dataGridViewAccountants.DataSource = null;
        }

        // ================= FORM LOAD =================
        private void HR_EmployeeManagement_Load(object sender, EventArgs e)
        {
            // ❌ Do nothing here (no auto load)
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

                dataGridViewEmployees.AutoGenerateColumns = true;
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

                dataGridViewAccountants.AutoGenerateColumns = true;
                dataGridViewAccountants.DataSource = dt;
            }
        }

        // ================= SHOW BUTTONS =================
        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            ShowEmployees();
        }

        private void btnShowAccountants_Click(object sender, EventArgs e)
        {
            ShowAccountants();
        }

        // ================= GRID CLICK (EMPLOYEE) =================
        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dataGridViewEmployees.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                txtName.Text = dataGridViewEmployees.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                txtEmail.Text = dataGridViewEmployees.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtGender.Text = dataGridViewEmployees.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                txtDob.Text = Convert.ToDateTime(
                    dataGridViewEmployees.Rows[e.RowIndex].Cells["DOB"].Value).ToString("yyyy-MM-dd");
                txtPhone.Text = dataGridViewEmployees.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                txtAddress.Text = dataGridViewEmployees.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            }
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
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        // ================= NAVIGATION =================
        private void btnBack_Click(object sender, EventArgs e)
        {
            HRManagerDashboard a = new HRManagerDashboard(0);
            a.Show();
            this.Hide();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            RegisterForm b = new RegisterForm();
            b.Show();
            this.Hide();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search clicked (connect logic later)");
        }

        private void dataGridViewAccountants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;   // prevent header click crash

            DataGridViewRow row = dataGridViewAccountants.Rows[e.RowIndex];

            txtId.Text = row.Cells["AccountantID"].Value.ToString();
            txtName.Text = row.Cells["FullName"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtGender.Text = row.Cells["Gender"].Value.ToString();
            txtDob.Text = Convert.ToDateTime(row.Cells["DOB"].Value).ToString("yyyy-MM-dd");
            txtPhone.Text = row.Cells["Phone"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please select a record first.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();

                // 👉 CASE 1: Employee selected
                if (dataGridViewEmployees.Focused && dataGridViewEmployees.SelectedRows.Count > 0)
                {
                    string query = @"UPDATE Employees_Info 
                             SET FullName=@name,
                                 Email=@email,
                                 Gender=@gender,
                                 DOB=@dob,
                                 Phone=@phone,
                                 Address=@address
                             WHERE EmployeeID=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                    cmd.Parameters.AddWithValue("@dob", DateTime.Parse(txtDob.Text));
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Employee updated successfully ✅");
                    ShowEmployees();
                }

                // 👉 CASE 2: Accountant selected
                else if (dataGridViewAccountants.Focused && dataGridViewAccountants.SelectedRows.Count > 0)
                {
                    string query = @"UPDATE Accountants 
                             SET FullName=@name,
                                 Email=@email,
                                 Gender=@gender,
                                 DOB=@dob,
                                 Phone=@phone,
                                 Address=@address
                             WHERE AccountantID=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                    cmd.Parameters.AddWithValue("@dob", DateTime.Parse(txtDob.Text));
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Accountant updated successfully ✅");
                    ShowAccountants();
                }
                else
                {
                    MessageBox.Show("Please click a row from Employee list or Accountant list first.");
                }
            }

        }
    }
}
