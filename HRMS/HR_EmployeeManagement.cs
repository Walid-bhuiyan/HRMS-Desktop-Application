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
        }

        // -------------------- SHOW EMPLOYEES --------------------

        private void ShowEmployees()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = @"
                SELECT 
                    e.EmployeeID,
                    e.FullName,
                    e.Email,
                    e.Gender,
                    e.DOB,
                    e.Phone,
                    e.Address
                FROM Employees_Info e
                INNER JOIN Users u ON e.EmployeeID = u.RefId
                WHERE u.Role = 'Employee'";

                SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void HR_EmployeeManagement_Load(object sender, EventArgs e)
        {
            ShowEmployees();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowEmployees();
        }

        // -------------------- UPDATE (BOTH TABLES) --------------------

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please select an employee first.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // 🔹 Update Employees_Info
                    string q1 = @"UPDATE Employees_Info 
                                  SET FullName=@name,
                                      Email=@email,
                                      Gender=@gender,
                                      DOB=@dob,
                                      Phone=@phone,
                                      Address=@address
                                  WHERE EmployeeID=@id";

                    SqlCommand cmd1 = new SqlCommand(q1, conn, tran);

                    cmd1.Parameters.AddWithValue("@id", txtId.Text);
                    cmd1.Parameters.AddWithValue("@name", txtName.Text);
                    cmd1.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd1.Parameters.AddWithValue("@gender", txtGender.Text);
                    cmd1.Parameters.AddWithValue("@dob", txtDob.Text);
                    cmd1.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd1.Parameters.AddWithValue("@address", txtAddress.Text);

                    cmd1.ExecuteNonQuery();

                    // 🔹 Update Users
                    string q2 = @"UPDATE Users 
                                  SET Email=@email
                                  WHERE RefId=@id AND Role='Employee'";

                    SqlCommand cmd2 = new SqlCommand(q2, conn, tran);
                    cmd2.Parameters.AddWithValue("@id", txtId.Text);
                    cmd2.Parameters.AddWithValue("@email", txtEmail.Text);

                    cmd2.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("✅ Employee updated successfully!");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("❌ Update failed: " + ex.Message);
                }
            }

            ShowEmployees();
        }

        // -------------------- DELETE (HARD DELETE BOTH TABLES) --------------------

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please select an employee first.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to permanently delete this employee?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // 🔹 1. Delete from Users
                    string q1 = "DELETE FROM Users WHERE RefId=@id AND Role='Employee'";
                    SqlCommand cmd1 = new SqlCommand(q1, conn, tran);
                    cmd1.Parameters.AddWithValue("@id", txtId.Text.Trim());
                    cmd1.ExecuteNonQuery();

                    // 🔹 2. Delete from Employees_Info
                    string q2 = "DELETE FROM Employees_Info WHERE EmployeeID=@id";
                    SqlCommand cmd2 = new SqlCommand(q2, conn, tran);
                    cmd2.Parameters.AddWithValue("@id", txtId.Text.Trim());
                    cmd2.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("✅ Employee deleted successfully!");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("❌ Delete failed: " + ex.Message);
                }
            }

            ClearBoxes();
            ShowEmployees();
        }

        // -------------------- SEARCH --------------------

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please enter Employee ID");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = @"
                SELECT e.*
                FROM Employees_Info e
                INNER JOIN Users u ON e.EmployeeID = u.RefId
                WHERE e.EmployeeID = @id AND u.Role='Employee'";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtId.Text.Trim());

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtName.Text = dr["FullName"].ToString();
                    txtEmail.Text = dr["Email"].ToString();
                    txtGender.Text = dr["Gender"].ToString();
                    txtDob.Text = Convert.ToDateTime(dr["DOB"]).ToString("yyyy-MM-dd");
                    txtPhone.Text = dr["Phone"].ToString();
                    txtAddress.Text = dr["Address"].ToString();
                }
                else
                {
                    MessageBox.Show("Employee not found!");
                    ClearBoxes();
                }
            }
        }

        // -------------------- GRID CLICK --------------------

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtGender.Text = dataGridView1.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                txtDob.Text = Convert.ToDateTime(
                    dataGridView1.Rows[e.RowIndex].Cells["DOB"].Value
                ).ToString("yyyy-MM-dd");
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            }
        }

        // -------------------- CLEAR --------------------

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

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

        // -------------------- NAVIGATION --------------------

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
    }
}
