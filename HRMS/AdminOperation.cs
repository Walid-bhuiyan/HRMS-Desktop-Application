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
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GC7C78E;Initial Catalog=hrmsDB;Integrated Security=True;");
            conn.Open();
            string query = "SELECT * FROM Admins";
            SqlCommand cmd= new SqlCommand(query, conn);
            SqlDataAdapter adp= new SqlDataAdapter(cmd);
            DataSet ds= new DataSet();
            adp.Fill(ds);
            DataTable dt= ds.Tables[0];
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
            AdminInsertionForm admninsertion= new AdminInsertionForm();
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
            btnadminoperations btnadmnop= new btnadminoperations();
            btnadmnop.Show();
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.Trim();
            string email = txtemail.Text.Trim();
            string phone = txtphone.Text.Trim();

            if (txtid.Text.Trim() == "")
            {
                MessageBox.Show("Please select an admin first!");
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

            SqlConnection conn = new SqlConnection(
                @"Data Source=DESKTOP-GC7C78E;Initial Catalog=hrmsDB;Integrated Security=True;"
            );

            conn.Open();

            try
            {
                string query = "UPDATE Admins SET " +
                               "name='" + txtname.Text + "', " +
                               "email='" + txtemail.Text + "', " +
                               "phone='" + txtphone.Text + "', " +
                               "gender='" + txtgender.Text + "', " +
                               "address='" + txtaddress.Text + "', " +
                               "dob='" + txtdob.Text + "' " +
                               "WHERE id=" + txtid.Text;

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                string queryUser = "UPDATE Users SET Email='" + txtemail.Text +
                                   "' WHERE RefId=" + txtid.Text + " AND Role='Admin'";

                SqlCommand cmdUser = new SqlCommand(queryUser, conn);
                cmdUser.ExecuteNonQuery();

                MessageBox.Show("Admin updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                show();
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
                @"Data Source=DESKTOP-GC7C78E;Initial Catalog=hrmsDB;Integrated Security=True;"
            );
            conn.Open();

            string query = "SELECT * FROM Admins WHERE id=" + txtid.Text + "";
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
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GC7C78E;Initial Catalog=hrmsDB;Integrated Security=True;");
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
