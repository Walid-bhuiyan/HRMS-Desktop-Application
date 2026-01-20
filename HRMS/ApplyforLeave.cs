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
        // 🔒 logged-in employee id
        private int employeeId;

        // old variables (kept structure)
        private string reason;

        // ================= DEFAULT =================
        public ApplyforLeave()
        {
            InitializeComponent();
        }

        // ================= EMPLOYEE CONSTRUCTOR =================
        public ApplyforLeave(int id)
        {
            InitializeComponent();
            employeeId = id;
        }

        private SqlConnection Connect()
        {
            string connectionString = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        private void ApplyforLeave_Load(object sender, EventArgs e)
        {
            // ✅ auto set employee id & lock it
            txtId.Text = employeeId.ToString();
            txtId.ReadOnly = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            LeaveStatus ls = new LeaveStatus(employeeId);
            ls.Show();
            this.Hide();
        }

        private void insertIntoLeaveRequest()
        {
            try
            {
                using (SqlConnection conn = Connect())
                {
                    string query = @"INSERT INTO LeaveRequests 
                                    (EmployeeID, FromDate, ToDate, Reason, Status) 
                                     VALUES (@id, @from, @to, @reason, 'Pending')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", employeeId);
                    cmd.Parameters.AddWithValue("@from", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@to", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@reason", reason);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Leave request submitted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard(employeeId);
            ed.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            reason = richTextBox1.Text.Trim();

            if (reason == "")
            {
                MessageBox.Show("Reason is required");
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
