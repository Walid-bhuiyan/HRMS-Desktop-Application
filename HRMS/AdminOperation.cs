using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HRMS
{
    public partial class AdminOperation : Form
    {
        int adminId;
        string adminEmail;

        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";

        // ✅ REQUIRED CONSTRUCTOR
        public AdminOperation(int id, string email)
        {
            InitializeComponent();
            adminId = id;
            adminEmail = email;
        }

        // ================= SHOW ADMINS =================
        private void show()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string query = "SELECT * FROM Admins";
                SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        // ================= BACK =================
        private void btnback_Click(object sender, EventArgs e)
        {
            btnadminoperations btnadmnop = new btnadminoperations(adminId, adminEmail);
            btnadmnop.Show();
            this.Close();
        }

        // ================= SHOW =================
        private void txtshow_Click(object sender, EventArgs e)
        {
            show();
        }

        // ================= INSERT =================
        private void txtinsert_Click(object sender, EventArgs e)
        {
            AdminInsertionForm admninsertion = new AdminInsertionForm(adminId, adminEmail);
            admninsertion.Show();
            this.Close();
        }

        // ================= SEARCH =================
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Please enter ID");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                string query = "SELECT * FROM Admins WHERE Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtid.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtname.Text = dr["name"].ToString();
                    txtemail.Text = dr["email"].ToString();
                    txtphone.Text = dr["phone"].ToString();
                    txtgender.Text = dr["gender"].ToString();
                    txtaddress.Text = dr["address"].ToString();
                    txtdob.Text = dr["dob"].ToString();
                }
                else
                {
                    MessageBox.Show("Admin not found!");
                }
            }
        }

        // ================= UPDATE =================
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text))
            {
                MessageBox.Show("Please select an admin first.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string checkQuery = @"SELECT COUNT(*) 
                                          FROM Users 
                                          WHERE Email=@email 
                                          AND NOT (RefId=@id AND Role='Admin')";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn, tran);
                    checkCmd.Parameters.AddWithValue("@email", txtemail.Text);
                    checkCmd.Parameters.AddWithValue("@id", txtid.Text);

                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("This email is already used by another user.");
                        tran.Rollback();
                        return;
                    }

                    string q1 = @"UPDATE Admins SET 
                                    name=@name,
                                    email=@email,
                                    phone=@phone,
                                    gender=@gender,
                                    address=@address,
                                    dob=@dob
                                  WHERE id=@id";

                    SqlCommand cmd1 = new SqlCommand(q1, conn, tran);
                    cmd1.Parameters.AddWithValue("@id", txtid.Text);
                    cmd1.Parameters.AddWithValue("@name", txtname.Text);
                    cmd1.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd1.Parameters.AddWithValue("@phone", txtphone.Text);
                    cmd1.Parameters.AddWithValue("@gender", txtgender.Text);
                    cmd1.Parameters.AddWithValue("@address", txtaddress.Text);
                    cmd1.Parameters.AddWithValue("@dob", Convert.ToDateTime(txtdob.Text));
                    cmd1.ExecuteNonQuery();

                    string q2 = @"UPDATE Users SET Email=@email 
                                  WHERE RefId=@id AND Role='Admin'";

                    SqlCommand cmd2 = new SqlCommand(q2, conn, tran);
                    cmd2.Parameters.AddWithValue("@id", txtid.Text);
                    cmd2.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd2.ExecuteNonQuery();

                    tran.Commit();
                    MessageBox.Show("✅ Admin updated successfully!");
                    show();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("❌ Update failed: " + ex.Message);
                }
            }
        }

        // ================= DELETE =================
        private void btndelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                try
                {
                    SqlCommand cmdUser = new SqlCommand(
                        "DELETE FROM Users WHERE RefId=@id AND Role='Admin'", conn);
                    cmdUser.Parameters.AddWithValue("@id", txtid.Text);
                    cmdUser.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Admins WHERE ID=@id", conn);
                    cmd.Parameters.AddWithValue("@id", txtid.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Admin deleted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    txtid.Clear(); txtname.Clear(); txtemail.Clear();
                    txtphone.Clear(); txtgender.Clear();
                    txtaddress.Clear(); txtdob.Clear();
                    show();
                }
            }
        }

        // ================= GRID CLICK =================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtgender.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtdob.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtid.Clear(); txtname.Clear(); txtemail.Clear();
            txtphone.Clear(); txtgender.Clear();
            txtaddress.Clear(); txtdob.Clear();
        }

        private void AdminOperation_Load(object sender, EventArgs e)
        {
        }
    }
}
