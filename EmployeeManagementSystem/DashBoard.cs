using EmployeeManagementSystem.Client;
using EmployeeManagementSystem.Salary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UserShow userShow = new UserShow();
            userShow.Show();           
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            project projectshow = new project();
            projectshow.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Clients client = new Clients();
            client.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Employees employeesshow = new Employees();
            employeesshow.Show();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SalaryShow salary = new SalaryShow();
            salary.Show();
        }
    }
}
