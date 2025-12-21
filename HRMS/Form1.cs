using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS
{
    public partial class loginframe : Form
    {
        private string uname = "walid";
        private string pass = "walid@@@";
        public loginframe()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
        }

        private void lblpass_Click(object sender, EventArgs e)
        {

        }

        private void loginframe_Load(object sender, EventArgs e)
        {

        }

        private void LoginInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            lblerroruname.Text = "";
            lblerrorpass.Text = "";

            bool valid = true;

            if (txtuname.Text == "")
            {
                lblerroruname.Text = "Username is required";
                valid = false;
            }

            if (txtpass.Text == "")
            {
                lblerrorpass.Text = "Password is required";
                valid = false;
            }

            if (cmbLoginAs.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a role!", "Validation Error");
                valid = false;
            }

            if (!valid)
            {
                return;
            }

            if (txtuname.Text == uname && txtpass.Text == pass)
            {
                if (cmbLoginAs.Text == "Admin")
                {
                    AdminDashboard a = new AdminDashboard();
                    a.Show();
                    this.Hide();
                }
                else if (cmbLoginAs.Text == "HR Manager")
                {
                    HRManagerDashboard h = new HRManagerDashboard();
                    h.Show();
                    this.Hide();
                }
                else if (cmbLoginAs.Text == "Employee")
                {
                    EmployeeDashboard e1 = new EmployeeDashboard();
                    e1.Show();
                    this.Hide();
                }
                else if (cmbLoginAs.Text == "Accountant")
                {
                    AccountantDashboard ac = new AccountantDashboard();
                    ac.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password!",
                    "Login Failed");
            }
        }





        private void lblLoginAs_Click(object sender, EventArgs e)
        {

        }
    }
}
