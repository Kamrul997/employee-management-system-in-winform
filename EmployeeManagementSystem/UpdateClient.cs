using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Client
{
    public partial class UpdateClient : Form
    {
        public UpdateClient()
        {
            InitializeComponent();
        }

        private void btnBackUpdateClient_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Clients clients3 = new Clients();
            clients3.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
    
}
