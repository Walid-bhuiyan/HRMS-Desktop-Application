using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HRMS
{
    public partial class AdminOpHRManager : Form
    {
        private string name, email, phone, gender, address, securityans, pass;
        private int salary;
        private DateTime dob;

        public AdminOpHRManager()
        {
            InitializeComponent();
        }

        private void AdminOpHRManager_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            btnadminoperations btnadminop = new btnadminoperations();
            btnadminop.Show();
            this.Close();
        }

        private void btninsertmanager_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();
        }

        private void btnbackhr_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void showHRManagers()
        {
            SqlConnection conn = new SqlConnection(
                @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True");
            conn.Open();

            string query = "SELECT * FROM HRManagers";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;

            conn.Close();
        }

        private void txtshow_Click(object sender, EventArgs e)
        {
            showHRManagers();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtGender.Text = "";
            txtAddress.Text = "";
            txtDob.Text = "";
            txtSalary.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("Please enter ID");
                return;
            }

            SqlConnection conn = new SqlConnection(
                @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True"
            );
            conn.Open();

            string query = "SELECT * FROM HRManagers WHERE hrId=" + txtId.Text;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtName.Text = dr["name"].ToString();
                txtEmail.Text = dr["email"].ToString();
                txtPhone.Text = dr["phone"].ToString();
                txtGender.Text = dr["gender"].ToString();
                txtAddress.Text = dr["address"].ToString();
                txtDob.Text = dr["dob"].ToString();
                txtSalary.Text = dr["salary"].ToString();
            }
            else
            {
                MessageBox.Show("HR Manager not found!");
            }

            conn.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(
                @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True"
            );
            conn.Open();
            try
            {

                string queryUser = "DELETE FROM Users WHERE RefId=" + txtId.Text + " AND Role='HRManager'";
                SqlCommand cmdUser = new SqlCommand(queryUser, conn);
                cmdUser.ExecuteNonQuery();


                string query = "DELETE FROM HRManagers WHERE hrId=" + txtId.Text;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("HR Manager deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                txtId.Text = txtName.Text = txtEmail.Text = txtPhone.Text = txtGender.Text = txtAddress.Text = txtDob.Text = txtSalary.Text = "";
                conn.Close();
                showHRManagers();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string salary = txtSalary.Text.Trim();

            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("Please select an HR Manager first!");
                return;
            }

            if (name == "")
            {
                MessageBox.Show("Name cannot be empty!");
                return;
            }

            foreach (char c in name)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Name cannot contain numbers or special characters!");
                    return;
                }
            }

            if (email == "")
            {
                MessageBox.Show("Email cannot be empty!");
                return;
            }

            if (!AdminInsertionForm.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address!");
                return;
            }

            if (phone == "")
            {
                MessageBox.Show("Phone number cannot be empty!");
                return;
            }

            foreach (char c in phone)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Phone number must contain only digits!");
                    return;
                }
            }

            if (phone.Length < 6 || phone.Length > 15)
            {
                MessageBox.Show("Phone number must be between 6 and 15 digits!");
                return;
            }

            if (!decimal.TryParse(salary, out _))
            {
                MessageBox.Show("Salary must contain only numbers!");
                return;
            }

            SqlConnection conn = new SqlConnection(
                @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True"
            );

            conn.Open();

            try
            {
                string query = "UPDATE HRManagers SET " +
                               "name='" + txtName.Text + "', " +
                               "email='" + txtEmail.Text + "', " +
                               "phone='" + txtPhone.Text + "', " +
                               "gender='" + txtGender.Text + "', " +
                               "address='" + txtAddress.Text + "', " +
                               "dob='" + txtDob.Text + "', " +
                               "salary='" + txtSalary.Text + "' " +
                               "WHERE hrId=" + txtId.Text;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                string queryUser = "UPDATE Users SET Email='" + txtEmail.Text +
                                   "' WHERE RefId=" + txtId.Text + " AND Role='HRManager'";

                SqlCommand cmdUser = new SqlCommand(queryUser, conn);
                cmdUser.ExecuteNonQuery();

                MessageBox.Show("HR Manager updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                showHRManagers();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGender.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtDob.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtSalary.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private SqlConnection Connect()
        {
            string cs = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            return conn;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void InsertIntoHRManager()
        {
            try
            {
                SqlConnection conn = Connect();
                string hashedPass = HashPassword(pass);

                string query =
                    "INSERT INTO HRManagers (name,email,phone,gender,address,dob,salary,securityans,password) " +
                    "VALUES ('" + name + "','" + email + "','" + phone + "','" + gender + "','" +
                    address + "','" + dob + "'," + salary + ",'" + securityans + "','" + hashedPass + "'); " +
                    "SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);
                int hrId = Convert.ToInt32(cmd.ExecuteScalar());

                InsertIntoUsers(hrId, "HRManager");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("This email already exists!", "Duplicate Email",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }
        private void InsertIntoUsers(int refId, string role)
        {
            SqlConnection conn = Connect();

            string query =
                "INSERT INTO Users (RefId, Role, Email, Password, SecurityAns) " +
                "VALUES (" + refId + ",'" + role + "','" + email + "','" +
                HashPassword(pass) + "','" + securityans + "')";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }

        private void btnsubmithr_Click(object sender, EventArgs e)
        {
            lblerrorname.Text = lblerrorphone.Text = lblerroremail.Text =
            lblerrorpasswod.Text = lblerrorsecurityans.Text = lblerroraddress.Text =
            lblerrordob.Text = lblerrorgender.Text = lblerrorsalary.Text = "";

            name = textname.Text;
            email = textemail.Text;
            phone = textphone.Text;
            address = richTextBox.Text;
            securityans = textquestionans.Text;
            pass = textpass.Text;
            dob = Convert.ToDateTime(dateTimePicker.Value);

            if (rbmales.Checked) gender = "Male";
            else if (rbfemales.Checked) gender = "Female";
            else gender = "";

            bool hasError = false;

            if (string.IsNullOrWhiteSpace(name))
            {
                lblerrorname.Text = "Please enter name";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                lblerroremail.Text = "Please enter email";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                lblerrorphone.Text = "Please enter phone";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(pass))
            {
                lblerrorpasswod.Text = "Please enter password";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(securityans))
            {
                lblerrorsecurityans.Text = "Please enter security answer";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                lblerroraddress.Text = "Please enter address";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(gender))
            {
                lblerrorgender.Text = "Please select gender";
                hasError = true;
            }

            if (dob == DateTime.Today)
            {
                lblerrordob.Text = "Invalid DOB";
                hasError = true;
            }

            if (!int.TryParse(textsalary.Text, out salary))
            {
                lblerrorsalary.Text = "Salary must be numeric";
                hasError = true;
            }

            if (hasError) return;

            foreach (char c in name)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("Name can contain only letters and spaces");
                    return;
                }
            }

            if (!phone.All(char.IsDigit) || phone.Length < 6 || phone.Length > 15)
            {
                MessageBox.Show("Phone must be 6–15 digits only");
                return;
            }

            if (pass.Length < 4 || !pass.Any(c => "#@$%&*".Contains(c)))
            {
                MessageBox.Show("Password must contain a special character (#,@,$,%,&,*)");
                return;
            }

            InsertIntoHRManager();
            MessageBox.Show("HR Manager added successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            textname.Clear();
            textemail.Clear();
            textphone.Clear();
            textsalary.Clear();
            textquestionans.Clear();
            textpass.Clear();
            richTextBox.Clear();
            rbmales.Checked = rbfemales.Checked = false;
            dateTimePicker.Value = DateTime.Today;
        }
    }
}