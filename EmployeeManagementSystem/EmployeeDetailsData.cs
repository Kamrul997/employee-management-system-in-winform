using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class EmployeeDetailsData
    {
        public string NAME;
        public string Email;
        public string Eaddress;
        public string MoblileNumber;
        public string CV;
        public string BirthDate;
        public string JoinDate;
        public string ResignDate;
        public string Gender;
        public int Salary;
        
    }
    internal class SingleEmployee
    {
        public string FristName;
        public string LastName;
        public string Email;
        public string Eaddress;
        public string MoblileNumber;
        public string CV;
        public string BirthDate;
        public string JoinDate;
        public string ResignDate;
        public string Gender;
        public int UserID;

    }
    

    public class lastEmp
    {
        public int EmployeeID { get; set; }
        public string ErrorMessage { get; set; }
    }
    public class IsEmailValid
    {
        public int Total { get; set; }
        public string Email { get; set; }
    }
    public class IsMobilelValid
    {
        public int Total { get; set; }
        public string MoblileNumber { get; set; }
    }
}
