using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HRMS
{
    public partial class AdminOpHRManager : Form
    {
        int adminId;
        string adminEmail;

        private string name, email, phone, gender, address, securityans, pass;
        private int salary;
        private DateTime dob;

        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";

        // ✅ REQUIRED CONSTRUCTOR
        public AdminOpHRManager(int id, string emailLogged)
        {
            InitializeComponent();
            adminId = id;
            adminEmail = emailLogged;
        }

        // ================= LOAD =================
        private void AdminOpHRManager_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        // ================= BACK =================
        private void btnback_Click(object sender, EventArgs e)
        {
            btnadminoperations admin = new btnadminoperations(adminId, adminEmail);
            admin.Show();
            this.Close();
        }

        // ================= SHOW PANEL =================
        private void btninsertmanager_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();
        }

        private void btnbackhr_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        // ================= SHOW HR MANAGERS =================
        private void showHRManagers()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = "SELECT * FROM HRManagers";
                SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void txtshow_Click(object sender, EventArgs e)
        {
            showHRManagers();
        }

        // ================= RESET =================
        private void btnreset_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtGender.Clear();
            txtAddress.Clear();
            txtDob.Clear();
            txtSalary.Clear();
        }

        // ================= SEARCH =================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                MessageBox.Show("Please enter ID");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string query = "SELECT * FROM HRManagers WHERE hrId=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtId.Text);

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
                else MessageBox.Show("HR Manager not found!");
            }
        }

        // ================= DELETE =================
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "") return;

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string q1 = "DELETE FROM Users WHERE RefId=@id AND Role='HRManager'";
                    string q2 = "DELETE FROM HRManagers WHERE hrId=@id";

                    SqlCommand c1 = new SqlCommand(q1, conn, tran);
                    SqlCommand c2 = new SqlCommand(q2, conn, tran);

                    c1.Parameters.AddWithValue("@id", txtId.Text);
                    c2.Parameters.AddWithValue("@id", txtId.Text);

                    c1.ExecuteNonQuery();
                    c2.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("HR Manager deleted successfully!");
                    showHRManagers();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // ================= UPDATE =================
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Select HR Manager first!");
                return;
            }

            if (!AdminInsertionForm.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid email!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string q1 = @"UPDATE HRManagers SET 
                                  name=@name,email=@email,phone=@phone,
                                  gender=@gender,address=@address,
                                  dob=@dob,salary=@salary WHERE hrId=@id";

                    SqlCommand cmd = new SqlCommand(q1, conn, tran);

                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@gender", txtGender.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@dob", txtDob.Text);
                    cmd.Parameters.AddWithValue("@salary", txtSalary.Text);
                    cmd.ExecuteNonQuery();

                    string q2 = "UPDATE Users SET Email=@e WHERE RefId=@id AND Role='HRManager'";
                    SqlCommand cmd2 = new SqlCommand(q2, conn, tran);
                    cmd2.Parameters.AddWithValue("@id", txtId.Text);
                    cmd2.Parameters.AddWithValue("@e", txtEmail.Text);
                    cmd2.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("HR Manager updated successfully!");
                    showHRManagers();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // ================= GRID CLICK =================
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow r = dataGridView1.Rows[e.RowIndex];
            txtId.Text = r.Cells[0].Value.ToString();
            txtName.Text = r.Cells[1].Value.ToString();
            txtEmail.Text = r.Cells[2].Value.ToString();
            txtPhone.Text = r.Cells[3].Value.ToString();
            txtGender.Text = r.Cells[4].Value.ToString();
            txtDob.Text = r.Cells[5].Value.ToString();
            txtAddress.Text = r.Cells[6].Value.ToString();
            txtSalary.Text = r.Cells[9].Value.ToString();
        }

        // ================= INSERT HR =================
        private string HashPassword(string p)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] b = sha.ComputeHash(Encoding.UTF8.GetBytes(p));
                return BitConverter.ToString(b).Replace("-", "").ToLower();
            }
        }

        private void InsertIntoHRManager()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string q1 = @"INSERT INTO HRManagers
                        (name,email,phone,gender,address,dob,salary,securityans,password)
                        VALUES (@n,@e,@p,@g,@a,@d,@s,@sec,@pass);
                        SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(q1, conn, tran);

                    cmd.Parameters.AddWithValue("@n", name);
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@p", phone);
                    cmd.Parameters.AddWithValue("@g", gender);
                    cmd.Parameters.AddWithValue("@a", address);
                    cmd.Parameters.AddWithValue("@d", dob);
                    cmd.Parameters.AddWithValue("@s", salary);
                    cmd.Parameters.AddWithValue("@sec", securityans);
                    cmd.Parameters.AddWithValue("@pass", HashPassword(pass));

                    int hrId = Convert.ToInt32(cmd.ExecuteScalar());

                    string q2 = @"INSERT INTO Users
                        (RefId,Role,Email,Password,SecurityAns)
                        VALUES (@id,'HRManager',@e,@p,@sec)";

                    SqlCommand cmd2 = new SqlCommand(q2, conn, tran);
                    cmd2.Parameters.AddWithValue("@id", hrId);
                    cmd2.Parameters.AddWithValue("@e", email);
                    cmd2.Parameters.AddWithValue("@p", HashPassword(pass));
                    cmd2.Parameters.AddWithValue("@sec", securityans);
                    cmd2.ExecuteNonQuery();

                    tran.Commit();
                }
                catch (SqlException ex) when (ex.Number == 2627)
                {
                    tran.Rollback();
                    MessageBox.Show("Email already exists!");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // ================= SUBMIT HR =================
        private void btnsubmithr_Click(object sender, EventArgs e)
        {
            name = textname.Text.Trim();
            email = textemail.Text.Trim();
            phone = textphone.Text.Trim();
            address = richTextBox.Text.Trim();
            securityans = textquestionans.Text.Trim();
            pass = textpass.Text.Trim();

            if (!int.TryParse(textsalary.Text, out salary))
            {
                MessageBox.Show("Salary must be numeric");
                return;
            }

            dob = dateTimePicker.Value;
            gender = rbmales.Checked ? "Male" : rbfemales.Checked ? "Female" : "";

            if (name == "" || email == "" || phone == "" || pass == "" || securityans == "" || address == "" || gender == "")
            {
                MessageBox.Show("All fields required!");
                return;
            }

            if (!AdminInsertionForm.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email!");
                return;
            }

            if (!phone.All(char.IsDigit) || phone.Length < 6 || phone.Length > 15)
            {
                MessageBox.Show("Invalid phone!");
                return;
            }

            if (pass.Length < 4 || !pass.Any(c => "#@$%&*".Contains(c)))
            {
                MessageBox.Show("Weak password!");
                return;
            }

            InsertIntoHRManager();
            MessageBox.Show("HR Manager added successfully!");
            panel1.Visible = false;
        }
    }
}
