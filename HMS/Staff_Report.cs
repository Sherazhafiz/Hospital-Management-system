using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Staff_Report : Form
    {
        public Staff_Report()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1=new Home();
            h1.Show();  
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Staff_Report_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string queryUpdate = "UPDATE Staff SET Staff_CNIC=@Staff_CNIC,Staff_Name=@Staff_Name,Staff_Role=@Staff_Role,Staff_ContactDetails=@Staff_ContactDetails;";
            SqlConnection c1 = Connectivity.conn();

            SqlCommand command = new SqlCommand(queryUpdate, c1);
            command.Parameters.AddWithValue("@Staff_CNIC", tbCNIC.Text.Trim());
            command.Parameters.AddWithValue("@Staff_Name", tbName.Text.Trim());
            command.Parameters.AddWithValue("@Staff_Role", Convert.ToInt32(tbContact.Text.Trim()));
            command.Parameters.AddWithValue("@Staff_ContactDetails", tbRole.Text.Trim());
           

            try
            {
                command.ExecuteNonQuery();
                // Insert, Update, Delete
                MessageBox.Show("Update Record successfuly.....");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!!!!!!!!!!!");
            }
            c1.Close();

        }

        private void tbCNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection c2 = Connectivity.conn();
            string queryDelete = "DELETE FROM Staff WHERE Staff_CNIC=@Staff_CNIC";
            SqlCommand sqlCommand = new SqlCommand(queryDelete, c2);
            sqlCommand.Parameters.AddWithValue("@Staff_CNIC", tbCNIC.Text.Trim());
            try
            {

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Record Delete successfuly.....");
            }
            catch (Exception)
            {
                MessageBox.Show("Error.....");

            }
            c2.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
