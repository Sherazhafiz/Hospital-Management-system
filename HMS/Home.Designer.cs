namespace HMS
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnRStaff = new FontAwesome.Sharp.IconButton();
            this.btnRPatient = new FontAwesome.Sharp.IconButton();
            this.btnRDoctor = new FontAwesome.Sharp.IconButton();
            this.btnAPat = new FontAwesome.Sharp.IconButton();
            this.btnAdoc = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lblRights = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnRStaff);
            this.panel1.Controls.Add(this.btnRPatient);
            this.panel1.Controls.Add(this.btnRDoctor);
            this.panel1.Controls.Add(this.btnAPat);
            this.panel1.Controls.Add(this.btnAdoc);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 735);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(3, 677);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 46);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // btnRStaff
            // 
            this.btnRStaff.FlatAppearance.BorderSize = 0;
            this.btnRStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRStaff.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRStaff.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.btnRStaff.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRStaff.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRStaff.Location = new System.Drawing.Point(0, 528);
            this.btnRStaff.Name = "btnRStaff";
            this.btnRStaff.Size = new System.Drawing.Size(197, 59);
            this.btnRStaff.TabIndex = 5;
            this.btnRStaff.Text = "StaffReport";
            this.btnRStaff.UseVisualStyleBackColor = true;
            this.btnRStaff.Click += new System.EventHandler(this.iconButton5_Click);
            this.btnRStaff.MouseEnter += new System.EventHandler(this.btnRStaff_MouseEnter);
            this.btnRStaff.MouseLeave += new System.EventHandler(this.btnRStaff_MouseLeave);
            // 
            // btnRPatient
            // 
            this.btnRPatient.FlatAppearance.BorderSize = 0;
            this.btnRPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRPatient.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRPatient.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.btnRPatient.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRPatient.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRPatient.Location = new System.Drawing.Point(0, 437);
            this.btnRPatient.Name = "btnRPatient";
            this.btnRPatient.Size = new System.Drawing.Size(197, 59);
            this.btnRPatient.TabIndex = 4;
            this.btnRPatient.Text = "PatientReport";
            this.btnRPatient.UseVisualStyleBackColor = true;
            this.btnRPatient.Click += new System.EventHandler(this.iconButton4_Click);
            this.btnRPatient.MouseEnter += new System.EventHandler(this.btnRPatient_MouseEnter);
            this.btnRPatient.MouseLeave += new System.EventHandler(this.btnRPatient_MouseLeave);
            // 
            // btnRDoctor
            // 
            this.btnRDoctor.FlatAppearance.BorderSize = 0;
            this.btnRDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRDoctor.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRDoctor.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.btnRDoctor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRDoctor.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRDoctor.Location = new System.Drawing.Point(0, 357);
            this.btnRDoctor.Name = "btnRDoctor";
            this.btnRDoctor.Size = new System.Drawing.Size(197, 59);
            this.btnRDoctor.TabIndex = 3;
            this.btnRDoctor.Text = "DoctorReport";
            this.btnRDoctor.UseVisualStyleBackColor = true;
            this.btnRDoctor.Click += new System.EventHandler(this.btnRDoctor_Click);
            this.btnRDoctor.MouseEnter += new System.EventHandler(this.iconButton3_MouseEnter);
            this.btnRDoctor.MouseLeave += new System.EventHandler(this.btnRDoctor_MouseLeave);
            // 
            // btnAPat
            // 
            this.btnAPat.FlatAppearance.BorderSize = 0;
            this.btnAPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAPat.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAPat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAPat.IconChar = FontAwesome.Sharp.IconChar.BandAid;
            this.btnAPat.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAPat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAPat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAPat.Location = new System.Drawing.Point(0, 266);
            this.btnAPat.Name = "btnAPat";
            this.btnAPat.Size = new System.Drawing.Size(197, 59);
            this.btnAPat.TabIndex = 2;
            this.btnAPat.Text = "Add Patient";
            this.btnAPat.UseVisualStyleBackColor = true;
            this.btnAPat.Click += new System.EventHandler(this.iconButton2_Click);
            this.btnAPat.MouseEnter += new System.EventHandler(this.iconButton2_MouseEnter);
            this.btnAPat.MouseLeave += new System.EventHandler(this.btnAPat_MouseLeave);
            // 
            // btnAdoc
            // 
            this.btnAdoc.FlatAppearance.BorderSize = 0;
            this.btnAdoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdoc.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAdoc.IconChar = FontAwesome.Sharp.IconChar.Desktop;
            this.btnAdoc.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnAdoc.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAdoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdoc.Location = new System.Drawing.Point(3, 178);
            this.btnAdoc.Name = "btnAdoc";
            this.btnAdoc.Size = new System.Drawing.Size(194, 59);
            this.btnAdoc.TabIndex = 1;
            this.btnAdoc.Text = "Add Doctor";
            this.btnAdoc.UseVisualStyleBackColor = true;
            this.btnAdoc.Click += new System.EventHandler(this.iconButton1_Click);
            this.btnAdoc.MouseEnter += new System.EventHandler(this.btnAdoc_MouseEnter);
            this.btnAdoc.MouseLeave += new System.EventHandler(this.btnAdoc_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblAdmin);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 150);
            this.panel2.TabIndex = 1;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblAdmin.Location = new System.Drawing.Point(42, 101);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(94, 20);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Hello Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(40, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(353, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospital Management ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(456, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "System";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(235, 239);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Lime;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.circularProgressBar1.Size = new System.Drawing.Size(199, 191);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 3;
            this.circularProgressBar1.Text = "24/7";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            this.circularProgressBar1.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(283, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Availability";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(387, 700);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 5;
            // 
            // lblRights
            // 
            this.lblRights.AutoSize = true;
            this.lblRights.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRights.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblRights.Location = new System.Drawing.Point(220, 697);
            this.lblRights.Name = "lblRights";
            this.lblRights.Size = new System.Drawing.Size(568, 37);
            this.lblRights.TabIndex = 6;
            this.lblRights.Text = "All Right Reserved By SUAA Students Project ®";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(623, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quality";
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar2.AnimationSpeed = 500;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.circularProgressBar2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.circularProgressBar2.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.InnerMargin = 2;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.Location = new System.Drawing.Point(560, 239);
            this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar2.OuterMargin = -25;
            this.circularProgressBar2.OuterWidth = 26;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.Yellow;
            this.circularProgressBar2.ProgressWidth = 25;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.circularProgressBar2.Size = new System.Drawing.Size(199, 191);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar2.SubscriptText = "";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar2.SuperscriptText = "";
            this.circularProgressBar2.TabIndex = 8;
            this.circularProgressBar2.Text = "100%";
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar2.Value = 68;
            this.circularProgressBar2.Click += new System.EventHandler(this.circularProgressBar2_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(309, 536);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 132);
            this.panel3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(419, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "progressBar:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 734);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.circularProgressBar2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRights);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblAdmin;
        private PictureBox pictureBox1;
        private NotifyIcon notifyIcon1;
        private FontAwesome.Sharp.IconButton btnRPatient;
        private FontAwesome.Sharp.IconButton btnRDoctor;
        private FontAwesome.Sharp.IconButton btnAPat;
        private FontAwesome.Sharp.IconButton btnAdoc;
        private FontAwesome.Sharp.IconButton btnRStaff;
        private FontAwesome.Sharp.IconButton btnExit;
        private Label label1;
        private Label label2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Label label4;
        private Label lblRights;
        private Label label5;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private Panel panel3;
        private Label label6;
    }
}