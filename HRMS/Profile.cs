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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void showProfile()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True");        
           
            int employeeID= 1002;
            String query= @"SELECT EmployeeID,FullName, Email, Gender, DOB, Phone, Address, Department, JobTitle FROM Employees_Info WHERE EmployeeID = @id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", employeeID);
            conn.Open();

            SqlDataReader reader=cmd.ExecuteReader();

            if (reader.Read())
            {
                txtId.Text=reader["EmployeeID"].ToString();
                txtName.Text = reader["FullName"].ToString();
                txtEmail.Text=reader["Email"].ToString();
                txtGender.Text=reader["Gender"].ToString();
                txtDob.Text = Convert.ToDateTime(reader["DOB"]).ToString("dd-MM-yyyy");
                txtPhone.Text = reader["Phone"].ToString();
                richTxtadd.Text = reader["Address"].ToString();
                txtdepartment.Text = reader["Department"].ToString();
                txtJobtitle.Text = reader["JobTitle"].ToString();

            }
          conn.Close();

        }

        private void setReadOnly()
        {
            txtId.ReadOnly = true;
            txtName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtGender.ReadOnly = true;
            txtDob.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtJobtitle.ReadOnly = true;
            richTxtadd.ReadOnly = true;
        }

   
        private void btnback_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard();
            ed.Show();
            this.Hide();
        }

      
        private void Profile_Load(object sender, EventArgs e)
        {
            showProfile();
            setReadOnly();
        }

        private void txtDob_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
