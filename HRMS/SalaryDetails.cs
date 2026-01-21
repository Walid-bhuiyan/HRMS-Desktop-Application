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
        
        private int employeeId;

        
        public SalaryDetails()
        {
            InitializeComponent();
        }

        
        public SalaryDetails(int id)
        {
            InitializeComponent();
            employeeId = id;
        }

        
        private SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(
                @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True");
            conn.Open();
            return conn;
        }

        
        private void SalaryDetails_Load(object sender, EventArgs e)
        {
            if (employeeId != 0)
            {
                txtId.Text = employeeId.ToString();
            }
            else
            {
                
                if (txtId.Text != "")
                {
                    employeeId = Convert.ToInt32(txtId.Text);
                }
            }

            txtId.ReadOnly = true;

            
            

            if (employeeId != 0)
            {
                showSalary();
            }

            setReadOnly();
        }

        
        private void showSalary()
        {
            try
            {
                using (SqlConnection conn = Connect())
                {
                    string query = @"SELECT Salary, HouseRent, Medical, Transport, TotalSalary 
                             FROM SalaryManagement 
                             WHERE EmployeeID = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", employeeId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtSalary.Text = reader["Salary"].ToString();
                        txtHouseRent.Text = reader["HouseRent"].ToString();
                        txtMedical.Text = reader["Medical"].ToString();
                        txtTransport.Text = reader["Transport"].ToString();
                        txtTotalSalary.Text = reader["TotalSalary"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Salary details not found.");
                        txtSalary.Clear();
                        txtHouseRent.Clear();
                        txtMedical.Clear();
                        txtTransport.Clear();
                        txtTotalSalary.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        
        private void setReadOnly()
        {
            txtSalary.ReadOnly = true;
            txtId.ReadOnly = true;
        }

        
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (employeeId == 0 && txtId.Text != "")
            {
                employeeId = Convert.ToInt32(txtId.Text);
            }

            if (employeeId == 0)
            {
                MessageBox.Show("Employee ID not found.");
                return;
            }

            showSalary();
        }

        
        private void btnback_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard(employeeId);
            ed.Show();
            this.Hide();
        }
    }
}
