using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class DisplayData
    {
        public void DatagridviewDisplay(string SPname,DataGridView GridviewName)
        {
            SqlDataAdapter sda = new SqlDataAdapter(SPname, Properties.Settings.Default.con1);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridviewName.DataSource = dt.DefaultView;
        }
    }
}
