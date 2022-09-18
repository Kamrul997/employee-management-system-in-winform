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
        DisplayData displayData = new DisplayData();
        private void Clients_Load(object sender, EventArgs e)
        {
            displayData.DatagridviewDisplay("ShowAllClientSP", dataGridViewClient);
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            DeleteData deleteData = new DeleteData();
            deleteData.DeleteItems("DeleteClientSP", dataGridViewClient);

            displayData.DatagridviewDisplay("ShowAllClientSP", dataGridViewClient);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
    
}
