using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UpdateUser : Form
    {
        public int UserID;
        public UpdateUser(int id)
        {
            this.UserID = id;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UserShow userShow1 = new UserShow();
            userShow1.Show();
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            txtUserID.Text = UserID.ToString();
            txtUserID.ReadOnly = true;
            IDbConnection db = new SqlConnection(Properties.Settings.Default.con1);
            List<SingeUser> Userdetails = new List<SingeUser>();            
            db.Open();
            Userdetails = db.Query<SingeUser>("ShowAllSingleUserSP", new { ID = UserID }, commandType: CommandType.StoredProcedure).ToList();
            txtUpdateFirstNameUser.Text = Userdetails[0].FristName;
            txtUpdateLastNameUser.Text = Userdetails[0].LastName;
            txtUpdateAddressUser.Text = Userdetails[0].Uaddress;            
            txtUpdateMobileNumberUser.Text = Userdetails[0].MoblileNumber;
            txtUpdateEmailUser.Text = Userdetails[0].Email;
            txtUpdatePhotoUser.Text = Userdetails[0].Photo;
            string UserDesignation = Userdetails[0].Designation;

            string GenderValue = Userdetails[0].Gender;
            if (GenderValue == radioButtonUpdateMaleUser.Text)
            {
                radioButtonUpdateMaleUser.Checked = true;
            }
            else
            {
                radioButtonUpdateFemaleUser.Checked = true;
            }            
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
