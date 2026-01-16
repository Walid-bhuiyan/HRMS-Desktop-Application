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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed=new EmployeeDashboard();
            ed.Show();
            this.Hide();
        }
    }
}
