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
    public partial class Patient_Report : Form
    {
        public Patient_Report()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string queryUpdate = "UPDATE PatientInfo SET Patient_Name=@Patient_Name,Patient_CNIC=@Patient_CNIC,Patient_Age=@Patient_Age,Patient_ContactDetails=@Patient_ContactDetails,Patient_Condition=@Patient_Condition,Patient_Medical_History=@Patient_Medical_History WHERE Patient_CNIC=@Patient_CNIC;";
            SqlConnection c1 = Connectivity.conn();

            SqlCommand command = new SqlCommand(queryUpdate, c1);
            command.Parameters.AddWithValue("@Patient_Name", textBox1.Text.Trim());
            command.Parameters.AddWithValue("@Patient_CNIC", textBox2.Text.Trim());
            command.Parameters.AddWithValue("@Patient_Age", Convert.ToInt32(textBox3.Text.Trim()));
            command.Parameters.AddWithValue("@Patient_ContactDetails", Convert.ToInt64(textBox4.Text.Trim()));
            command.Parameters.AddWithValue("@Patient_Condition", textBox5.Text.Trim());
            command.Parameters.AddWithValue("@Patient_Medical_History", comboBox2.Text);


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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection c2 = Connectivity.conn();
            string queryDelete = "DELETE FROM PatientInfo WHERE Patient_CNIC=@Patient_CNIC";
            SqlCommand sqlCommand = new SqlCommand(queryDelete, c2);
            sqlCommand.Parameters.AddWithValue("@Patient_CNIC", textBox2.Text.Trim());
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string qry = "INSERT INTO PatientInfo VALUES(@Patient_Name,@Patient_CNIC,@Patient_Age,@Patient_ContactDetails,@Patient_Condition,@Patient_Medical_History);";
            SqlConnection c1 = Connectivity.conn();

            SqlCommand command = new SqlCommand(qry, c1);
            command.Parameters.AddWithValue("@Patient_Name", textBox1.Text.Trim());
            command.Parameters.AddWithValue("@Patient_CNIC", textBox2.Text.Trim());
            command.Parameters.AddWithValue("@Patient_Age", Convert.ToInt32(textBox3.Text.Trim()));
            command.Parameters.AddWithValue("@Patient_ContactDetails", Convert.ToInt64(textBox4.Text.Trim()));
            command.Parameters.AddWithValue("@Patient_Condition", textBox5.Text.Trim());
            command.Parameters.AddWithValue("@Patient_Medical_History", comboBox2.Text);


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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1= new Home();
            h1.Show();
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
                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Select complete row not column");
            }


        }

        private void Patient_Report_Load(object sender, EventArgs e)
        {
            string name;
            string CNIC;
            int Age;
            Int64 contact;
            string P_Condition;
            string Med_History;
            //string data;

            SqlConnection c1 = Connectivity.conn();
            string qry = "SELECT * FROM PatientInfo;";
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
                name = reader.GetString("Patient_Name");
                CNIC = reader.GetString("Patient_CNIC");
                Age = reader.GetInt32("Patient_Age");
                contact = reader.GetInt64("Patient_ContactDetails");
                P_Condition = reader.GetString("Patient_Condition");
                Med_History = reader.GetString("Patient_Medical_History");
               
                // data = string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", name,CNIC,Age,contact,speciality,schedule,email);
                //lstDoctor.Items.Add(data);
                dataGridView1.Rows.Add(name, CNIC, Age, contact, P_Condition, Med_History);
            }
            c1.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1= new Home();
            h1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
