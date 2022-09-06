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
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections;

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
            IDbConnection db = new SqlConnection(Properties.Settings.Default.con1);
            List<EmployeeDetailsData> EmpDetails = new List<EmployeeDetailsData>();
            db.Open();
            EmpDetails = db.Query<EmployeeDetailsData>("ShowAllEmployeeDetailsSP", new {ID= employeeId }, commandType: CommandType.StoredProcedure).ToList();
            NameValue.Text = EmpDetails[0].NAME;
            AddressValue.Text = EmpDetails[0].Eaddress;
            NumberValue.Text = EmpDetails[0].MoblileNumber;
            EmailValue.Text = EmpDetails[0].Email;
            GenderValue.Text = EmpDetails[0].Gender;
            EmpDOB.Text = EmpDetails[0].BirthDate;
            JoinDateValue.Text = EmpDetails[0].JoinDate;
            ResignDateValue.Text = EmpDetails[0].ResignDate;
            SalaryValue.Text = EmpDetails[0].Salary.ToString();
            CvValue.Text = EmpDetails[0].CV;
            db.Close();

            DisplayData displayData = new DisplayData();
            displayData.DatagridviewDisplaywithparameter("EmployeeAsignProjectSP", employeeId, dataGridView1);
        }
    }
}
