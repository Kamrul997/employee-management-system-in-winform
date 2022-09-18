using Dapper;
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

namespace EmployeeManagementSystem
{
    public partial class UpdateEmployee : Form
    {
        public int employeeId;
        public UpdateEmployee(int EmpID)
        {
            this.employeeId = EmpID;
            InitializeComponent();
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            EmployeeID.Text = employeeId.ToString();
            EmployeeID.ReadOnly = true;
            IDbConnection db = new SqlConnection(Properties.Settings.Default.con1);
            List<SingleEmployee> EmpDetails = new List<SingleEmployee>();
            db.Open();
            EmpDetails = db.Query<SingleEmployee>("ShowAllSingleEmployeeSP", new { ID = employeeId }, commandType: CommandType.StoredProcedure).ToList();
            txtFirstNameEmployee.Text = EmpDetails[0].FristName;
            txtLastNameEmployee.Text = EmpDetails[0].LastName;
            txtAddressEmployee.Text = EmpDetails[0].Eaddress;
            txtCvEmployee.Text = EmpDetails[0].CV;
            txtMobileNumberEmployee.Text = EmpDetails[0].MoblileNumber;
            txtEmailEmployee.Text = EmpDetails[0].Email;
            string GenderValue = EmpDetails[0].Gender;
            if (GenderValue == radioButtonMaleEmployee.Text)
            {
                radioButtonMaleEmployee.Checked = true;
            }
            else 
            {
                radioButtonFemaleEmployee.Checked = true;
            }
            dateTimeBirthEmployee.Text = EmpDetails[0].BirthDate;
            dateTimeJoinEmployee.Text = EmpDetails[0].JoinDate;
            dateTimeResignEmployee.Text = EmpDetails[0].ResignDate;
           // SalaryValue.Text = EmpDetails[0].UserID.ToString();
            
            db.Close();
            SqlConnection db1 = new SqlConnection(Properties.Settings.Default.con1);
            db1.Open();
            SqlCommand cmd = new SqlCommand("select ProjectID, ProjectName from project", db1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            db1.Close();
            comboBoxProject.DataSource = ds.Tables[0];
            comboBoxProject.DisplayMember = "ProjectName";
            comboBoxProject.ValueMember = "ProjectID";
            comboBoxProject.Text = "--Select Project--";
        }

        private void btnBackUpdateEmployee_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EmployeeDetails employeeDetails2 = new EmployeeDetails(employeeId);
            employeeDetails2.Show();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            string JoinDateValue = dateTimeJoinEmployee.Value.ToShortDateString();
            string BirthDateValue = dateTimeBirthEmployee.Value.ToShortDateString();
            string ResignDateValue = dateTimeResignEmployee.Value.ToShortDateString();
            string genderValue = "";
            bool isChecked = radioButtonMaleEmployee.Checked;
            if (isChecked)
                genderValue = radioButtonMaleEmployee.Text;
            else
                genderValue = radioButtonFemaleEmployee.Text;
            IDbConnection db = new SqlConnection(Properties.Settings.Default.con1);
            db.Open();
            db.Execute("UpdateEmployeeSP", new
            {
                EMPLOYEEID = employeeId,
                FristName = txtFirstNameEmployee.Text,
                LastName = txtLastNameEmployee.Text,
                Email = txtEmailEmployee.Text,
                MoblileNumber = txtMobileNumberEmployee.Text,
                CV = txtCvEmployee.Text,
                Eaddress = txtAddressEmployee.Text,
                BirthDate = BirthDateValue,
                JoinDate = JoinDateValue,
                ResignDate = ResignDateValue,
                UserID = 100,
                Gender = genderValue

            }, commandType: CommandType.StoredProcedure);
            int projectId = int.Parse(comboBoxProject.GetItemText(comboBoxProject.SelectedValue));
            db.Execute("AddNewEmployeeProjectSP", new
            {
                EmployeeID = employeeId,
                ProjectID = projectId

            }, commandType: CommandType.StoredProcedure);
            MessageBox.Show("Employee Successfully Updated");
            db.Close();
        }
    }
}
