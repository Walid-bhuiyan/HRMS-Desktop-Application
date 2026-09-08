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

namespace HRMS
{
    public partial class DepartmentAndJobRule : Form
    {
        private String empID;
        public DepartmentAndJobRule()
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

        private void showDetails()
        {
            try
            {
                empID = txtId.Text;

                if (empID == "")
                {
                    MessageBox.Show("Please enter Employee ID");
                    return;
                }

                SqlConnection conn = Connect();

                string query =
                    "SELECT JobTitle, Department, JoinDate, EmploymentType " +
                    "FROM Employees_Info WHERE EmployeeID='" + empID + "'";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtJobTitle.Text = reader["JobTitle"].ToString();
                    txtdepartment.Text = reader["Department"].ToString();
                    txtEmployeementType.Text = reader["EmploymentType"].ToString();
                    txtJoinDate.Text = Convert.ToDateTime(reader["JoinDate"]).ToString("dd-MM-yyyy");
                }
                else
                {
                    MessageBox.Show("Employee record not found");

                    txtJobTitle.Text = "";
                    txtdepartment.Text = "";
                    txtEmployeementType.Text = "";
                    txtJoinDate.Text = "";
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void setReadOnly()
        {
            txtJobTitle.ReadOnly = true;
            txtdepartment.ReadOnly = true;
            txtEmployeementType.ReadOnly = true;
            txtJoinDate.ReadOnly = true;
        }


        private void btnback_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard();
            ed.Show();
            this.Hide();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            showDetails();
            setReadOnly();
        }
    }
}
