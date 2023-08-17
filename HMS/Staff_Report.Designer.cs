namespace HMS
{
    partial class Staff_Report
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.tbCNIC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnpAdd = new FontAwesome.Sharp.IconButton();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.tbRole = new System.Windows.Forms.TextBox();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmspeciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmschedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(818, 106);
            this.panel1.TabIndex = 91;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.CircleArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 55;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 106);
            this.btnBack.TabIndex = 54;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(176, 2);
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
            this.label8.Location = new System.Drawing.Point(296, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 45);
            this.label8.TabIndex = 51;
            this.label8.Text = "Staff Form";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.tbCNIC);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnpAdd);
            this.panel2.Controls.Add(this.tbContact);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.tbRole);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 384);
            this.panel2.TabIndex = 92;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(19, 275);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(64, 31);
            this.iconButton1.TabIndex = 101;
            this.iconButton1.Text = "Add\r\n";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // tbCNIC
            // 
            this.tbCNIC.Location = new System.Drawing.Point(111, 26);
            this.tbCNIC.Name = "tbCNIC";
            this.tbCNIC.Size = new System.Drawing.Size(197, 23);
            this.tbCNIC.TabIndex = 94;
            this.tbCNIC.TextChanged += new System.EventHandler(this.tbCNIC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 93;
            this.label1.Text = "Staff CNIC:";
            // 
            // btnpAdd
            // 
            this.btnpAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnpAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnpAdd.IconColor = System.Drawing.Color.Black;
            this.btnpAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnpAdd.IconSize = 25;
            this.btnpAdd.Location = new System.Drawing.Point(19, 443);
            this.btnpAdd.Name = "btnpAdd";
            this.btnpAdd.Size = new System.Drawing.Size(64, 31);
            this.btnpAdd.TabIndex = 96;
            this.btnpAdd.Text = "Add\r\n";
            this.btnpAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpAdd.UseVisualStyleBackColor = true;
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(111, 175);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(197, 23);
            this.tbContact.TabIndex = 100;
            // 
            // btnHome
            // 
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            this.btnHome.IconColor = System.Drawing.Color.Black;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 25;
            this.btnHome.Location = new System.Drawing.Point(103, 326);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(79, 31);
            this.btnHome.TabIndex = 95;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(11, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 99;
            this.label4.Text = "Contact Details:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 25;
            this.btnUpdate.Location = new System.Drawing.Point(201, 275);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 31);
            this.btnUpdate.TabIndex = 94;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbRole
            // 
            this.tbRole.Location = new System.Drawing.Point(111, 125);
            this.tbRole.Name = "tbRole";
            this.tbRole.Size = new System.Drawing.Size(197, 23);
            this.tbRole.TabIndex = 98;
            // 
            // btnDelete
            // 
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Discord;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 28;
            this.btnDelete.Location = new System.Drawing.Point(103, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 31);
            this.btnDelete.TabIndex = 93;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(11, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 97;
            this.label3.Text = "Staff Role:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 25;
            this.btnAdd.Location = new System.Drawing.Point(13, 602);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 31);
            this.btnAdd.TabIndex = 92;
            this.btnAdd.Text = "Add\r\n";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(111, 75);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(197, 23);
            this.tbName.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 95;
            this.label2.Text = "Staff Name:";
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
            this.dataGridView1.Location = new System.Drawing.Point(318, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(500, 373);
            this.dataGridView1.TabIndex = 93;
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
            // Staff_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(818, 496);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff_Report";
            this.Load += new System.EventHandler(this.Staff_Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnBack;
        private Label label9;
        private Label label8;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnpAdd;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnAdd;
        private TextBox tbCNIC;
        private Label label1;
        private TextBox tbContact;
        private Label label4;
        private TextBox tbRole;
        private Label label3;
        private TextBox tbName;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmCNIC;
        private DataGridViewTextBoxColumn clmAge;
        private DataGridViewTextBoxColumn clmContact;
        private DataGridViewTextBoxColumn clmspeciality;
        private DataGridViewTextBoxColumn clmschedule;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}