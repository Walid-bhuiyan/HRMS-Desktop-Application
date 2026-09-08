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
using System.Xml.Linq;

namespace HRMS
{
    public partial class UpdateProfile : Form
    {
        private string empID;
        private string name;
        private string email;
        private string gender;
        private string phone;
        private string address;
        private string department;
        private string job;

        public UpdateProfile()
        {
            InitializeComponent();
        }

        private SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(
                @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True");
            conn.Open();
            return conn;
        }

        private void LoadProfile()
        {
            try
            {
                empID = txtId.Text;

                if (empID == "")
                {
                    MessageBox.Show("Employee ID not found");
                    return;
                }

                SqlConnection conn = Connect();

                string query = "SELECT * FROM Employees_Info WHERE EmployeeID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", empID);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            
            txtId.Text = "1002";
            LoadProfile();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                empID = txtId.Text;
                name = txtName.Text;
                email = txtEmail.Text;
                gender = txtGender.Text;
                phone = txtPhone.Text;
                address = richTxtadd.Text;
                department = txtdepartment.Text;
                job = txtJobtitle.Text;

               
                if (name == "" || email == "" || gender == "" || phone == "")
                {
                    MessageBox.Show("Please fill all required fields");
                    return;
                }

                if (!email.EndsWith("@gmail.com"))
                {
                    MessageBox.Show("Email must be a valid Gmail address");
                    return;
                }

                if (phone.Length < 11)
                {
                    MessageBox.Show("Phone number must be at least 11 digits");
                    return;
                }

                SqlConnection conn = Connect();

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
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@dob", dateTimePickerDOB.Value);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@dept", department);
                cmd.Parameters.AddWithValue("@job", job);
                cmd.Parameters.AddWithValue("@id", empID);

                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Profile updated successfully");
                LoadProfile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard();
            ed.Show();
            this.Hide();
        }
    }
}
