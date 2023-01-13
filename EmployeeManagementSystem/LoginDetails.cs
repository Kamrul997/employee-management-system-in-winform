using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class LoginID
    {
        public static int LoginUserID { get;  set; }        
      
    }
    public class LoginUserDetails
    {
        public int UserID; 
        public string Email;
        public string uPassword;
    }
  
}
