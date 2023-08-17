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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorReport dr1=new DoctorReport();
            dr1.Show();
                      
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home h1= new Home();
            this.Hide();
            h1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string qry = "INSERT INTO DoctorInfo VALUES(@Doctor_Name,@Doctor_CNIC,@Doctor_Age,@DoctorContactDetails,@Doctor_Email,@Doctor_Schedule,@Doctor_Speciality);";
                SqlConnection c1 = Connectivity.conn();

                SqlCommand command = new SqlCommand(qry, c1);
                command.Parameters.AddWithValue("@Doctor_Name",textBox1.Text.Trim());
                command.Parameters.AddWithValue("@Doctor_CNIC",textBox2.Text.Trim());
                command.Parameters.AddWithValue("@Doctor_Age", Convert.ToInt32( textBox3.Text.Trim()));
                command.Parameters.AddWithValue("@DoctorContactDetails", Convert.ToInt64( textBox4.Text.Trim()));
                command.Parameters.AddWithValue("@Doctor_Email", textBox7.Text.Trim());
                command.Parameters.AddWithValue("@Doctor_Schedule", textBox6.Text.Trim());
                command.Parameters.AddWithValue("@Doctor_Speciality", textBox5.Text.Trim());
                
                try
                {
                command.ExecuteNonQuery();
                // Insert, Update, Delete
                MessageBox.Show("Record added successfully");
                }
                catch (Exception)
                {
                    MessageBox.Show("Record can't be added!!!");
                }
                 c1.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            textBox7.Text = null;
        }
    }
}
