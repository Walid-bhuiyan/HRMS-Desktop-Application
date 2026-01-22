using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRMS
{
    public partial class Admin_PayrollManagement : Form
    {
        int adminId;
        string adminEmail;

        public Admin_PayrollManagement(int id, string email)
        {
            InitializeComponent();
            adminId = id;
            adminEmail = email;
        }

        private SqlConnection Connect()
        {
            string connectionString = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        private void Admin_PayrollManagement_Load(object sender, EventArgs e)
        {
            payrollProcessingPanel.Visible = true;
            viewemppayrollPanel.Visible = false;

            cmbselectmonth.SelectedIndex = -1;
            cmbselectyear.SelectedIndex = -1;
            dataGridView2.DataSource = null;

            lblerrormonth.Text = "";
            lblerroryear.Text = "";
        }

        private void btngeneratepayroll_Click(object sender, EventArgs e)
        {
            lblerrormonth.Text = "";
            lblerroryear.Text = "";

            if (cmbselectmonth.SelectedIndex == -1 || cmbselectyear.SelectedIndex == -1)
            {
                if (cmbselectmonth.SelectedIndex == -1)
                    lblerrormonth.Text = "*** Month Selection is Required.";
                if (cmbselectyear.SelectedIndex == -1)
                    lblerroryear.Text = "*** Year Selection is Required.";
                return;
            }

            int month = cmbselectmonth.SelectedIndex + 1;
            int year = Convert.ToInt32(cmbselectyear.Text);

            try
            {
                using (SqlConnection conn = Connect())
                {
                    string checkQuery = @"SELECT COUNT(*) FROM Attendance WHERE MONTH(AttendanceDate)=@Month AND YEAR(AttendanceDate)=@Year";

                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Month", month);
                    checkCmd.Parameters.AddWithValue("@Year", year);

                    int attendanceCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (attendanceCount == 0)
                    {
                        MessageBox.Show("Attendance data not stored for this month/year.");
                        return;
                    }

                    string empQuery = "SELECT EmployeeID, Salary FROM Employees_Info";
                    SqlCommand empCmd = new SqlCommand(empQuery, conn);
                    SqlDataReader reader = empCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int empId = reader.GetInt32(0);
                        decimal salary = reader.GetDecimal(1);

                        int absentDays = GetAbsentDays(empId, month, year);
                        decimal deduction = CalculateDeduction(salary, absentDays);
                        decimal netSalary = salary - deduction;

                        SavePayroll(empId, month, year, salary, deduction, netSalary);
                    }

                    reader.Close();
                }

                MessageBox.Show("Payroll generated successfully.");
                ShowPayroll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating payroll: " + ex.Message);
            }
        }

        private decimal CalculateDeduction(decimal salary, int absentDays)
        {
            decimal tax = salary * 0.05m;
            decimal absentPenalty = absentDays * 500;
            return tax + absentPenalty;
        }

        private int GetAbsentDays(int empId, int month, int year)
        {
            using (SqlConnection conn = Connect())
            {
                string query = @"SELECT COUNT(*) FROM Attendance 
                                 WHERE UserID=@UserID AND LTRIM(RTRIM(Status))='Absent' 
                                 AND MONTH(AttendanceDate)=@Month AND YEAR(AttendanceDate)=@Year";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", empId);
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@Year", year);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void SavePayroll(int empId, int month, int year, decimal salary, decimal deduction, decimal net)
        {
            using (SqlConnection conn = Connect())
            {
                string query = @"
                IF EXISTS (SELECT 1 FROM Payroll WHERE EmployeeID=@EmpID AND Month=@Month AND Year=@Year)
                BEGIN
                    UPDATE Payroll SET GrossSalary=@Gross, TotalDeduction=@Deduction, NetSalary=@Net
                    WHERE EmployeeID=@EmpID AND Month=@Month AND Year=@Year
                END
                ELSE
                BEGIN
                    INSERT INTO Payroll (EmployeeID,Month,Year,GrossSalary,TotalDeduction,NetSalary)
                    VALUES (@EmpID,@Month,@Year,@Gross,@Deduction,@Net)
                END";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmpID", empId);
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Gross", salary);
                cmd.Parameters.AddWithValue("@Deduction", deduction);
                cmd.Parameters.AddWithValue("@Net", net);
                cmd.ExecuteNonQuery();
            }
        }

        private void ShowPayroll()
        {
            using (SqlConnection conn = Connect())
            {
                string query = "SELECT * FROM Payroll";
                SqlDataAdapter adp = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void btnsearch2_Click(object sender, EventArgs e)
        {
            lblerrorempidpayroll.Text = "";
            lblerrormonthpayroll.Text = "";
            lblerroryearpayroll.Text = "";

            if (txtempidpayroll.Text == "" || cmbselectmonthpayroll.SelectedIndex == -1 || cmbselectyearpayroll.SelectedIndex == -1)
            {
                if (txtempidpayroll.Text == "") lblerrorempidpayroll.Text = "*** Employee ID required.";
                if (cmbselectmonthpayroll.SelectedIndex == -1) lblerrormonthpayroll.Text = "*** Month required.";
                if (cmbselectyearpayroll.SelectedIndex == -1) lblerroryearpayroll.Text = "*** Year required.";
                return;
            }

            int empId = Convert.ToInt32(txtempidpayroll.Text);
            int month = cmbselectmonthpayroll.SelectedIndex + 1;
            int year = Convert.ToInt32(cmbselectyearpayroll.Text);

            using (SqlConnection conn = Connect())
            {
                string query = @"SELECT p.PayrollID,e.FullName,e.Department,e.JobTitle,p.Month,p.Year,
                                 p.GrossSalary,p.TotalDeduction,p.NetSalary 
                                 FROM Payroll p INNER JOIN Employees_Info e 
                                 ON e.EmployeeID=p.EmployeeID
                                 WHERE p.EmployeeID=@EmpID AND p.Month=@Month AND p.Year=@Year";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmpID", empId);
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@Year", year);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtpayrollid.Text = reader["PayrollID"].ToString();
                    txtempnamepayroll.Text = reader["FullName"].ToString();
                    txtdepartmentpayroll.Text = reader["Department"].ToString();
                    txtjobtitlepayroll.Text = reader["JobTitle"].ToString();
                    txtmonthpayroll.Text = reader["Month"].ToString();
                    txtyearpayroll.Text = reader["Year"].ToString();
                    txtgrosssalarypayroll.Text = reader["GrossSalary"].ToString();
                    txttotaldeductionpayroll.Text = reader["TotalDeduction"].ToString();
                    txtnetsalarypayroll.Text = reader["NetSalary"].ToString();
                }
                else
                {
                    MessageBox.Show("Payroll not found.");
                }

                reader.Close();
            }
        }

        private void btnresetpayroll_Click(object sender, EventArgs e)
        {
            txtempidpayroll.Text = "";
            txtpayrollid.Text = "";
            txtempnamepayroll.Text = "";
            txtdepartmentpayroll.Text = "";
            txtjobtitlepayroll.Text = "";
            txtmonthpayroll.Text = "";
            txtyearpayroll.Text = "";
            txtgrosssalarypayroll.Text = "";
            txttotaldeductionpayroll.Text = "";
            txtnetsalarypayroll.Text = "";

            cmbselectmonthpayroll.SelectedIndex = -1;
            cmbselectyearpayroll.SelectedIndex = -1;
        }

        private void btnviewemppayroll_Click(object sender, EventArgs e)
        {
            payrollProcessingPanel.Visible = true;
            viewemppayrollPanel.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowPayroll();
        }

        private void btnreset2_Click(object sender, EventArgs e)
        {
            cmbselectmonth.SelectedIndex = cmbselectyear.SelectedIndex = -1;
            dataGridView2.DataSource = null;
            lblerrormonth.Text = lblerroryear.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            payrollProcessingPanel.Visible = true;
            viewemppayrollPanel.Visible = false;
        }

        private void btnBackToHR_Click(object sender, EventArgs e)
        {
            this.Hide();
            btnadminoperations n = new btnadminoperations(adminId,adminEmail);
            n.Show();
        }
    }
}
