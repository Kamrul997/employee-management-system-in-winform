using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Salary
{
    public partial class AddSalary : Form
    {
        public AddSalary()
        {
            InitializeComponent();
        }

        private void btnBackAddSalary_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SalaryShow salaryShow2 = new SalaryShow();
            salaryShow2.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
    }
}
