using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EmployeeManagementSystem
{
    public class ValideFeilds
    {
        
        public string EmailValidation(string email)
        {
            
            string EmailErrorMessage = "";
            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!expr.IsMatch(email))
            {
                EmailErrorMessage = "Invalid Email";
            }
           
            return EmailErrorMessage;
        }
        public string EmailUpdateValidation(string email)
        {
            int total;
            string CurrentEmail = "";
            string EmailErrorMessage = "";
            IDbConnection db = new SqlConnection(Properties.Settings.Default.con1);
            List<IsEmailValid> myList = new List<IsEmailValid>();
            db.Open();
            myList = db.Query<IsEmailValid>("EmailValidInput", new { Email = email }, commandType: CommandType.StoredProcedure).ToList();

            if (myList.Count == 0)
            {
                total = 0;
            }
            else 
            {
                total = myList[0].Total;
                CurrentEmail = myList[0].Email;
            }
            
            db.Close();
            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!expr.IsMatch(email))
            {
                EmailErrorMessage = "Invalid Email";
            }
            else if (CurrentEmail !="" || email != CurrentEmail)
            {
                EmailErrorMessage = "Enter new Email";
            }
            else if (total > 1)
            {
                EmailErrorMessage = "Enter the Previous Email Or a new Email";
            }
            else if (email.Length > 40)
            {
                EmailErrorMessage = "Email is too long";
            }
            return EmailErrorMessage;
        }
        public string MobileValidation(string mobile)
        {
            int total;
            string ErrorMessage = "";
            IDbConnection db = new SqlConnection(Properties.Settings.Default.con1);
            List<IsMobilelValid> myList = new List<IsMobilelValid>();
            db.Open();
            myList = db.Query<IsMobilelValid>("MobileValidInput", new { Mobile = mobile }, commandType: CommandType.StoredProcedure).ToList();
            total = myList.Count;
            db.Close();            
            if (total != 0)
            {
                ErrorMessage = "Mobile Number Already Exist";
            }
            else if (mobile.Length > 20)
            {
                ErrorMessage = "Mobile Number is too long";
            }
            return ErrorMessage;
        }
        public string MobileUpdateValidation(string mobile)
        {
            int total;
            string Currentmobile = "";
            string ErrorMessage = "";
            IDbConnection db = new SqlConnection(Properties.Settings.Default.con1);
            List<IsMobilelValid> myList = new List<IsMobilelValid>();
            db.Open();
            myList = db.Query<IsMobilelValid>("MobileValidInput", new { Mobile = mobile}, commandType: CommandType.StoredProcedure).ToList();

            if (myList.Count == 0)
            {
                total = 0;
            }
            else
            {
                total = myList[0].Total;
                Currentmobile = myList[0].MoblileNumber;
            }
            db.Close();
            if (Currentmobile != "" || mobile != Currentmobile)
            {
                ErrorMessage = "Enter the Previous Mobile Number Or a new Mobile Number";
            }
            else if (total > 1)
            {
                ErrorMessage = "Enter the Previous Mobile Number Or a new Mobile Number";
            }
            else if (mobile.Length > 20)
            {
                ErrorMessage = "Mobile Number is too long";
            }
            return ErrorMessage;
        }
    }
}
