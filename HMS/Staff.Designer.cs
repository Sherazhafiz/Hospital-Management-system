namespace HMS
{
    partial class Staff
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
            this.tbCNIC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnViewReport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRole = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(800, 106);
            this.panel1.TabIndex = 90;
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
            this.btnBack.TabIndex = 54;
            this.btnBack.UseVisualStyleBackColor = false;
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
            // tbCNIC
            // 
            this.tbCNIC.Location = new System.Drawing.Point(296, 149);
            this.tbCNIC.Name = "tbCNIC";
            this.tbCNIC.Size = new System.Drawing.Size(253, 23);
            this.tbCNIC.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(142, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 79;
            this.label1.Text = "Staff CNIC:";
            // 
            // BtnViewReport
            // 
            this.BtnViewReport.BackColor = System.Drawing.Color.Red;
            this.BtnViewReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnViewReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnViewReport.Location = new System.Drawing.Point(487, 427);
            this.BtnViewReport.Name = "BtnViewReport";
            this.BtnViewReport.Size = new System.Drawing.Size(131, 35);
            this.BtnViewReport.TabIndex = 89;
            this.BtnViewReport.Text = "View Report";
            this.BtnViewReport.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(326, 427);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 88;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.CausesValidation = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(142, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 87;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(296, 298);
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(253, 23);
            this.tbContact.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(142, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 85;
            this.label4.Text = "Contact Details:";
            // 
            // tbRole
            // 
            this.tbRole.Location = new System.Drawing.Point(296, 248);
            this.tbRole.Name = "tbRole";
            this.tbRole.Size = new System.Drawing.Size(253, 23);
            this.tbRole.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(142, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 83;
            this.label3.Text = "Staff Role:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(296, 198);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(253, 23);
            this.tbName.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(142, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 81;
            this.label2.Text = "Staff Name:";
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbCNIC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnViewReport);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label8;
        private TextBox tbCNIC;
        private Label label1;
        private Button BtnViewReport;
        private Button btnClear;
        private Button btnSave;
        private TextBox tbContact;
        private Label label4;
        private TextBox tbRole;
        private Label label3;
        private TextBox tbName;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnBack;
    }
}