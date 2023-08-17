namespace HMS
{
    partial class Patient_Report
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpAdd = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmspeciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmschedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 106);
            this.panel1.TabIndex = 76;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.CircleArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 55;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 67);
            this.btnBack.TabIndex = 52;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(256, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(468, 45);
            this.label9.TabIndex = 36;
            this.label9.Text = "Hospital Management System";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(372, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 45);
            this.label8.TabIndex = 51;
            this.label8.Text = "Patient Report";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnpAdd);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 419);
            this.panel2.TabIndex = 77;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Critical",
            "Normal",
            "Cardiac Problem",
            "Very Critical"});
            this.comboBox2.Location = new System.Drawing.Point(126, 244);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(107, 23);
            this.comboBox2.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(16, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 107;
            this.label6.Text = "Patient Situation:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(126, 201);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(172, 23);
            this.textBox5.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(16, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 105;
            this.label5.Text = "Patient Hisory:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(126, 152);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(172, 23);
            this.textBox4.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(16, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 103;
            this.label4.Text = "Patient Contact  :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 23);
            this.textBox3.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(23, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 101;
            this.label3.Text = "Patient Age:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 23);
            this.textBox2.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 99;
            this.label2.Text = "Patient CNIC:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 23);
            this.textBox1.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 97;
            this.label1.Text = "Patient Name:";
            // 
            // btnpAdd
            // 
            this.btnpAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnpAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnpAdd.IconColor = System.Drawing.Color.Black;
            this.btnpAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnpAdd.IconSize = 25;
            this.btnpAdd.Location = new System.Drawing.Point(19, 301);
            this.btnpAdd.Name = "btnpAdd";
            this.btnpAdd.Size = new System.Drawing.Size(64, 31);
            this.btnpAdd.TabIndex = 96;
            this.btnpAdd.Text = "Add\r\n";
            this.btnpAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpAdd.UseVisualStyleBackColor = true;
            this.btnpAdd.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnHome
            // 
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            this.btnHome.IconColor = System.Drawing.Color.Black;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 25;
            this.btnHome.Location = new System.Drawing.Point(103, 352);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(79, 31);
            this.btnHome.TabIndex = 95;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 25;
            this.btnUpdate.Location = new System.Drawing.Point(201, 301);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 31);
            this.btnUpdate.TabIndex = 94;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Discord;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 28;
            this.btnDelete.Location = new System.Drawing.Point(103, 301);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 31);
            this.btnDelete.TabIndex = 93;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 25;
            this.btnAdd.Location = new System.Drawing.Point(13, 460);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 31);
            this.btnAdd.TabIndex = 92;
            this.btnAdd.Text = "Add\r\n";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(317, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(736, 422);
            this.panel3.TabIndex = 78;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmCNIC,
            this.clmAge,
            this.clmContact,
            this.clmspeciality,
            this.clmschedule});
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(650, 419);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clmName
            // 
            this.clmName.HeaderText = "PName";
            this.clmName.Name = "clmName";
            // 
            // clmCNIC
            // 
            this.clmCNIC.HeaderText = "PCNIC";
            this.clmCNIC.Name = "clmCNIC";
            // 
            // clmAge
            // 
            this.clmAge.HeaderText = "PAge";
            this.clmAge.Name = "clmAge";
            this.clmAge.Width = 50;
            // 
            // clmContact
            // 
            this.clmContact.HeaderText = "PContact";
            this.clmContact.Name = "clmContact";
            // 
            // clmspeciality
            // 
            this.clmspeciality.HeaderText = "PHistory";
            this.clmspeciality.Name = "clmspeciality";
            this.clmspeciality.Width = 150;
            // 
            // clmschedule
            // 
            this.clmschedule.HeaderText = "PSituation";
            this.clmschedule.Name = "clmschedule";
            // 
            // Patient_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(967, 572);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Patient_Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnBack;
        private Label label9;
        private Label label8;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnpAdd;
        private ComboBox comboBox2;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Panel panel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmCNIC;
        private DataGridViewTextBoxColumn clmAge;
        private DataGridViewTextBoxColumn clmContact;
        private DataGridViewTextBoxColumn clmspeciality;
        private DataGridViewTextBoxColumn clmschedule;
    }
}