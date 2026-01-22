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
    public partial class AttendanceRecord : Form
    {
        private int employeeId;
        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";
        public AttendanceRecord(int id)
        {
            InitializeComponent();
            employeeId = id;
        }
        private void btnShow_Click_1(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string query = @"SELECT Status
                         FROM Attendance
                         WHERE UserId = @id
                         AND AttendanceDate = @date";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", employeeId);
                cmd.Parameters.AddWithValue("@date", selectedDate);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    txtAttendanceStatus.Text = result.ToString();
                }
                else
                {
                    txtAttendanceStatus.Text = "No record found";
                }
            }
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard(employeeId);
            ed.Show();
            this.Hide();
        }
        private void AttendanceRecord_Load(object sender, EventArgs e)
        {
            txtId.Text = employeeId.ToString();
            txtId.ReadOnly = true;
            txtAttendanceStatus.ReadOnly = true;

            dateTimePicker1.Value = DateTime.Today;
        }
    }
}
