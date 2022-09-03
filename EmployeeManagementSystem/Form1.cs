using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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
            this.Visible = false;
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}