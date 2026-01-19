using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRMS
{
    public partial class UpdateProfile : Form
    {
        int employeeId;

        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";

        // ✅ Constructor receives employeeId
        public UpdateProfile(int id)
        {
            InitializeComponent();
            employeeId = id;
        }

        // ================= LOAD PROFILE =================
        private void LoadProfile()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    string query = @"SELECT FullName, Email, Gender, DOB, Phone, Address, Department, JobTitle
                                     FROM Employees_Info
                                     WHERE EmployeeID=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", employeeId);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtId.Text = employeeId.ToString();
                        txtName.Text = reader["FullName"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtGender.Text = reader["Gender"].ToString();
                        dateTimePickerDOB.Value = Convert.ToDateTime(reader["DOB"]);
                        txtPhone.Text = reader["Phone"].ToString();
                        richTxtadd.Text = reader["Address"].ToString();
                        txtdepartment.Text = reader["Department"].ToString();
                        txtJobtitle.Text = reader["JobTitle"].ToString();
                    }

                    reader.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message);
            }
        }

        // ================= UPDATE =================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
                {
                    MessageBox.Show("Please fill all required fields");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    string query = @"UPDATE Employees_Info SET
                                     FullName=@name,
                                     Email=@email,
                                     Gender=@gender,
                                     DOB=@dob,
                                     Phone=@phone,
                                     Address=@address,
                                     Department=@dept,
                                     JobTitle=@job
                                     WHERE EmployeeID=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@gender", txtGender.Text.Trim());
                    cmd.Parameters.AddWithValue("@dob", dateTimePickerDOB.Value);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", richTxtadd.Text.Trim());
                    cmd.Parameters.AddWithValue("@dept", txtdepartment.Text.Trim());
                    cmd.Parameters.AddWithValue("@job", txtJobtitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", employeeId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Profile updated successfully ✅");
                LoadProfile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        // ================= FORM LOAD =================
        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            txtId.Text = employeeId.ToString();
            txtId.ReadOnly = true;
            LoadProfile();
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
