using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRMS
{
    public partial class HR_ComplaintManagement : Form
    {
        int hrId;
        string conStr = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";

        public HR_ComplaintManagement(int hrId)
        {
            InitializeComponent();
            this.hrId = hrId;
        }

        private void HR_ComplaintManagement_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("In Progress");
            cmbStatus.Items.Add("Resolved");
            cmbStatus.Items.Add("Rejected");
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            txtUserId.ReadOnly = true;
            txtSubject.ReadOnly = true;
            txtDescription.ReadOnly = true;
            dtSubmittedAt.Enabled = false;

            dataGridViewComplaints.DataSource = null;
            ClearFields();
        }

        private void ShowAllComplaints()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string q = @"SELECT ComplaintId, UserId, UserType, Subject, Description, Status, SubmittedAt FROM Complaints ORDER BY SubmittedAt DESC";

                SqlDataAdapter adp = new SqlDataAdapter(q, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridViewComplaints.DataSource = dt;
            }
        }
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllComplaints();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtComplaintId.Text.Trim() == "")
            {
                MessageBox.Show("Enter Complaint ID.");
                return;
            }

            if (!int.TryParse(txtComplaintId.Text.Trim(), out int cid))
            {
                MessageBox.Show("Complaint ID must be numeric.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string q = @"SELECT ComplaintId, UserId, UserType, Subject, Description, Status, SubmittedAt FROM Complaints WHERE ComplaintId=@id";

                SqlDataAdapter adp = new SqlDataAdapter(q, conn);
                adp.SelectCommand.Parameters.AddWithValue("@id", cid);

                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No complaint found.");
                    ClearFields();
                    dataGridViewComplaints.DataSource = null;
                    return;
                }

                dataGridViewComplaints.DataSource = dt;

                DataRow r = dt.Rows[0];
                txtComplaintId.Text = r["ComplaintId"].ToString();
                txtUserId.Text = r["UserId"].ToString();
                txtSubject.Text = r["Subject"].ToString();
                txtDescription.Text = r["Description"].ToString();
                cmbStatus.Text = r["Status"].ToString();
                dtSubmittedAt.Value = Convert.ToDateTime(r["SubmittedAt"]);
            }
        }

        private void dataGridViewComplaints_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dataGridViewComplaints.Rows[e.RowIndex];
            txtComplaintId.Text = row.Cells["ComplaintId"].Value.ToString();
            txtUserId.Text = row.Cells["UserId"].Value.ToString();
            txtSubject.Text = row.Cells["Subject"].Value.ToString();
            txtDescription.Text = row.Cells["Description"].Value.ToString();
            cmbStatus.Text = row.Cells["Status"].Value.ToString();
            dtSubmittedAt.Value = Convert.ToDateTime(row.Cells["SubmittedAt"].Value);
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (txtComplaintId.Text == "")
            {
                MessageBox.Show("Select a complaint first.");
                return;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Select a status.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string q = @"UPDATE Complaints 
                             SET Status=@st 
                             WHERE ComplaintId=@id";

                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@st", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@id", txtComplaintId.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Status updated successfully.");
            ShowAllComplaints();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtComplaintId.Text == "")
            {
                MessageBox.Show("Select a complaint first.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this complaint?",
                "Confirm", MessageBoxButtons.YesNo) == DialogResult.No) return;

            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string q = "DELETE FROM Complaints WHERE ComplaintId=@id";
                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@id", txtComplaintId.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Complaint deleted.");
            ClearFields();
            dataGridViewComplaints.DataSource = null;
        }

        private void ClearFields()
        {
            txtComplaintId.Clear();
            txtUserId.Clear();
            txtSubject.Clear();
            txtDescription.Clear();
            cmbStatus.SelectedIndex = -1;
            dataGridViewComplaints.DataSource = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HRManagerDashboard hr = new HRManagerDashboard(hrId);
            hr.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
