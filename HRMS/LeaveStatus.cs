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
        private String empID;
        private String reason;
        private String status;
        private String LeaveID;
        
        public LeaveStatus()
        {
            InitializeComponent();
        }
        private SqlConnection Connect()
        {
            string connectionString = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
        private void View ()
        {
            try
            {
               
                empID = txtId.Text; 

                
                if (empID=="")
                {
                    MessageBox.Show("Please enter your Employee ID");
                    return;
                }

                SqlConnection conn = Connect();

                
                string query = "SELECT EmployeeID,LeaveID, FromDate, ToDate, Reason, Status " +
                               "FROM LeaveRequests WHERE EmployeeID='" + empID + "'";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);

               
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No leave request has been submitted for this Employee ID");
                    dataGridView1.DataSource = null;
                }
                else
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoGenerateColumns = true;
                }

                conn.Close();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }

        private void Search ()
        {
            

            try
            {
                SqlConnection conn = Connect();

                empID = txtId.Text;
                if (empID == "")
                {
                    MessageBox.Show("Enter Your Employee ID");
                    return;
                }
                string query = "Select EmployeeID,LeaveID,FromDate,ToDate,Reason,Status FROM LeaveRequests WHERE EmployeeID='" + empID + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

                
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                   
                    if (reader.Read())
                    {
                        txtId.Text = reader["EmployeeID"].ToString();
                        txtLeaveId.Text = reader["LeaveID"].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(reader["FromDate"]);
                        dateTimePicker2.Value = Convert.ToDateTime(reader["ToDate"]);
                        richTextBox1.Text = reader["Reason"].ToString();
                        txtstatus.Text = reader["Status"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No leave record found for this Employee ID");
                    
                    txtId.Text = "";
                    txtLeaveId.Text = "";
                   
                    richTextBox1.Text = "";
                    txtstatus.Text = "";
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard();
            ed.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            View();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();   
        }

      
        private void LeaveStatus_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Text = txtLeaveId.Text =richTextBox1.Text= txtstatus.Text = "";
            dateTimePicker1.Value = dateTimePicker2.Value = DateTime.Now;
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            empID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            LeaveID = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            txtId.Text = empID;
            txtLeaveId.Text = LeaveID;

            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

            richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtstatus.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                status=txtstatus.Text;
                empID=txtId.Text;
                LeaveID=txtLeaveId.Text;

                if(txtstatus.Text.ToUpper()=="ACCEPTED")
                {
                    MessageBox.Show("No edit is possible,Leave request is accepted");
                    return;
                }

                if (empID == "" || LeaveID == "")
                {
                    MessageBox.Show("Please select a leave request first.");
                    return;
                }

                SqlConnection conn = Connect();
                reason = richTextBox1.Text;

                DateTime fromDate = Convert.ToDateTime(dateTimePicker1.Text);
                DateTime toDate = Convert.ToDateTime(dateTimePicker2.Text);


                string query = "UPDATE  LeaveRequests set EmployeeID='" + empID + "',FromDate='" + fromDate.ToString("yyyy-MM-dd") + "',ToDate='" + toDate.ToString("yyyy-MM-dd") + "',Reason='" +reason+ "' WHERE LeaveID='"+LeaveID+"' and EmployeeID='"+empID+"' ";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

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
                status = txtstatus.Text;
                empID = txtId.Text;
                LeaveID = txtLeaveId.Text;

                if (txtstatus.Text.ToUpper() == "ACCEPTED")
                {
                    MessageBox.Show("Cannot delete. Leave request is already accepted.");
                    return;
                }

                if (empID == "" || LeaveID == "")
                {
                    MessageBox.Show("Please select a leave request first.");
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this leave request?",
                                    "Confirm Delete",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }

                SqlConnection conn = Connect();

                string query = "DELETE FROM LeaveRequests WHERE LeaveID='" + LeaveID + "' AND EmployeeID='" + empID + "'";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Leave Request Deleted Successfully");

                
                btnReset_Click(null, null);
                View();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
