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
    public partial class project : Form
    {
        public project()
        {
            InitializeComponent();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddProjects addProjects = new AddProjects();
            addProjects.Show();
        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateProject updateProject = new UpdateProject();
            updateProject.Show();
        }

        private void btnHomeProject_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DashBoard dashBoard3 = new DashBoard();
            dashBoard3.Show();
        }
    }
}
