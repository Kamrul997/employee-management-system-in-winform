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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
           this.Visible = false;
            AddClient addClient = new AddClient();
            addClient.Show();
        }

        private void btnClientEdit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateClient updateClient = new UpdateClient();
            updateClient.Show();
        }

        private void btnHomeClient_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DashBoard dashBoard4 = new DashBoard();
            dashBoard4.Show();
        }
    }
}
