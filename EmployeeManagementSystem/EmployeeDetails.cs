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
    public partial class EmployeeDetails : Form
    {
        public int employeeId;
        public EmployeeDetails(int id)
        {
            this.employeeId = id;
            InitializeComponent();
        }              

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateEmployee updateEmployee = new UpdateEmployee();
            updateEmployee.Show();
        }

        private void btnBackEmployee_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Employees employees3 = new Employees();
            employees3.Show();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            IDValue.Text = employeeId.ToString();
        }
    }
}
