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
            this.Visible = false;
            EmployeeDetails empDetails = new EmployeeDetails();
            empDetails.Show();
        }

        private void btnHomeEmployee_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DashBoard empDashBoard = new DashBoard();
            empDashBoard.Show();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            DisplayData displayData = new DisplayData();
            displayData.DatagridviewDisplay("ShowEmployeeNameAndContactSP", dataGridViewEmployee);
            
        }
    }
}
