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
    public partial class UserShow : Form
    {
        public UserShow()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Visible= false;
            AddUsers addUsers = new AddUsers();
            addUsers.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateUser updateUser = new UpdateUser();
            updateUser.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DashBoard dashBoard2 = new DashBoard();
            dashBoard2.Show();
        }
    }
}
