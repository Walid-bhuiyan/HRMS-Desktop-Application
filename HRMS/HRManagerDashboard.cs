using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRMS
{
    public partial class HRManagerDashboard : Form
    {
        private int hrId = 0;

        // ✅ Database connection
        private string conStr =
            @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True";

        // ================= CONSTRUCTORS =================

        public HRManagerDashboard()
        {
            InitializeComponent();
        }

        public HRManagerDashboard(int id)
        {
            InitializeComponent();
            hrId = id;
        }

        // ================= FORM LOAD =================

        private void HRManagerDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        // ================= DASHBOARD DATA =================

        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conStr))
                {
                    conn.Open();

                    // 🔹 TOTAL EMPLOYEES
                    SqlCommand cmdEmp = new SqlCommand(
                        "SELECT COUNT(*) FROM Employees_Info", conn);
                    lblTotalEmployeesValue.Text = cmdEmp.ExecuteScalar().ToString();

                    // 🔹 TODAY'S PRESENT
                    SqlCommand cmdPresent = new SqlCommand(
                        "SELECT COUNT(*) FROM Attendance WHERE AttendanceDate = CAST(GETDATE() AS DATE) AND Status='Present'", conn);
                    lblTodayPresentValue.Text = cmdPresent.ExecuteScalar().ToString();

                    // 🔹 TOTAL DEPARTMENTS
                    SqlCommand cmdDept = new SqlCommand(
                        "SELECT COUNT(*) FROM Departments", conn);
                    lblTotalDepartmentsValue.Text = cmdDept.ExecuteScalar().ToString();

                    // 🔹 PENDING LEAVES ✅ (FIXED)
                    SqlCommand cmdPending = new SqlCommand(
                        "SELECT COUNT(*) FROM LeaveRequests WHERE Status='Pending'", conn);
                    lblPendingLeavesValue.Text = cmdPending.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dashboard load error: " + ex.Message);
            }
        }

        // ================= LOGOUT =================

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginframe login = new loginframe();
            login.Show();
            this.Hide();
        }

        // ================= PROFILE =================

        private void btnProfile_Click(object sender, EventArgs e)
        {
            HRProfile p = new HRProfile(hrId);
            p.Show();
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            btnProfile_Click(sender, e);
        }

        // ================= EMPLOYEES =================

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            HR_EmployeeManagement empForm = new HR_EmployeeManagement(hrId);
            empForm.Show();
            this.Hide();
        }

        // ================= ATTENDANCE =================

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            HRAttendance hrAtt = new HRAttendance(hrId);
            hrAtt.Show();
            this.Hide();
        }

        // ================= CHANGE PASSWORD =================

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            HRChangePassword cp = new HRChangePassword(hrId);
            cp.Show();
            this.Hide();
        }

        // ================= ORGANIZATION =================

        private void btnOrganization_Click(object sender, EventArgs e)
        {
            HR_DepartmentManagement n = new HR_DepartmentManagement(hrId);
            n.Show();
            this.Hide();
        }

        // ================= LEAVE MANAGEMENT =================

        private void btnLeaveManagementSP_Click(object sender, EventArgs e)
        {
            HR_LeaveManagement lm = new HR_LeaveManagement(hrId);
            lm.Show();
            this.Hide();
        }

        // ================= PAYROLL =================

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            HR_PayrollManagement ht = new HR_PayrollManagement(hrId);
            ht.Show();
            this.Hide();
        }

        // ================= EMPTY EVENTS =================

        private void pnlTopHr_Paint(object sender, PaintEventArgs e) { }
        private void panelDashboard_Paint(object sender, PaintEventArgs e) { }
        private void pnlMain_Paint(object sender, PaintEventArgs e) { }
        private void btnDashboardSB_Click(object sender, EventArgs e) { }
    }
}
