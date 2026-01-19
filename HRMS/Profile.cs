using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRMS
{
    public partial class Profile : Form
    {
        int employeeId;

        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";

        // ✅ Constructor must receive employeeId
        public Profile(int id)
        {
            InitializeComponent();
            employeeId = id;
        }

        // ================= LOAD PROFILE =================
        private void ShowProfile()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = @"SELECT EmployeeID, FullName, Email, Gender, DOB, Phone, Address, Department, JobTitle 
                                 FROM Employees_Info 
                                 WHERE EmployeeID = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", employeeId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = reader["EmployeeID"].ToString();
                    txtName.Text = reader["FullName"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtGender.Text = reader["Gender"].ToString();
                    txtDob.Text = Convert.ToDateTime(reader["DOB"]).ToString("yyyy-MM-dd");
                    txtPhone.Text = reader["Phone"].ToString();
                    richTxtadd.Text = reader["Address"].ToString();
                    txtdepartment.Text = reader["Department"].ToString();
                    txtJobtitle.Text = reader["JobTitle"].ToString();
                }

                conn.Close();
            }
        }

        // ================= READ ONLY =================
        private void SetReadOnly()
        {
            txtId.ReadOnly = true;
            txtName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtGender.ReadOnly = true;
            txtDob.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtJobtitle.ReadOnly = true;
            richTxtadd.ReadOnly = true;
            txtdepartment.ReadOnly = true;
        }

        // ================= FORM LOAD =================
        private void Profile_Load(object sender, EventArgs e)
        {
            ShowProfile();
            SetReadOnly();
        }

        // ================= BACK =================
        private void btnback_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard(employeeId);
            ed.Show();
            this.Hide();
        }
    }
}
