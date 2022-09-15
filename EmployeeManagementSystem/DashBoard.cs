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
using Dapper;
using Microsoft.Data.SqlClient;

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

        private void DashBoard_Load(object sender, EventArgs e)
        {
            IDbConnection db = new SqlConnection(Properties.Settings.Default.con1);
            List<DashBoardData> myList = new List<DashBoardData>();
            db.Open();
            myList = db.Query<DashBoardData>("TotalCountSP", commandType: CommandType.StoredProcedure).ToList();
            lebelTotalEmployee.Text = myList[0].TotalEmployee.ToString();
            lebelTotalSalary.Text = myList[0].TotalSalary.ToString();
            lebelTotalClient.Text = myList[0].TotalClient.ToString();
            lebelTotalProject.Text = myList[0].TotalProject.ToString();
            lebelTotalDueProject.Text = myList[0].TotalDueProject.ToString();
            lebelTotalResigned.Text = myList[0].TotalResigned.ToString();
            lebelTotalJoined.Text = myList[0].TotalJoin.ToString();
            labelTodayBirthDay.Text = myList[0].Name.ToString();
            db.Close();
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();            
        }
    }
}
