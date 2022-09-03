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
    public partial class SalaryUpdate : Form
    {
        public SalaryUpdate()
        {
            InitializeComponent();
        }

        private void btnBackSalaryUpdate_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SalaryShow salaryShow3 = new SalaryShow();
            salaryShow3.Show();
        }
    }
}
