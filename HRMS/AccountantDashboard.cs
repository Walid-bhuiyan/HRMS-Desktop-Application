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
        }

        private void LoadMonthlyPayrollDashboard(int month, int year)
        {
            try
            {
                using (SqlConnection conn = Connect())
                {
                    string query = @"
                    SELECT 
                        ISNULL(SUM(GrossSalary), 0) AS TotalMonthlyPayroll,
                        ISNULL(SUM(TotalDeduction), 0) AS TotalDeductions,
                        ISNULL(SUM(NetSalary), 0) AS NetSalaryPayable
                    FROM Payroll
                    WHERE Month = @Month AND Year = @Year";

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

            if(txtempid.Text == "")
            {
                lblerrorempid.Text = "*** The Employee ID Field is Required.";
                return;
            }

            if(txtempid.Text != "" && txtempname.Text == "" || txtdept.Text == "" || txtjobtitle.Text == "" || txtphone.Text == "" || txtsalary.Text == "")
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
                    string query = @"
                    IF EXISTS (SELECT 1 FROM SalaryManagement WHERE EmployeeID = @EmpID)
                    BEGIN
                        UPDATE SalaryManagement
                        SET HouseRent = @HouseRent,
                            Medical = @Medical,
                            Transport = @Transport,
                            Salary = @Salary
                        WHERE EmployeeID = @EmpID
                    END
                    ELSE
                    BEGIN
                        INSERT INTO SalaryManagement
                        (EmployeeID, EmpName, Department, JobTitle, Phone, Salary, HouseRent, Medical, Transport)
                        VALUES
                        (@EmpID, @EmpName, @Department, @JobTitle, @Phone, @Salary, @HouseRent, @Medical, @Transport)
                    END";

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
                    string checkQuery = @"
                    SELECT COUNT(*) 
                    FROM Attendance
                    WHERE MONTH(AttendanceDate) = @Month
                      AND YEAR(AttendanceDate) = @Year";

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
                    string query = @"
                    SELECT COUNT(*) 
                    FROM Attendance
                    WHERE UserID = @UserID
                      AND LTRIM(RTRIM(Status)) = 'Absent'
                      AND MONTH(AttendanceDate) = @Month
                      AND YEAR(AttendanceDate) = @Year";

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
                string query = @"
                IF EXISTS (
                    SELECT 1 FROM Payroll 
                    WHERE EmployeeID=@EmpID AND Month=@Month AND Year=@Year
                )
                BEGIN
                    
                    UPDATE Payroll
                    SET GrossSalary = @Gross,
                        TotalDeduction = @Deduction,
                        NetSalary = @Net
                    WHERE EmployeeID=@EmpID AND Month=@Month AND Year=@Year
                END
                ELSE
                BEGIN

                    INSERT INTO Payroll
                    (EmployeeID, Month, Year, GrossSalary, TotalDeduction, NetSalary)
                    VALUES
                    (@EmpID, @Month, @Year, @Gross, @Deduction, @Net)
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
                if(txtempidpayroll.Text == "")
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

            int empId = Convert.ToInt32(txtempidpayroll.Text);
            int month = cmbselectmonthpayroll.SelectedIndex + 1;
            int year = Convert.ToInt32(cmbselectyearpayroll.Text);

            try
            {
                using (SqlConnection conn = Connect())
                {
                    string query = @"
                    SELECT 
                        p.PayrollID,
                        e.FullName,
                        e.Department,
                        e.JobTitle,
                        p.Month,
                        p.Year,
                        p.GrossSalary,
                        p.TotalDeduction,
                        p.NetSalary
                    FROM Payroll p
                    INNER JOIN Employees_Info e ON e.EmployeeID = p.EmployeeID
                    WHERE p.EmployeeID = @EmpID
                      AND p.Month = @Month
                      AND p.Year = @Year";

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

        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            paymentmanagementPanel.Visible = true;
        }
    }
}
