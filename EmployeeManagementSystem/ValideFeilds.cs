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
            else if (email.Length > 40)
            {
                EmailErrorMessage = "Email is too long";
            }

            return EmailErrorMessage;
        }
        public string EmailUpdateValidation(string email)
        {
            string EmailErrorMessage = "";
            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!expr.IsMatch(email))
            {
                EmailErrorMessage = "Invalid Email";
            }
            else if (email.Length > 40)
            {
                EmailErrorMessage = "Email is too long";
            }
            return EmailErrorMessage;
        }
        public string MobileValidation(string mobile)
        {
            string ErrorMessage = "";
            if (mobile.Length > 20)
            {
                ErrorMessage = "Mobile Number is too long";
            }
            return ErrorMessage;
        }
        public string MobileUpdateValidation(string mobile)
        {
            string ErrorMessage = "";
           if (mobile.Length > 20)
            {
                ErrorMessage = "Mobile Number is too long";
            }
            return ErrorMessage;
        }
    }
}
