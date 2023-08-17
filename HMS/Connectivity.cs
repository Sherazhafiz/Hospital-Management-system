using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HMS
{
    internal class Connectivity
    {
        public static SqlConnection conn()
        {
            string connection = "Data Source=DESKTOP-MP3S7K5\\SQLEXPRESS;Initial Catalog=HMS;Integrated Security=True";
            SqlConnection Connect = new SqlConnection(connection);
            try
            {  
                Connect.Open();

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Can't Connected!!!");
            }
            return Connect;

        }

        

        

    }
}
