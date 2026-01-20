using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HRMS
{
    public partial class AccountantDashboard : Form
    {
        public AccountantDashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HideAllPanels()
        {
            showpanel.Visible = false;
            SalaryManagementPanel.Visible = false;
            payrollProcessingPanel.Visible = false;
            viewemppayrollPanel.Visible = false;
            paymentmanagementPanel.Visible = false;
            viewpaymentsPanel.Visible = false;
        }


        private void btnsalary_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            SalaryManagementPanel.Visible = true;

            txtempid.Text = txtempname.Text = txtdept.Text = txtjobtitle.Text = txtphone.Text = txtsalary.Text = txthouserent.Text = txtmedical.Text = txttransport.Text = txttotalsalary.Text = "";
            lblerrorempid.Text = "";
            dataGridView1.DataSource = null;

            OpenFields();
        }

        private void SalaryManagementPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadTotalEmployees()
        {
            SqlConnection conn = Connect();

            string query = "SELECT COUNT(*) FROM Employees_Info";

            SqlCommand cmd = new SqlCommand(query, conn);

            int totalEmployees = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            lblenumber.Text = totalEmployees.ToString();
        }


        private void AccountantDashboard_Load(object sender, EventArgs e)
        {
            HideAllPanels();
            listPanel.Parent = this;
            showpanel.Visible = true;
            LoadTotalEmployees();

            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            LoadMonthlyPayrollDashboard(currentMonth, currentYear);

            LoadPendingPayments(currentMonth, currentYear);
        }

        private void RefreshDashboard()
        {
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            LoadTotalEmployees();
            LoadMonthlyPayrollDashboard(currentMonth, currentYear);
            LoadPendingPayments(currentMonth, currentYear);
        }


        private void LoadMonthlyPayrollDashboard(int month, int year)
        {
            try
            {
                using (SqlConnection conn = Connect())
                {
                    string query = @" SELECT ISNULL(SUM(GrossSalary), 0) AS TotalMonthlyPayroll, ISNULL(SUM(TotalDeduction), 0) AS TotalDeductions, ISNULL(SUM(NetSalary), 0) AS NetSalaryPayable FROM Payroll WHERE Month = @Month AND Year = @Year";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblmonthlypayrolltk.Text = Convert.ToDecimal(reader["TotalMonthlyPayroll"]).ToString("N2");
                        lbldeductionstk.Text = Convert.ToDecimal(reader["TotalDeductions"]).ToString("N2");
                        lblnetpayabletk.Text = Convert.ToDecimal(reader["NetSalaryPayable"]).ToString("N2");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard metrics: " + ex.Message);
            }
        }

        void LoadPendingPayments(int month, int year)
        {
            using (SqlConnection conn = Connect())
            {
                string query = @"SELECT COUNT(*) FROM Payroll p WHERE p.Month = @Month AND p.Year = @Year AND NOT EXISTS ( SELECT 1 FROM Payment pay WHERE pay.EmployeeID = p.EmployeeID AND pay.PayMonth = p.Month AND pay.PayYear = p.Year AND pay.PaymentStatus = 'Paid')";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@Year", year);

                int pendingCount = Convert.ToInt32(cmd.ExecuteScalar());

                lblppnumber.Text = pendingCount + " Employees";
            }
        }


        private void btnchangepassword_Click(object sender, EventArgs e)
        {

        }

        private void SalaryManagementPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            showpanel.Visible = true;

            RefreshDashboard();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SearchEmployee()
        {
            lblerrorempid.Text = "";

            if (txtempid.Text == "")
            {
                lblerrorempid.Text = "*** The Employee ID Field is Required.";
                return;
            }

            try
            {
                SqlConnection conn = Connect();
                string query = "SELECT * FROM Employees_Info WHERE EmployeeID = @EmpID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmpID", txtempid.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtempname.Text = reader["FullName"].ToString();
                    txtdept.Text = reader["Department"].ToString();
                    txtjobtitle.Text = reader["JobTitle"].ToString();
                    txtphone.Text = reader["Phone"].ToString();
                    txtsalary.Text = reader["Salary"].ToString();

                    LockFields();

                    txttotalsalary.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Invalid Employee ID. Employee not found.");
                    txtempid.Text = txtempname.Text = txtdept.Text = txtjobtitle.Text = txtphone.Text = txtsalary.Text = "";
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LockFields()
        {
            txtempid.ReadOnly = true;
            txtempname.ReadOnly = true;
            txtdept.ReadOnly = true;
            txtjobtitle.ReadOnly = true;
            txtphone.ReadOnly = true;
            txtsalary.ReadOnly = false;
        }

        private void OpenFields()
        {
            txtempid.ReadOnly = false;
            txtempname.ReadOnly = false;
            txtdept.ReadOnly = false;
            txtjobtitle.ReadOnly = false;
            txtphone.ReadOnly = false;
            txtsalary.ReadOnly = false;
        }


        private void btnsearch_Click(object sender, EventArgs e)
        {
            SearchEmployee();
        }

        private SqlConnection Connect()
        {
            string connectionString = @"Data Source=localhost\MSSQLSERVER01;Initial Catalog=HRMS_DB;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        private void show()
        {
            SqlConnection conn = Connect();
            string query = "select * from SalaryManagement";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = true;
            conn.Close();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            show();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtempid.Text = dataGridView1.Rows[e.RowIndex].Cells["EmployeeID"].Value.ToString();
                txtempname.Text = dataGridView1.Rows[e.RowIndex].Cells["EmpName"].Value.ToString();
                txtdept.Text = dataGridView1.Rows[e.RowIndex].Cells["Department"].Value.ToString();
                txtjobtitle.Text = dataGridView1.Rows[e.RowIndex].Cells["JobTitle"].Value.ToString();
                txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                txtsalary.Text = dataGridView1.Rows[e.RowIndex].Cells["Salary"].Value.ToString();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtempid.Text = txtempname.Text = txtdept.Text = txtjobtitle.Text = txtphone.Text = txtsalary.Text = txthouserent.Text = txtmedical.Text = txttransport.Text = txttotalsalary.Text = "";
            lblerrorempid.Text = "";
            OpenFields();
            txttotalsalary.ReadOnly = false;

            dataGridView1.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblerrorempid.Text = "";

            if (txtempid.Text == "")
            {
                lblerrorempid.Text = "*** The Employee ID Field is Required.";
                return;
            }

            if (txtempid.Text != "" && txtempname.Text == "" || txtdept.Text == "" || txtjobtitle.Text == "" || txtphone.Text == "" || txtsalary.Text == "")
            {
                MessageBox.Show("Information Fields are empty. Click Search.");
                return;
            }

            try
            {
                decimal salary = 0, house = 0, medical = 0, transport = 0;
                decimal.TryParse(txtsalary.Text, out salary);
                decimal.TryParse(txthouserent.Text, out house);
                decimal.TryParse(txtmedical.Text, out medical);
                decimal.TryParse(txttransport.Text, out transport);


                decimal totalSalary = salary + house + medical + transport;
                txttotalsalary.Text = totalSalary.ToString("0.00");

                using (SqlConnection conn = Connect())
                {
                    string query = @" IF EXISTS (SELECT 1 FROM SalaryManagement WHERE EmployeeID = @EmpID) BEGIN UPDATE SalaryManagement SET HouseRent = @HouseRent, Medical = @Medical, Transport = @Transport, Salary = @Salary WHERE EmployeeID = @EmpID END ELSE BEGIN INSERT INTO SalaryManagement (EmployeeID, EmpName, Department, JobTitle, Phone, Salary, HouseRent, Medical, Transport) VALUES (@EmpID, @EmpName, @Department, @JobTitle, @Phone, @Salary, @HouseRent, @Medical, @Transport) END";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmpID", txtempid.Text);
                    cmd.Parameters.AddWithValue("@EmpName", txtempname.Text);
                    cmd.Parameters.AddWithValue("@Department", txtdept.Text);
                    cmd.Parameters.AddWithValue("@JobTitle", txtjobtitle.Text);
                    cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                    cmd.Parameters.AddWithValue("@Salary", salary);
                    cmd.Parameters.AddWithValue("@HouseRent", house);
                    cmd.Parameters.AddWithValue("@Medical", medical);
                    cmd.Parameters.AddWithValue("@Transport", transport);

                    cmd.ExecuteNonQuery();

                    string updateEmpQuery = "UPDATE Employees_Info SET Salary=@TotalSalary WHERE EmployeeID=@EmpID";
                    SqlCommand cmd2 = new SqlCommand(updateEmpQuery, conn);
                    cmd2.Parameters.AddWithValue("@TotalSalary", totalSalary);
                    cmd2.Parameters.AddWithValue("@EmpID", txtempid.Text);
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Allowances added and salary updated successfully");

                    txthouserent.Text = txtmedical.Text = txttransport.Text = "";
                }

                show();

                int currentMonth = DateTime.Now.Month;
                int currentYear = DateTime.Now.Year;
                LoadMonthlyPayrollDashboard(currentMonth, currentYear);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnpayroll_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            payrollProcessingPanel.Visible = true;

            cmbselectmonth.SelectedIndex = cmbselectyear.SelectedIndex = -1;

            dataGridView2.DataSource = null;

            lblerrormonth.Text = lblerroryear.Text = "";
        }


        private void btnlogout_Click(object sender, EventArgs e)
        {
            loginframe login = new loginframe();
            login.Show();
            this.Hide();
        }

        void SyncPaymentWithPayroll()
        {
            using (SqlConnection conn = Connect())
            {
                string query = @"UPDATE pay SET pay.NetSalary = p.NetSalary FROM Payment pay INNER JOIN Payroll p ON pay.EmployeeID = p.EmployeeID AND pay.PayMonth = p.Month AND pay.PayYear = p.Year WHERE pay.PaymentStatus = 'Unpaid'";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }

        private void btngeneratepayroll_Click(object sender, EventArgs e)
        {
            lblerroryear.Text = lblerrormonth.Text = "";

            bool monthSelected = cmbselectmonth.SelectedIndex != -1;
            bool yearSelected = cmbselectyear.SelectedIndex != -1;

            try
            {
                if (!monthSelected || !yearSelected)
                {
                    if (!monthSelected)
                    {
                        lblerrormonth.Text = "*** Month Selection is Required.";
                    }
                    if (!yearSelected)
                    {
                        lblerroryear.Text = "*** Year Selection is Required.";
                    }
                    return;
                }

                int month = cmbselectmonth.SelectedIndex + 1;
                int year = Convert.ToInt32(cmbselectyear.Text);

                using (SqlConnection conn = Connect())
                {
                    string checkQuery = @" SELECT COUNT(*)  FROM Attendance WHERE MONTH(AttendanceDate) = @Month AND YEAR(AttendanceDate) = @Year";

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
                SyncPaymentWithPayroll();

                MessageBox.Show("Payroll generated and saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating payroll: " + ex.Message);
            }

            showPayroll();

            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;
            LoadMonthlyPayrollDashboard(currentMonth, currentYear);
        }


        decimal CalculateDeduction(decimal salary, int absentDays)
        {
            decimal tax = salary * 0.05m;
            decimal absentPenalty = absentDays * 500;

            decimal deduction = tax + absentPenalty;
            return deduction;
        }

        int GetAbsentDays(int empId, int month, int year)
        {
            int absentDays = 0;

            try
            {
                using (SqlConnection conn = Connect())
                {
                    string query = @" SELECT COUNT(*) FROM Attendance WHERE UserID = @UserID AND LTRIM(RTRIM(Status)) = 'Absent' AND MONTH(AttendanceDate) = @Month AND YEAR(AttendanceDate) = @Year";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", empId);
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);

                    absentDays = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching absent days: " + ex.Message);
            }

            return absentDays;
        }

        void SavePayroll(int empId, int month, int year, decimal salary, decimal deduction, decimal net)
        {
            using (SqlConnection conn = Connect())
            {
                string payrollQuery = @"IF EXISTS (SELECT 1 FROM Payroll WHERE EmployeeID=@EmpID AND Month=@Month AND Year=@Year) BEGIN UPDATE Payroll SET GrossSalary=@Gross, TotalDeduction=@Deduction, NetSalary=@Net WHERE EmployeeID=@EmpID AND Month=@Month AND Year=@Year END ELSE BEGIN INSERT INTO Payroll (EmployeeID, Month, Year, GrossSalary, TotalDeduction, NetSalary) VALUES (@EmpID, @Month, @Year, @Gross, @Deduction, @Net) END";

                SqlCommand cmd = new SqlCommand(payrollQuery, conn);
                cmd.Parameters.AddWithValue("@EmpID", empId);
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Gross", salary);
                cmd.Parameters.AddWithValue("@Deduction", deduction);
                cmd.Parameters.AddWithValue("@Net", net);
                cmd.ExecuteNonQuery();

                string paymentQuery = @" IF NOT EXISTS (SELECT 1 FROM Payment WHERE EmployeeID=@EmpID AND PayMonth=@Month AND PayYear=@Year) BEGIN INSERT INTO Payment (EmployeeID, PayMonth, PayYear, NetSalary, PaymentStatus) VALUES (@EmpID, @Month, @Year, @Net, 'Unpaid') END";

                SqlCommand payCmd = new SqlCommand(paymentQuery, conn);
                payCmd.Parameters.AddWithValue("@EmpID", empId);
                payCmd.Parameters.AddWithValue("@Month", month);
                payCmd.Parameters.AddWithValue("@Year", year);
                payCmd.Parameters.AddWithValue("@Net", net);
                payCmd.ExecuteNonQuery();
            }
        }


        private void showPayroll()
        {
            SqlConnection conn = Connect();
            string query = "select * from Payroll";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView2.DataSource = dt;
            dataGridView2.AutoGenerateColumns = true;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showPayroll();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnreset2_Click(object sender, EventArgs e)
        {
            cmbselectmonth.SelectedIndex = cmbselectyear.SelectedIndex = -1;

            dataGridView2.DataSource = null;

            lblerrormonth.Text = lblerroryear.Text = "";
        }

        private void btnviewemppayroll_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            payrollProcessingPanel.Visible = true;
            viewemppayrollPanel.Visible = true;

            txtempidpayroll.Text = txtpayrollid.Text = txtempnamepayroll.Text = txtdepartmentpayroll.Text = txtjobtitlepayroll.Text = txtmonthpayroll.Text = txtyearpayroll.Text = txtgrosssalarypayroll.Text = txttotaldeductionpayroll.Text = txtnetsalarypayroll.Text = "";
            cmbselectmonthpayroll.SelectedIndex = cmbselectyearpayroll.SelectedIndex = -1;

            lblerrorempidpayroll.Text = lblerrormonthpayroll.Text = lblerroryearpayroll.Text = "";

            OpenFields2();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch2_Click(object sender, EventArgs e)
        {
            lblerrorempidpayroll.Text = lblerrormonthpayroll.Text = lblerroryearpayroll.Text = "";

            if (txtempidpayroll.Text == "" || cmbselectmonthpayroll.SelectedIndex == -1 || cmbselectyearpayroll.SelectedIndex == -1)
            {
                if (txtempidpayroll.Text == "")
                {
                    lblerrorempidpayroll.Text = "*** The Employee ID Field is Required.";
                }
                if (cmbselectmonthpayroll.SelectedIndex == -1)
                {
                    lblerrormonthpayroll.Text = "*** Month Selection is Required.";
                }
                if (cmbselectyearpayroll.SelectedIndex == -1)
                {
                    lblerroryearpayroll.Text = "*** Year Selection is Required.";
                }
                return;
            }

            if (!int.TryParse(txtempidpayroll.Text, out int empId))
            {
                lblerrorempidpayroll.Text = "*** Employee ID must be a number.";
                return;
            }
            int month = cmbselectmonthpayroll.SelectedIndex + 1;
            int year = Convert.ToInt32(cmbselectyearpayroll.Text);

            try
            {
                using (SqlConnection conn = Connect())
                {
                    string query = @" SELECT p.PayrollID, e.FullName, e.Department, e.JobTitle,  p.Month,  p.Year, p.GrossSalary, p.TotalDeduction, p.NetSalary FROM Payroll p INNER JOIN Employees_Info e ON e.EmployeeID = p.EmployeeID WHERE p.EmployeeID = @EmpID AND p.Month = @Month AND p.Year = @Year";

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

                        LockFields2();
                    }
                    else
                    {
                        MessageBox.Show("Payroll not generated for this employee/month/year.");
                        txtempidpayroll.Text = txtpayrollid.Text = txtempnamepayroll.Text = txtdepartmentpayroll.Text = txtjobtitlepayroll.Text = txtmonthpayroll.Text = txtyearpayroll.Text = txtgrosssalarypayroll.Text = txttotaldeductionpayroll.Text = txtnetsalarypayroll.Text = "";
                        cmbselectmonthpayroll.SelectedIndex = cmbselectyearpayroll.SelectedIndex = -1;
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payroll: " + ex.Message);
            }
        }

        private void viewemppayrollPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnresetpayroll_Click(object sender, EventArgs e)
        {
            txtempidpayroll.Text = txtpayrollid.Text = txtempnamepayroll.Text = txtdepartmentpayroll.Text = txtjobtitlepayroll.Text = txtmonthpayroll.Text = txtyearpayroll.Text = txtgrosssalarypayroll.Text = txttotaldeductionpayroll.Text = txtnetsalarypayroll.Text = "";
            cmbselectmonthpayroll.SelectedIndex = cmbselectyearpayroll.SelectedIndex = -1;

            OpenFields2();

            lblerrorempidpayroll.Text = lblerrormonthpayroll.Text = lblerroryearpayroll.Text = "";
        }

        private void LockFields2()
        {
            txtempidpayroll.ReadOnly = true;
            txtpayrollid.ReadOnly = true;
            txtempnamepayroll.ReadOnly = true;
            txtdepartmentpayroll.ReadOnly = true;
            txtjobtitlepayroll.ReadOnly = true;
            txtmonthpayroll.ReadOnly = true;
            txtyearpayroll.ReadOnly = true;
            txtgrosssalarypayroll.ReadOnly = true;
            txttotaldeductionpayroll.ReadOnly = true;
            txtnetsalarypayroll.ReadOnly = true;
        }

        private void OpenFields2()
        {
            txtempidpayroll.ReadOnly = false;
            txtpayrollid.ReadOnly = false;
            txtempnamepayroll.ReadOnly = false;
            txtdepartmentpayroll.ReadOnly = false;
            txtjobtitlepayroll.ReadOnly = false;
            txtmonthpayroll.ReadOnly = false;
            txtyearpayroll.ReadOnly = false;
            txtgrosssalarypayroll.ReadOnly = false;
            txttotaldeductionpayroll.ReadOnly = false;
            txtnetsalarypayroll.ReadOnly = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            payrollProcessingPanel.Visible = true;

            cmbselectmonth.SelectedIndex = cmbselectyear.SelectedIndex = -1;
            dataGridView2.DataSource = null;

            lblerrormonth.Text = lblerroryear.Text = "";
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            paymentmanagementPanel.Visible = true;

            txtempidpm.Text = txtempnamepm.Text = txtdepartmentpm.Text = txtjobtitlepm.Text = txtnetsalarypm.Text = "";
            cmbmonthpm.SelectedIndex = cmbyearpm.SelectedIndex = cmbpaymethodpm.SelectedIndex = -1;

            lblerrorempidpm.Text = lblerrormonthpm.Text = lblerroryearpm.Text = lblerrorpaymethodpm.Text = "";

            OpenFields3();
        }

        private void btnviewpaymentspm_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            paymentmanagementPanel.Visible = true;
            viewpaymentsPanel.Visible = true;

            OpenFields4();

            lblerrorempidpm.Text = lblerrormonthpm.Text = lblerroryearpm.Text = lblerrorpaymethodpm.Text = lblerrorempidvp.Text = "";
            dataGridView3.DataSource = null;

            txtempidpm.Text = txtempnamepm.Text = txtdepartmentpm.Text = txtjobtitlepm.Text = txtnetsalarypm.Text = "";
            cmbmonthpm.SelectedIndex = cmbyearpm.SelectedIndex = cmbpaymethodpm.SelectedIndex = -1;
        }

        private void LockFields3()
        {
            txtempidpm.ReadOnly = true;
            txtempnamepm.ReadOnly = true;
            txtdepartmentpm.ReadOnly = true;
            txtjobtitlepm.ReadOnly = true;
            txtnetsalarypm.ReadOnly = true;
        }

        private void OpenFields3()
        {
            txtempidpm.ReadOnly = false;
            txtempnamepm.ReadOnly = false;
            txtdepartmentpm.ReadOnly = false;
            txtjobtitlepm.ReadOnly = false;
            txtnetsalarypm.ReadOnly = false;
        }
        private void show2()
        {
            using (SqlConnection conn = Connect())
            {
                string query = @" SELECT pay.PaymentID, e.EmployeeID, e.FullName, e.Department, e.JobTitle, pay.NetSalary, pay.PayMonth, pay.PayYear, pay.PaymentStatus, pay.PaymentDate FROM Payment pay JOIN Employees_Info e ON e.EmployeeID = pay.EmployeeID ORDER BY pay.PayYear DESC, pay.PayMonth DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView3.DataSource = dt;
                dataGridView3.AutoGenerateColumns = true;
            }
        }

        private void btnshowvp_Click(object sender, EventArgs e)
        {
            show2();
        }

        private void btnpaysalarypm_Click(object sender, EventArgs e)
        {
            lblerrorpaymethodpm.Text = "";
            lblerrorempidpm.Text = lblerrormonthpm.Text = lblerroryearpm.Text = "";

            if (txtempidpm.Text == "" || cmbmonthpm.SelectedIndex == -1 || cmbyearpm.SelectedIndex == -1 || cmbpaymethodpm.SelectedIndex == -1)
            {
                if (txtempidpm.Text == "")
                {
                    lblerrorempidpm.Text = "*** The Employee ID Field is Required.";
                }
                if (cmbmonthpm.SelectedIndex == -1)
                {
                    lblerrormonthpm.Text = "*** Month Selection is Required.";
                }
                if (cmbyearpm.SelectedIndex == -1)
                {
                    lblerroryearpm.Text = "*** Year Selection is Required.";
                }
                if (cmbpaymethodpm.SelectedIndex == -1)
                {
                    lblerrorpaymethodpm.Text = "*** Payment Method Selection is Required.";
                }
                return;
            }

            int empId;
            if (!int.TryParse(txtempidpm.Text, out empId))
            {
                MessageBox.Show("Invalid Employee ID.");
                return;
            }

            int month = cmbmonthpm.SelectedIndex + 1;
            int year = Convert.ToInt32(cmbyearpm.Text);

            using (SqlConnection conn = Connect())
            {
                string checkQuery = @" SELECT PaymentStatus FROM Payment WHERE EmployeeID = @EmpID AND PayMonth = @Month AND PayYear = @Year";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@EmpID", empId);
                checkCmd.Parameters.AddWithValue("@Month", month);
                checkCmd.Parameters.AddWithValue("@Year", year);

                object statusObj = checkCmd.ExecuteScalar();

                if (statusObj == null)
                {
                    MessageBox.Show("No payroll record found for this employee.");
                    return;
                }

                if (statusObj.ToString() == "Paid")
                {
                    MessageBox.Show("Salary has already been paid for this employee.");
                    return;
                }

                string updateQuery = @" UPDATE Payment SET PaymentStatus = 'Paid', PaymentMethod = @Method, PaymentDate = @Date WHERE EmployeeID = @EmpID AND PayMonth = @Month AND PayYear = @Year";

                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@Method", cmbpaymethodpm.Text);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@EmpID", empId);
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@Year", year);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Salary paid successfully.");
                }
                else
                {
                    MessageBox.Show("Payment failed. Please try again.");
                }
            }

        }

        private void btnsearchpm_Click(object sender, EventArgs e)
        {
            lblerrorempidpm.Text = lblerrormonthpm.Text = lblerroryearpm.Text = lblerrorpaymethodpm.Text = "";

            if (txtempidpm.Text == "" || cmbmonthpm.SelectedIndex == -1 || cmbyearpm.SelectedIndex == -1)
            {
                if (txtempidpm.Text == "")
                {
                    lblerrorempidpm.Text = "*** The Employee ID Field is Required.";
                }
                if (cmbmonthpm.SelectedIndex == -1)
                {
                    lblerrormonthpm.Text = "*** Month Selection is Required.";
                }
                if (cmbyearpm.SelectedIndex == -1)
                {
                    lblerroryearpm.Text = "*** Year Selection is Required.";
                }
                return;
            }

            if (!int.TryParse(txtempidpm.Text, out int empId))
            {
                lblerrorempidpm.Text = "*** Employee ID must be a number.";
                return;
            }
            int month = cmbmonthpm.SelectedIndex + 1;
            int year = Convert.ToInt32(cmbyearpm.Text);

            try
            {
                using (SqlConnection conn = Connect())
                {
                    string query = @"SELECT e.FullName, e.Department, e.JobTitle, pay.NetSalary, pay.PaymentStatus FROM Payment pay INNER JOIN Employees_Info e ON e.EmployeeID = pay.EmployeeID WHERE pay.EmployeeID = @EmpID AND pay.PayMonth = @Month AND pay.PayYear = @Year";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmpID", empId);
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtempnamepm.Text = dr["FullName"].ToString();
                        txtdepartmentpm.Text = dr["Department"].ToString();
                        txtjobtitlepm.Text = dr["JobTitle"].ToString();
                        txtnetsalarypm.Text = dr["NetSalary"].ToString();

                        string status = dr["PaymentStatus"].ToString();

                        LockFields3();
                    }
                    else
                    {
                        MessageBox.Show("Payroll not generated or payment record not found.");

                        txtempidpm.Text = txtempnamepm.Text = txtdepartmentpm.Text =
                        txtjobtitlepm.Text = txtnetsalarypm.Text = "";

                        cmbmonthpm.SelectedIndex = cmbyearpm.SelectedIndex =
                        cmbpaymethodpm.SelectedIndex = -1;
                    }

                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment info: " + ex.Message);
            }
        }

        private void btnresetpm_Click(object sender, EventArgs e)
        {
            txtempidpm.Text = txtempnamepm.Text = txtdepartmentpm.Text = txtjobtitlepm.Text = txtnetsalarypm.Text = "";
            cmbmonthpm.SelectedIndex = cmbyearpm.SelectedIndex = cmbpaymethodpm.SelectedIndex = -1;

            lblerrorempidpm.Text = lblerrormonthpm.Text = lblerroryearpm.Text = lblerrorpaymethodpm.Text = "";

            OpenFields3();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnsearchvp_Click(object sender, EventArgs e)
        {
            lblerrorempidvp.Text = "";

            if (txtempidvp.Text == "")
            {
                lblerrorempidvp.Text = "*** The Employee ID Field is Required.";
                return;
            }

            int empId;
            if (!int.TryParse(txtempidvp.Text, out empId))
            {
                MessageBox.Show("Invalid Employee ID.");
                return;
            }

            using (SqlConnection conn = Connect())
            {
                string query = @"SELECT pay.PaymentID, pay.EmployeeID, e.FullName, e.Department, e.JobTitle, pay.NetSalary, pay.PayMonth, pay.PayYear, pay.PaymentStatus, pay.PaymentMethod, pay.PaymentDate FROM Payment pay INNER JOIN Employees_Info e ON e.EmployeeID = pay.EmployeeID WHERE pay.EmployeeID = @EmpID ORDER BY pay.PaymentDate DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmpID", empId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No payment record found for this employee.");
                    return;
                }

                DataRow row = dt.Rows[0];

                txtpaymentidvp.Text = row["PaymentID"].ToString();
                txtempnamevp.Text = row["FullName"].ToString();
                txtdepartmentvp.Text = row["Department"].ToString();
                txtjobtitlevp.Text = row["JobTitle"].ToString();
                txtnetsalaryvp.Text = row["NetSalary"].ToString();
                txtpaymonthvp.Text = row["PayMonth"].ToString();
                txtpayyearvp.Text = row["PayYear"].ToString();
                txtpaystatusvp.Text = row["PaymentStatus"].ToString();
                txtpaydatevp.Text = row["PaymentDate"] == DBNull.Value ? "" : Convert.ToDateTime(row["PaymentDate"]).ToShortDateString();

                LockFields4();

                dataGridView3.DataSource = dt;
                dataGridView3.AutoGenerateColumns = true;
            }
        }

        private void OpenFields4()
        {
            txtempidvp.ReadOnly = false;
            txtempnamevp.ReadOnly = false;
            txtdepartmentvp.ReadOnly = false;
            txtjobtitlevp.ReadOnly = false;
            txtnetsalaryvp.ReadOnly = false;
            txtpaymentidvp.ReadOnly = false;
            txtpaymonthvp.ReadOnly = false;
            txtpayyearvp.ReadOnly = false;
            txtpaystatusvp.ReadOnly = false;
            txtpaydatevp.ReadOnly = false;
        }

        private void LockFields4()
        {
            txtempidvp.ReadOnly = true;
            txtempnamevp.ReadOnly = true;
            txtdepartmentvp.ReadOnly = true;
            txtjobtitlevp.ReadOnly = true;
            txtnetsalaryvp.ReadOnly = true;
            txtpaymentidvp.ReadOnly = true;
            txtpaymonthvp.ReadOnly = true;
            txtpayyearvp.ReadOnly = true;
            txtpaystatusvp.ReadOnly = true;
            txtpaydatevp.ReadOnly = true;
        }

        private void btnbackvp_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            paymentmanagementPanel.Visible = true;

            lblerrorempidpm.Text = lblerrormonthpm.Text = lblerroryearpm.Text = lblerrorpaymethodpm.Text = lblerrorempidvp.Text = "";

            txtempidvp.Text = txtempnamevp.Text = txtdepartmentvp.Text = txtjobtitlevp.Text = txtnetsalaryvp.Text = txtpaymentidvp.Text = txtpaymonthvp.Text = txtpayyearvp.Text = txtpaystatusvp.Text = txtpaydatevp.Text = "";
            OpenFields3();
        }

        private void btnresetvp_Click(object sender, EventArgs e)
        {
            txtempidvp.Text = txtempnamevp.Text = txtdepartmentvp.Text = txtjobtitlevp.Text = txtnetsalaryvp.Text = txtpaymentidvp.Text = txtpaymonthvp.Text = txtpayyearvp.Text = txtpaystatusvp.Text = txtpaydatevp.Text = "";
            OpenFields4();

            lblerrorempidvp.Text = "";

            dataGridView3.DataSource = null;
        }
    }
}
