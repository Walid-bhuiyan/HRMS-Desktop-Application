using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRMS
{
    public partial class HR_LeaveManagement : Form
    {
        // ✅ your real database
        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True;";

        int hrId;

        public HR_LeaveManagement(int id)
        {
            InitializeComponent();
            hrId = id;
        }

        // ================= FORM LOAD =================
        private void HR_LeaveManagement_Load(object sender, EventArgs e)
        {
            //LoadLeaves();
            ClearFields();
        }

        // ================= VIEW ALL =================
        private void btnView_Click(object sender, EventArgs e)
        {
            LoadLeaves();
        }

        private void LoadLeaves()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "SELECT LeaveID, EmployeeID, FromDate, ToDate, Reason, Status FROM LeaveRequests ORDER BY LeaveID DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewLeaves.DataSource = dt;
            }
        }

        // ================= GRID CLICK =================
        private void dataGridViewLeaves_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewLeaves.Rows[e.RowIndex];

                txtLeaveID.Text = row.Cells["LeaveID"].Value.ToString();
                txtEmployeeID.Text = row.Cells["EmployeeID"].Value.ToString();
                dtFrom.Value = Convert.ToDateTime(row.Cells["FromDate"].Value);
                dtTo.Value = Convert.ToDateTime(row.Cells["ToDate"].Value);
                txtReason.Text = row.Cells["Reason"].Value.ToString();
                txtStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        // ================= SEARCH =================
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtLeaveID.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Leave ID.");
                return;
            }

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = @"SELECT LeaveID, EmployeeID, FromDate, ToDate, Reason, Status 
                         FROM LeaveRequests 
                         WHERE LeaveID = @lid";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@lid", txtLeaveID.Text.Trim());

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtLeaveID.Text = dr["LeaveID"].ToString();
                    txtEmployeeID.Text = dr["EmployeeID"].ToString();
                    dtFrom.Value = Convert.ToDateTime(dr["FromDate"]);
                    dtTo.Value = Convert.ToDateTime(dr["ToDate"]);
                    txtReason.Text = dr["Reason"].ToString();
                    txtStatus.Text = dr["Status"].ToString();
                }
                else
                {
                    MessageBox.Show("No leave request found with this Leave ID.");
                    ClearFields();
                }
            }
        }


        // ================= APPROVE =================
        private void btnApprove_Click(object sender, EventArgs e)
        {
            ChangeStatus("Approved");
        }

        // ================= REJECT =================
        private void btnReject_Click(object sender, EventArgs e)
        {
            ChangeStatus("Rejected");
        }

        private void ChangeStatus(string newStatus)
        {
            if (txtLeaveID.Text == "")
            {
                MessageBox.Show("Please select a leave request first.");
                return;
            }

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "UPDATE LeaveRequests SET Status=@st WHERE LeaveID=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@st", newStatus);
                cmd.Parameters.AddWithValue("@id", txtLeaveID.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Leave " + newStatus + " successfully.");
            LoadLeaves();
            ClearFields();
        }

        // ================= RESET =================
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtLeaveID.Clear();
            txtEmployeeID.Clear();
            txtReason.Clear();
            txtStatus.Clear();
            dtFrom.Value = DateTime.Now;
            dtTo.Value = DateTime.Now;
        }

        // ================= BACK =================
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HRManagerDashboard hd = new HRManagerDashboard(hrId);
            hd.Show();
        }
    }
}
