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
    public partial class View_Employee : Form
    {
        public View_Employee()
        {
            InitializeComponent();
        }
        private void show()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost\MSSQLSERVER01;
                         Initial Catalog=HRMS_DB;
                         Integrated Security=True;");
            conn.Open();
            string query = "SELECT * FROM Employees_Info";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost\MSSQLSERVER01;
                         Initial Catalog=HRMS_DB;
                         Integrated Security=True;");
            conn.Open();
            string query = "UPDATE Employees_Info SET FullName='" + txtName.Text +
               "', Email='" + txtEmail.Text +
               "', Address='" + txtAdress.Text +
               "' WHERE EmployeeId=" + txtID.Text + " "; 
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtAdress.Text = row.Cells[6].Value.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost\MSSQLSERVER01;
                         Initial Catalog=HRMS_DB;
                         Integrated Security=True;");
            conn.Open();
            string query = "Delete from Employees_Info where EmployeeID=" + txtID.Text;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            //conn.Close();
            txtID.Text = txtName.Text = txtEmail.Text = "";
            show();
            conn.Close();

        }
    }
}
