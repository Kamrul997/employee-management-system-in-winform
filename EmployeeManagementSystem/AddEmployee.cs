using Dapper;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
            ValideFeilds valideFeilds = new ValideFeilds();
            string emailerror = valideFeilds.EmailValidation(txtEmailEmployee.Text);
            string mobileerror = valideFeilds.MobileValidation(txtMobileNumberEmployee.Text);
            if (emailerror != "")
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
                int projectId = 0;
                string JoinDateValue = dateTimeJoinEmployee.Value.ToShortDateString();
                string BirthDateValue = dateTimeBirthEmployee.Value.ToShortDateString();
                string ResignDateValue = "";
                string genderValue = "";
                bool isChecked = radioButtonMaleEmployee.Checked;
                if (isChecked)
                { genderValue = radioButtonMaleEmployee.Text; }
                else
                { genderValue = radioButtonFemaleEmployee.Text;}
                if (comboBoxProject.GetItemText(comboBoxProject.SelectedValue) == "")
                {
                    projectId = 0;
                }
                else
                {
                    projectId = int.Parse(comboBoxProject.GetItemText(comboBoxProject.SelectedValue));
                }
                
                IDbConnection db = new SqlConnection(Properties.Settings.Default.con1);
                db.Open();

                List<lastEmp> lastEmps = new List<lastEmp>();

                lastEmps = db.Query<lastEmp>("AddNewEmployeeSP", new{
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
                
                int LastEmpID = lastEmps[0].EmployeeID;
                
                if (projectId >0)
                {
                    db.Execute("AddNewEmployeeProjectSP", new
                    {
                        EmployeeID = LastEmpID,
                        ProjectID = projectId

                    }, commandType: CommandType.StoredProcedure);
                }
                
                if (lastEmps[0].ErrorMessage == null)
                {
                    MessageBox.Show("Added a new Employee");
                    return;
                }
                else
                {
                    MessageBox.Show(lastEmps[0].ErrorMessage);
                    return;
                }            
            db.Close();
            }
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
            comboBoxProject.SelectedIndex = -1;
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
