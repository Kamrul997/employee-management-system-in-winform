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
            List<ProjectList> projectsList = new List<ProjectList>();
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
            projectsList = db.Query<ProjectList>("EmployeeProjectsSP",
                new { ID = employeeId }, commandType: CommandType.StoredProcedure).ToList();
            db.Close();
            SqlConnection db1 = new SqlConnection(Properties.Settings.Default.con1);
            db1.Open();
            SqlCommand cmd = new SqlCommand("select ProjectID, ProjectName from project", db1);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            db1.Close();
            ((ListBox)checkBoxProject).DataSource = ds;
            ((ListBox)checkBoxProject).DisplayMember = "ProjectName";
            ((ListBox)checkBoxProject).ValueMember = "ProjectID"; 

            for (int i = 0; i < checkBoxProject.Items.Count; i++)
            {   var row = (checkBoxProject.Items[i] as DataRowView).Row;
                int id = row.Field<int>("ProjectID");
                ProjectList project = projectsList.Find(p => p.ProjectID == id);
                if (project!=null)
                {
                    checkBoxProject.SetItemChecked(i, true);
                }
            }

        }

        private void btnBackUpdateEmployee_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EmployeeDetails employeeDetails2 = new EmployeeDetails(employeeId);
            employeeDetails2.Show();
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            ValideFeilds valideFeilds = new ValideFeilds();
            string emailerror = valideFeilds.EmailUpdateValidation(txtEmailEmployee.Text);
            string mobileerror = valideFeilds.MobileUpdateValidation(txtMobileNumberEmployee.Text);
            if (emailerror!="")
            {
                MessageBox.Show(emailerror);
                return;
            }
            else if (mobileerror != "")
            {
                MessageBox.Show(mobileerror);
                return;
            }
            else 
            {
                    int projectId;
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
                List<lastEmp> lastEmps2 = new List<lastEmp>();
                lastEmps2 = db.Query<lastEmp>("UpdateEmployeeSP", new
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

                    }, commandType: CommandType.StoredProcedure).ToList();
                db.Execute("DeleteEmployeeProjectSP", new
                {
                    DeleteID = employeeId,
                    

                }, commandType: CommandType.StoredProcedure);

                foreach (var item in checkBoxProject.CheckedItems)
                {
                    int id = 0;
                    var row = (item as DataRowView).Row;
                    id = row.Field<int>("ProjectID");
                    if (id != 0)
                    {
                        db.Execute("AddNewEmployeeProjectSP", new
                        {
                            EmployeeID = employeeId,
                            ProjectID = id

                        }, commandType: CommandType.StoredProcedure);
                    }

                }
                /*for (int i = 0; i < checkBoxProject.Items.Count; i++)
                {
                    *//*var row = (checkBoxProject.Items[i] as DataRowView).Row;
                    int id = row.Field<int>("ProjectID");
                    ProjectList project = projectsList.Find(p => p.ProjectID == id);
                    if (project == null)
                    {
                        db.Execute("AddNewEmployeeProjectSP", new
                        {
                            EmployeeID = employeeId,
                            ProjectID = id

                        }, commandType: CommandType.StoredProcedure);
                    }*//*

                }*/

                if (lastEmps2[0].ErrorMessage == "")
                    {
                        MessageBox.Show("Employee Successfully Updated");
                        return;
                    }
                    else
                    {
                        MessageBox.Show(lastEmps2[0].ErrorMessage);
                        return;
                    }               
                    db.Close();
            }
        }
    }
}
