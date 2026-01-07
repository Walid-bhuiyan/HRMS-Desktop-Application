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
    public partial class salaryManagement : Form
    {
        private string empid, bSalary, bonus, deduction;
        private DateTime payDate;


        public salaryManagement()
        {
            InitializeComponent();
        }

        private SqlConnection Connect()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=HRMS_DB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        private void InsertEmployeeInfo()
        {
            using (SqlConnection conn = Connect())
            {
                string query = "INSERT INTO dbo.Salary(EmployeeID, BasicSalary, Bonus, Deduction, PayDate) " +
                               "VALUES('"+empid+"','"+bSalary+"','"+bonus+"','"+deduction+"','"+payDate+"')";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                txtempid.Text = txtbasicsalary.Text = txtbonus.Text = txtdeduction.Text = "";
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            empid = txtempid.Text;
            bSalary = txtbasicsalary.Text;
            bonus = txtbonus.Text;
            deduction = txtdeduction.Text;
            payDate = Convert.ToDateTime(dtppaydate.Text);


            InsertEmployeeInfo();
        }

        private void show()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=HRMS_DB;Integrated Security=True;");
            conn.Open();
            string query = "select * from Salary";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            show();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=HRMS_DB;Integrated Security=True;");
            conn.Open();
            string query = "update Salary set " + "BasicSalary = '" + txtbasicsalary.Text + "', " + "Bonus = '" + txtbonus.Text + "', " + "Deduction = '" + txtdeduction.Text + "' " + "WHERE EmployeeID = '" + txtempid.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            
            txtempid.Text =  txtbasicsalary.Text = txtbonus.Text = txtdeduction.Text = "";
            show();
            conn.Close();
        }

        private void salaryManagement_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtempid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbasicsalary.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtbonus.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtdeduction.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=HRMS_DB;Integrated Security=True;");
            conn.Open();
            string query = "delete from Salary WHERE EmployeeID = " + txtempid.Text;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            txtempid.Text = txtbasicsalary.Text = txtbonus.Text = txtdeduction.Text = "";
            show();
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountantDashboard ad = new AccountantDashboard();
            ad.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
