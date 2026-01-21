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
        int employeeId;

        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";

        
        public DepartmentAndJobRule(int id)
        {
            InitializeComponent();
            employeeId = id;
        }


        private void ShowDetails()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = @"SELECT JobTitle, Department, JoinDate, EmploymentType 
                                 FROM Employees_Info 
                                 WHERE EmployeeID = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", employeeId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtId.Text = employeeId.ToString();
                    txtJobTitle.Text = reader["JobTitle"].ToString();
                    txtdepartment.Text = reader["Department"].ToString();
                    txtEmployeementType.Text = reader["EmploymentType"].ToString();
                    txtJoinDate.Text = Convert.ToDateTime(reader["JoinDate"]).ToString("dd-MM-yyyy");
                }
                else
                {
                    MessageBox.Show("Employee record not found");
                }

                reader.Close();
                conn.Close();
            }
        }

        
        private void SetReadOnly()
        {
            txtId.ReadOnly = true;
            txtJobTitle.ReadOnly = true;
            txtdepartment.ReadOnly = true;
            txtEmployeementType.ReadOnly = true;
            txtJoinDate.ReadOnly = true;
        }

        
        private void DepartmentAndJobRule_Load(object sender, EventArgs e)
        {
            ShowDetails();
            SetReadOnly();
        }

        
        private void btnback_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard(employeeId);
            ed.Show();
            this.Hide();
        }
    }
}
