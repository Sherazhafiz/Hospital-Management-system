using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace HMS
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Report p1=new Patient_Report();
            p1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h1=new Home();
            h1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text=null;
            textBox3.Text=null;
            textBox4.Text=null;
            textBox5.Text=null;
            comboBox2.Text=null;
        }
    }
}
