using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EmployeeManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            IDbConnection db = new SqlConnection(Properties.Settings.Default.con1);
            List<LoginUserDetails> myList = new List<LoginUserDetails>();
            db.Open();
            myList = db.Query<LoginUserDetails>("LoginIdSP", new { Email = LoginEmailBox.Text }, commandType: CommandType.StoredProcedure).ToList();
            if (LoginEmailBox.Text == "" || LogonPassBox.Text == "")
            {
                MessageBox.Show("Input your login data");
                return;
            }
            else if (myList.Count == 0)
            {
                MessageBox.Show("Invalid Email or Password");
                return;
            }
            string LogEmail = myList[0].Email.ToString();
            string LogPass = myList[0].uPassword.ToString();

            if (LoginEmailBox.Text == LogEmail && LogonPassBox.Text == LogPass)
            {
                this.Visible = false;
                DashBoard dashBoard1 = new DashBoard();
                dashBoard1.Show();
                LoginID.LoginUserID = myList[0].UserID;
            }
            else
            {
                MessageBox.Show("Invalid Email or Password");
                return;

            }
            db.Close();

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}