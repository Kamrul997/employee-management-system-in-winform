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
    public partial class AddProjects : Form
    {
        public AddProjects()
        {
            InitializeComponent();
        }

        private void btnBackAddProject_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            project project2 = new project();
            project2.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
