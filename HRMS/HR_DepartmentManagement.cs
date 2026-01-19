using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRMS
{
    public partial class HR_DepartmentManagement : Form
    {
        // ✅ Connection string (same style as your project)
        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True;";

        public HR_DepartmentManagement()
        {
            InitializeComponent();
        }

        // ================= FORM LOAD =================

        private void HR_DepartmentManagement_Load(object sender, EventArgs e)
        {
            // Do nothing on load (data will show only when clicking Show)
        }

        // ================= SHOW =================

        private void ShowDepartments()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "SELECT DepartmentID, DepartmentName FROM Departments";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridViewDepartments.DataSource = dt;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowDepartments();
        }

        // ================= ADD =================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDeptName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter department name!");
                return;
            }

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "INSERT INTO Departments (DepartmentName) VALUES (@name)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtDeptName.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("✅ Department added successfully!");
            ClearBoxes();
            ShowDepartments();
        }

        // ================= GRID CLICK =================

        private void dataGridViewDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtDeptId.Text = dataGridViewDepartments.Rows[e.RowIndex]
                                    .Cells["DepartmentID"].Value.ToString();

                txtDeptName.Text = dataGridViewDepartments.Rows[e.RowIndex]
                                    .Cells["DepartmentName"].Value.ToString();
            }
        }

        // ================= UPDATE =================

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtDeptId.Text == "")
            {
                MessageBox.Show("Please select a department first!");
                return;
            }

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "UPDATE Departments SET DepartmentName=@name WHERE DepartmentID=@id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", txtDeptId.Text);
                cmd.Parameters.AddWithValue("@name", txtDeptName.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("✅ Department updated!");
            ClearBoxes();
            ShowDepartments();
        }

        // ================= DELETE =================

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDeptId.Text == "")
            {
                MessageBox.Show("Please select a department first!");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this department?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "DELETE FROM Departments WHERE DepartmentID=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtDeptId.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Department deleted!");
            ClearBoxes();
            ShowDepartments();
        }

        // ================= CLEAR =================

        private void ClearBoxes()
        {
            txtDeptId.Clear();
            txtDeptName.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        // ================= BACK =================

        private void btnBack_Click(object sender, EventArgs e)
        {
            HRManagerDashboard h = new HRManagerDashboard(0);
            h.Show();
            this.Hide();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            HRManagerDashboard hd=new HRManagerDashboard(0);
            hd.Show();
            this.Hide();
        }
    }
}
