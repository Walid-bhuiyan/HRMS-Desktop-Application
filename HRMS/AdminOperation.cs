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
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GC7C78E;Initial Catalog=hrmsDB;Integrated Security=True;");
            conn.Open();
            string query = "UPDATE Admins SET name='"+txtname.Text+"', email='"+txtemail.Text+"', phone='"+txtphone.Text+"',gender='"+txtgender.Text+"', address='"+txtgender.Text+"', dob='"+txtdob.Text+"' WHERE id="+txtid.Text+" ";
            SqlCommand cmd= new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            show();
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
            string query = "Delete from Admins where ID=" + txtid.Text;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            txtid.Text = txtname.Text = txtemail.Text = "";
            show();
            conn.Close();
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
    }
}
