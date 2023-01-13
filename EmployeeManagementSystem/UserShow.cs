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
            if (dataGridViewUser.Rows[0].Selected == true)
            {
                MessageBox.Show("You cannot delete this User");
            }
            else
            {
                DeleteData deleteData = new DeleteData();
                deleteData.DeleteItems("DeleteUserSP", dataGridViewUser);
                displayData.DatagridviewDisplay("ShowAllUsersSP", dataGridViewUser);
            }            
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            int UserID = 0;
            int TotalRow = dataGridViewUser.Rows.Count;
            for (int i = 0; i < TotalRow; i++)
            {
                DataGridViewRow gridr = dataGridViewUser.Rows[i];
                if (gridr.Selected == true)
                {
                    UserID = Int32.Parse(gridr.Cells[0].FormattedValue.ToString());
                }
            }
            this.Visible = false;
            UpdateUser updateUser = new UpdateUser(UserID);
            updateUser.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DashBoard dashBoard2 = new DashBoard();
            dashBoard2.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }
        DisplayData displayData = new DisplayData();
        private void UserShow_Load(object sender, EventArgs e)
        {
            displayData.DatagridviewDisplay("ShowAllUsersSP", dataGridViewUser);
        }
    }
    
}
