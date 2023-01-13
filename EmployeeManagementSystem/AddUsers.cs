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
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
        }

        private void btnBackAddNewUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UserShow userShow2 = new UserShow();
            userShow2.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void AddUsers_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitUser_Click(object sender, EventArgs e)
        {
            ValideFeilds valideFeilds = new ValideFeilds();
            string emailerror = valideFeilds.EmailValidation(txtEmailUser.Text);
            string mobileerror = valideFeilds.MobileValidation(txtMobileNumberUser.Text);
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
            else if (txtConfirmPass.Text != txtPass.Text)
            {
                MessageBox.Show("enter correct password");
                return;
            }
            else
            {

                string CreatedDateValue = dateTimeCreatedAtUser.Value.ToShortDateString();

                string genderValue = "";
                bool isChecked = radioButtonMaleUser.Checked;
                if (isChecked)
                {
                    genderValue = radioButtonMaleUser.Text;
                }
                else
                {
                    genderValue = radioButtonFemaleUser.Text;
                }
                IDbConnection db = new SqlConnection(Properties.Settings.Default.con1);
                db.Open();
                List<UserAdd> lastUser = new List<UserAdd>();
                lastUser = db.Query<UserAdd>("AddNewUserSP", new
                {
                    FristName = txtFirstNameUser.Text,
                    LastName = txtLastNameUser.Text,
                    Designation = comboBoxDesignation.SelectedItem.ToString(),
                    Email = txtEmailUser.Text,
                    uPassword = txtPass.Text,
                    CreatedAt = CreatedDateValue,
                    UpdatedOn = "",
                    CreatedBy = LoginID.LoginUserID.ToString(),
                    UpdatedBy = "",
                    Uaddress = txtAddressUser.Text,
                    Photo = txtPhotoUser.Text,
                    MoblileNumber = txtMobileNumberUser.Text,
                    Gender = genderValue
                }, commandType: CommandType.StoredProcedure).ToList();
                int lastUserID = lastUser[0].UserID;

                if (lastUser[0].ErrorMessage == null)
                {
                    MessageBox.Show("Added a new User");
                    return;
                }
                else
                {
                    MessageBox.Show(lastUser[0].ErrorMessage);
                    return;
                }
                db.Close();
            }
        }
    }
 }
    

