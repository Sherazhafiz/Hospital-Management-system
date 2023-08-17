namespace HMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            circularProgressBar1.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value =circularProgressBar1.Value+2;
            circularProgressBar1.Text = circularProgressBar1.Value + "%";
            if(circularProgressBar1.Value >= circularProgressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                AdminLogin A1 = new AdminLogin();
                A1.Show();
                //Staff S1 = new Staff();
                //S1.Show();
                //Home H1 = new Home();

                //H1.Show();
            }

        }
    }
}