using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace HRMS
{
    public partial class AdminOperation : Form
    {
        public AdminOperation()
        {
            InitializeComponent();
        }

        private void show()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True");
            conn.Open();
            string query = "SELECT * FROM Admins";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtinsert_Click(object sender, EventArgs e)
        {
            AdminInsertionForm admninsertion = new AdminInsertionForm();
            admninsertion.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void txtshow_Click(object sender, EventArgs e)
        {
            show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            btnadminoperations btnadmnop = new btnadminoperations();
            btnadmnop.Show();
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtid.Text))
            {
                MessageBox.Show("Please select an admin first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Name cannot be empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("Email cannot be empty.");
                return;
            }

            if (!AdminInsertionForm.IsValidEmail(txtemail.Text))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(
                @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True"))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // 🔍 STEP 1: Check duplicate email (except this admin)
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

                    // 🔹 STEP 2: Update Admins
                    string q1 = @"UPDATE Admins
                          SET name=@name,
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

                    // 🔹 STEP 3: Update Users
                    string q2 = @"UPDATE Users 
                          SET Email=@email
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






        private void btnreset_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            txtemail.Text = "";
            txtphone.Text = "";
            txtgender.Text = "";
            txtaddress.Text = "";
            txtdob.Text = "";

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Please enter ID");
                return;
            }

            SqlConnection conn = new SqlConnection(
                @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True"
            );
            conn.Open();

            string query = "SELECT * FROM Admins WHERE Id=" + txtid.Text + "";
            SqlCommand cmd = new SqlCommand(query, conn);
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

            conn.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True");
            conn.Open();
            try
            {
                string queryUser = "DELETE FROM Users WHERE RefId=" + txtid.Text + " AND Role='Admin'";
                SqlCommand cmdUser = new SqlCommand(queryUser, conn);
                cmdUser.ExecuteNonQuery();

                string query = "DELETE FROM Admins WHERE ID=" + txtid.Text;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Admin deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                txtid.Text = txtname.Text = txtemail.Text = txtphone.Text = txtgender.Text = txtaddress.Text = txtdob.Text = "";
                conn.Close();
                show();
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtgender.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtaddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtdob.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}