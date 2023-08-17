using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            circularProgressBar1.Value = 0;
            circularProgressBar2.Value = 0;
            timer1.Start();
        }

        private void btnAdoc_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_Report p1=new Patient_Report();
            p1.Show();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Report sf1= new Staff_Report();   
            sf1.Show();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Doctor D1 = new Doctor();
            this.Hide();
            D1.Show();
        }

        private void btnAdoc_MouseEnter(object sender, EventArgs e)
        {
            btnAdoc.ForeColor=Color.Yellow;
            btnAdoc.IconColor = Color.Yellow;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Patient P1 = new Patient();
            this.Hide();
            P1.Show();
        }

        private void iconButton2_MouseEnter(object sender, EventArgs e)
        {
            btnAPat.ForeColor = Color.Yellow;
            btnAPat.IconColor = Color.Yellow;
        }

        private void iconButton3_MouseEnter(object sender, EventArgs e)
        {
            btnRDoctor.ForeColor = Color.Yellow;
            btnRDoctor.IconColor = Color.Yellow;
        }

        private void btnRPatient_MouseEnter(object sender, EventArgs e)
        {
            btnRPatient.ForeColor = Color.Yellow;
            btnRPatient.IconColor = Color.Yellow;
        }

        private void btnRStaff_MouseEnter(object sender, EventArgs e)
        {
            btnRStaff.ForeColor = Color.Yellow;
            btnRStaff.IconColor = Color.Yellow;
        }

        private void btnAdoc_MouseLeave(object sender, EventArgs e)
        {
            btnAdoc.ForeColor = Color.DodgerBlue;
            btnAdoc.IconColor = Color.DodgerBlue;
        }

        private void btnAPat_MouseLeave(object sender, EventArgs e)
        {
            btnAPat.ForeColor = Color.DodgerBlue;
            btnAPat.IconColor = Color.DodgerBlue;
        }

        private void btnRDoctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorReport d1=new DoctorReport();
            d1.Show();
        }

        private void btnRDoctor_MouseLeave(object sender, EventArgs e)
        {
            btnRDoctor.ForeColor = Color.DodgerBlue;
            btnRDoctor.IconColor = Color.DodgerBlue;
        }

        private void btnRPatient_MouseLeave(object sender, EventArgs e)
        {
            btnRPatient.IconColor= Color.DodgerBlue;
            btnRPatient.ForeColor=Color.DodgerBlue;

        }

        private void btnRStaff_MouseLeave(object sender, EventArgs e)
        {
            btnRStaff.ForeColor = Color.DodgerBlue;
            btnRStaff.IconColor=Color.DodgerBlue;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Red;
            btnExit.IconColor = Color.Red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.IconColor = Color.DodgerBlue;
            btnExit.ForeColor = Color.DodgerBlue;
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 20;
            circularProgressBar2.Value += 20;
            if (circularProgressBar1.Value >= circularProgressBar1.Maximum)
            {
                timer1.Stop();
                circularProgressBar1.Value = circularProgressBar1.Maximum;
                circularProgressBar2.Value = circularProgressBar2.Maximum;
            }
        }

        private void circularProgressBar2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
