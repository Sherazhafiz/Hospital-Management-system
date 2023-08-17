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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int notlogin = 0;
            string username;
            string password;
            SqlConnection c1 = Connectivity.conn();
            string qry = "SELECT * FROM Admin;";
            SqlCommand cmd = new SqlCommand(qry, c1);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                username = reader.GetString("Admin_Name");
                password = reader.GetString("Admin_Password");
                //if(username == null || password == null)
                //{
                //    MessageBox.Show("Enter Correct Values!!!!");
                //}
            

                if(username==textBox1.Text && password == textBox2.Text)
                {
                    MessageBox.Show("Login Success!!!!!!");
                    Home h1=new Home();
                    this.Hide();
                    h1.Show();
                    break;

                }
                else
                {

                    notlogin++;
                }
                if (notlogin == 3)
                {
                    MessageBox.Show("Invalid username or Password!!!!");
                }
            }
            
            
            c1.Close();

                       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
