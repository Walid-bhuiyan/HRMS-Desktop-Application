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
    public partial class SalaryDetails : Form
    {
        private string empID;

        public SalaryDetails()
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

        private void showSalary()
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

               
                string query = "SELECT Salary FROM Employees_Info WHERE EmployeeID='" + empID + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

               
                if (reader.Read())
                {
                    txtSalary.Text = reader["Salary"].ToString();
                }
                else
                {
                    MessageBox.Show("Salary record not found");
                    txtSalary.Text = "";
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
            txtSalary.ReadOnly = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showSalary();
            setReadOnly();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard();
            ed.Show();
            this.Hide();
        }
    }
}
