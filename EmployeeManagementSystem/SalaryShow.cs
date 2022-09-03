using EmployeeManagementSystem.Client;
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
    public partial class SalaryShow : Form
    {
        public SalaryShow()
        {
            InitializeComponent();
        }

        private void btnAddSalary_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddSalary addSalary = new AddSalary();
            addSalary.Show();
        }

        private void btnSalaryEdit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SalaryUpdate salaryUpdate = new SalaryUpdate();
            salaryUpdate.Show();
        }

        private void btnHomeSalary_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DashBoard dashBoard5 = new DashBoard();
            dashBoard5.Show();
        }
    }
}
