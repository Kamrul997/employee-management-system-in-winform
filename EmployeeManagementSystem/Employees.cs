﻿using EmployeeManagementSystem.Salary;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmployeeManagementSystem
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void btnDetailsEmployee_Click(object sender, EventArgs e)
        {
            int employeeID = 0;
            int TotalRow = dataGridViewEmployee.Rows.Count;
            for (int i = 0; i < TotalRow; i++)
            {                
                DataGridViewRow gridr = dataGridViewEmployee.Rows[i];
                if (gridr.Selected == true)
                {
                    employeeID = Int32.Parse(gridr.Cells[0].FormattedValue.ToString());
                }
            }
            this.Visible = false;
            EmployeeDetails empDetails = new EmployeeDetails(employeeID);
            empDetails.Show();
        }

        private void btnHomeEmployee_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DashBoard empDashBoard = new DashBoard();
            empDashBoard.Show();
        }
         DisplayData displayData = new DisplayData();
        private void Employees_Load(object sender, EventArgs e)
        {
           
            displayData.DatagridviewDisplay("ShowEmployeeNameAndContactSP", dataGridViewEmployee);
            
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            DeleteData deleteData = new DeleteData();
            deleteData.DeleteItems("DeleteEmployeeSP", dataGridViewEmployee);

            displayData.DatagridviewDisplay("ShowEmployeeNameAndContactSP", dataGridViewEmployee);
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
    
}
