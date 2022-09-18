﻿using Dapper;
using EmployeeManagementSystem.Salary;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EmployeeManagementSystem
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnBackAddEmployee_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Employees employees2 = new Employees();
            employees2.Show();
        }

        private void btnSubmitEmployee_Click(object sender, EventArgs e)
        {
            string JoinDateValue = dateTimeJoinEmployee.Value.ToShortDateString();
            string BirthDateValue = dateTimeBirthEmployee.Value.ToShortDateString();
            string ResignDateValue = "";
            string genderValue = "";
            bool isChecked = radioButtonMaleEmployee.Checked;
            if (isChecked)
                genderValue = radioButtonMaleEmployee.Text;
            else
                genderValue = radioButtonFemaleEmployee.Text;
            IDbConnection db = new SqlConnection(Properties.Settings.Default.con1);
            db.Open();
            db.Execute("AddNewEmployeeSP",new
            {
                FristName = txtFirstNameEmployee.Text,
                LastName = txtLastNameEmployee.Text,
                Email = txtEmailEmployee.Text,
                MoblileNumber = txtMobileNumberEmployee.Text,
                CV = txtCvEmployee.Text,
                Eaddress = txtAddressEmployee.Text,
                BirthDate = BirthDateValue,
                JoinDate = JoinDateValue,
                ResignDate = ResignDateValue,
                UserID = LoginID.LoginUserID,
                Gender = genderValue

            }, commandType: CommandType.StoredProcedure); 
            List<lastEmp> lastEmps = new List<lastEmp>();
            lastEmps = db.Query<lastEmp>("LastID", commandType: CommandType.StoredProcedure).ToList();
            int LastEmpID = lastEmps[0].LastID;
            int projectId = int.Parse(comboBoxProject.GetItemText(comboBoxProject.SelectedValue));
            db.Execute("AddNewEmployeeProjectSP", new
            {
                EmployeeID = LastEmpID,
                ProjectID = projectId

            }, commandType: CommandType.StoredProcedure);
            MessageBox.Show("Added a new Employee");
            db.Close();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            radioButtonMaleEmployee.Checked = true;
            SqlConnection db = new SqlConnection(Properties.Settings.Default.con1);
            db.Open();
            SqlCommand cmd = new SqlCommand("select ProjectID, ProjectName from project",db);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            db.Close();
            comboBoxProject.DataSource = ds.Tables[0];
            comboBoxProject.DisplayMember = "ProjectName";
            comboBoxProject.ValueMember = "ProjectID";
            comboBoxProject.Text = "--Select Project--";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
