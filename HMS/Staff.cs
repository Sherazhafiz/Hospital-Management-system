using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace HMS
{
    public partial class Staff : Form
    {
        
        public Staff()
        {
            InitializeComponent();



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-58UPDG1;Initial Catalog=HMS_Project;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                string name = tbName.Text;
                int CNIC = Convert.ToInt32(tbCNIC.Text);
                string Role = tbRole.Text;
                int Contact = Convert.ToInt32(tbContact.Text);
                connection.Open();
                
                SqlCommand sqlCommand;
                //string Query = "INSERT INTO Staff VALUES(331024444,'Name','ABC',0300);";
                

                string Query = "INSERT INTO Staff VALUES(@CNIC,name,Role,Contact)";
                sqlCommand = new SqlCommand(Query, connection);
                MessageBox.Show("Data Sent.");
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error.");
            }

        }
    }
}
