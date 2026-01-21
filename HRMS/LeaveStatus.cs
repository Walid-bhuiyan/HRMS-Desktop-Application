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
    public partial class LeaveStatus : Form
    {
        private int employeeId;
        private string reason, status, LeaveID;

        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";

        
        public LeaveStatus()
        {
            InitializeComponent();
        }

        
        public LeaveStatus(int id)
        {
            InitializeComponent();
            employeeId = id;
        }

        private SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            return conn;
        }

        
        private void LeaveStatus_Load(object sender, EventArgs e)
        {
            if (employeeId == 0)
            {
                MessageBox.Show("Session error: Employee not logged in.");
                this.Close();
                return;
            }

            txtId.Text = employeeId.ToString();
            txtId.ReadOnly = true;

            dataGridView1.DataSource = null; 
        }


        
        private void View()
        {
            try
            {
                using (SqlConnection conn = Connect())
                {
                    string query = @"SELECT EmployeeID, LeaveID, FromDate, ToDate, Reason, Status
                                     FROM LeaveRequests 
                                     WHERE EmployeeID = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", employeeId);

                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }

        
        private void Search()
        {
            if (txtLeaveId.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Leave ID to search.");
                return;
            }
            try
            {
                using (SqlConnection conn = Connect())
                {
                    string query = @"SELECT EmployeeID, LeaveID, FromDate, ToDate, Reason, Status 
                                     FROM LeaveRequests 
                                     WHERE EmployeeID=@id AND LeaveID=@leaveId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", employeeId);
                    cmd.Parameters.AddWithValue("@leaveId", txtLeaveId.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtId.Text = reader["EmployeeID"].ToString();
                        txtLeaveId.Text = reader["LeaveID"].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(reader["FromDate"]);
                        dateTimePicker2.Value = Convert.ToDateTime(reader["ToDate"]);
                        richTextBox1.Text = reader["Reason"].ToString();
                        txtstatus.Text = reader["Status"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No leave record found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLeaveId.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtstatus.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtstatus.Text.ToUpper() != "PENDING")
                {
                    MessageBox.Show("You can only edit leave when status is Pending.");
                    return;
                }


                using (SqlConnection conn = Connect())
                {
                    string query = @"UPDATE LeaveRequests 
                                     SET FromDate=@from, ToDate=@to, Reason=@reason 
                                     WHERE LeaveID=@leaveId AND EmployeeID=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@from", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@to", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@reason", richTextBox1.Text);
                    cmd.Parameters.AddWithValue("@leaveId", txtLeaveId.Text);
                    cmd.Parameters.AddWithValue("@id", employeeId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Leave Request Updated");
                View();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtstatus.Text.ToUpper() != "PENDING")
                {
                    MessageBox.Show("You can only delete leave when status is Pending.");
                    return;
                }

                if (MessageBox.Show("Are you sure?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;

                using (SqlConnection conn = Connect())
                {
                    string query = "DELETE FROM LeaveRequests WHERE LeaveID=@leaveId AND EmployeeID=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@leaveId", txtLeaveId.Text);
                    cmd.Parameters.AddWithValue("@id", employeeId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Leave deleted");
                btnReset_Click(null, null);
                View();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLeaveId.Text = richTextBox1.Text = txtstatus.Text = "";
            dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Now;
            dataGridView1.DataSource = null;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            View();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard(employeeId);
            ed.Show();
            this.Hide();
        }
    }
}
