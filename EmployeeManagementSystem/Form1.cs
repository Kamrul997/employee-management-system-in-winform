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
    }
}