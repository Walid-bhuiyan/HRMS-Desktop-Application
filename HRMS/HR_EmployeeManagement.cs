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


namespace HRMS
{
    public partial class HR_EmployeeManagement : Form
    {
        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True;";

        public HR_EmployeeManagement()
        {
            InitializeComponent();
        }

        private void ShowEmployees()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = "SELECT EmployeeID, FullName, Email, Gender, DOB, Phone, Address FROM Employees_Info";
                SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowEmployees();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
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
                cmd.Parameters.AddWithValue("@dob", txtDob.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Employee updated successfully!");
            ShowEmployees();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please enter Employee ID to delete");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this employee?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = "DELETE FROM Employees_Info WHERE EmployeeID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtId.Text.Trim());

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    MessageBox.Show("✅ Employee deleted successfully");
                else
                    MessageBox.Show("❌ No employee found with this ID");
            }

            ClearBoxes();
            ShowEmployees();
        }


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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please enter Employee ID");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = "SELECT * FROM Employees_Info WHERE EmployeeID = @id";
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            HRManagerDashboard a = new HRManagerDashboard();
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
