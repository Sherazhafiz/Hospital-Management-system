using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace HMS
{
    public partial class DoctorReport : Form
    {
       

        public DoctorReport()
        {
            InitializeComponent();
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home d1=new Home();
            d1.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1=new Home();
            h1.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string qry = "INSERT INTO DoctorInfo VALUES(@Doctor_Name,@Doctor_CNIC,@Doctor_Age,@DoctorContactDetails,@Doctor_Email,@Doctor_Schedule,@Doctor_Speciality);";
            SqlConnection c1 = Connectivity.conn();

            SqlCommand command = new SqlCommand(qry, c1);
            command.Parameters.AddWithValue("@Doctor_Name", textBox1.Text.Trim());
            command.Parameters.AddWithValue("@Doctor_CNIC", textBox2.Text.Trim());
            command.Parameters.AddWithValue("@Doctor_Age", Convert.ToInt32(textBox3.Text.Trim()));
            command.Parameters.AddWithValue("@DoctorContactDetails", Convert.ToInt64(textBox4.Text.Trim()));
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string queryUpdate = "UPDATE DoctorInfo SET Doctor_Name=@Doctor_Name,Doctor_CNIC=@Doctor_CNIC,Doctor_Age=@Doctor_Age,Doctor_ContactDetails=@Doctor_ContactDetails,Doctor_Email=@Doctor_Email,Doctor_Schedule=@Doctor_Schedule,Doctor_Speciality=@Doctor_Speciality WHERE Doctor_CNIC=@Doctor_CNIC";
            SqlConnection c3 = Connectivity.conn();

            
            SqlCommand sqlCommand = new SqlCommand(queryUpdate, c3);
            sqlCommand.Parameters.AddWithValue("@Doctor_Name", textBox1.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Doctor_CNIC", textBox2.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Doctor_Age", Convert.ToInt32(textBox3.Text.Trim()));
            sqlCommand.Parameters.AddWithValue("@Doctor_ContactDetails", Convert.ToInt64(textBox4.Text.Trim()));
            sqlCommand.Parameters.AddWithValue("@Doctor_Email", textBox7.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Doctor_Schedule", textBox6.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Doctor_Speciality", textBox5.Text.Trim());


            try
            {

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Update Record successfuly.....");
            }
            catch (Exception)
            {
                MessageBox.Show("Error.....");

            }
            
            
            c3.Close();
            this.Close();
            DoctorReport d1 = new DoctorReport();
            d1.Show();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DoctorReport_Load(object sender, EventArgs e)
        {
            string name;
            string CNIC;
            int Age;
            Int64 contact;
            string speciality;
            string schedule;
            string email;
            //string data;

            SqlConnection c1 = Connectivity.conn();
            string qry = "SELECT * FROM DoctorInfo;";
            SqlCommand s1 = new SqlCommand(qry, c1);
            try
            {
                s1.ExecuteNonQuery();
                

            }
            catch (Exception)
            {

                MessageBox.Show("Error!!!!!!");
            }
            SqlDataReader reader = s1.ExecuteReader();

            while (reader.Read())
            {
                name = reader.GetString("Doctor_Name");
                CNIC = reader.GetString("Doctor_CNIC");
                Age = reader.GetInt32("Doctor_Age");
                contact = reader.GetInt64("Doctor_ContactDetails");
                speciality = reader.GetString("Doctor_Speciality");
                schedule = reader.GetString("Doctor_Schedule");
                email = reader.GetString("Doctor_Email");
               // data = string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", name,CNIC,Age,contact,speciality,schedule,email);
                //lstDoctor.Items.Add(data);
                dataGridView1.Rows.Add(name, CNIC, Age, contact, speciality, schedule, email);
            }

            c1.Close ();


        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
       

     
private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();


            }
            catch (Exception)
            {

                MessageBox.Show("Select complete row not column");
            }
            
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlConnection c2 = Connectivity.conn();
            string queryDelete = "DELETE FROM DoctorInfo WHERE Doctor_CNIC=@Doctor_CNIC";
            SqlCommand sqlCommand = new SqlCommand(queryDelete, c2);
            sqlCommand.Parameters.AddWithValue("@Doctor_CNIC", textBox2.Text.Trim());
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
    }
    
}
