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
            lblerrorpass.Text = lblerroruname.Text = "";
            if (txtuname.Text == "")
                lblerroruname.Text = "***Please enter username";
            if (txtpass.Text == "")
                lblerrorpass.Text = "***Please enter password";
            if (txtuname.Text != "" && txtpass.Text != "")
            {
                if (txtuname.Text == uname && txtpass.Text == pass)
                {
                    MessageBox.Show("Successfully logged in");
                    Form h = new Form();
                    h.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Invalid username or password");
            }

        }

        private void lblLoginAs_Click(object sender, EventArgs e)
        {

        }
    }
}
