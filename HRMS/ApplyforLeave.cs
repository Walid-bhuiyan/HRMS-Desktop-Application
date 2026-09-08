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
    public partial class ApplyforLeave : Form
    {
        public ApplyforLeave()
        {
            InitializeComponent();
        }
        private String empId, fromD, toD, reason;

        private SqlConnection Connect()
        {
            string connectionString = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            LeaveStatus ls= new LeaveStatus();
            ls.Show();
            this.Hide();
        }

        private void insertIntoLeaveRequest()
        {
            try
            {
                SqlConnection conn = Connect();

                
                DateTime fromDate = Convert.ToDateTime(dateTimePicker1.Text);
                DateTime toDate = Convert.ToDateTime(dateTimePicker2.Text);

               
                string query = "INSERT INTO LeaveRequests (EmployeeID, FromDate, ToDate, Reason, Status) " +
                               "VALUES('" + empId + "','" + fromDate.ToString("yyyy-MM-dd") + "','" + toDate.ToString("yyyy-MM-dd") + "','" + reason + "','Pending')";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Leave request submitted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard();
            ed.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            empId = txtId.Text;
            fromD = dateTimePicker1.Text;
            toD = dateTimePicker2.Text;
            reason = richTextBox1.Text;

            if (empId == "" || reason == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }

            if (dateTimePicker1.Value >= dateTimePicker2.Value)
            {
                MessageBox.Show("From date must be less than To date");
                return;
            }

            insertIntoLeaveRequest();  

            richTextBox1.Text = "";

        }

        
    }
}
