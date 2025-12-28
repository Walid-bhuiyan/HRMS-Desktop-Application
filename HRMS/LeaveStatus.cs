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
    public partial class LeaveStatus : Form
    {
        public LeaveStatus()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeDashboard ed = new EmployeeDashboard();
            ed.Show();
            this.Hide();
        }
    }
}
