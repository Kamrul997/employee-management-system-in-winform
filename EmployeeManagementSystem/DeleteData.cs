using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeManagementSystem
{
    public class DeleteData
    {
        public void DeleteItems(string DeleteSPname,DataGridView dataGridViewName)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.con1);
            conn.Open();
            int TotalRow = dataGridViewName.Rows.Count;
            for (int i = 0; i < TotalRow; i++)
            {
                DataGridViewRow gridr = dataGridViewName.Rows[i];
                if (gridr.Selected == true)
                {                                
                   SqlCommand spcmd = new SqlCommand(DeleteSPname , conn);
                   spcmd.CommandType = CommandType.StoredProcedure;
                   spcmd.Parameters.AddWithValue("@DeleteID", SqlDbType.Int).Value = gridr.Cells[0].Value;                    
                   spcmd.ExecuteNonQuery();
                }
            }
            conn.Close();
        }
    }
}
