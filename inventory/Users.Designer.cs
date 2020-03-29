namespace inventory
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.usernameErrorLabel = new System.Windows.Forms.Label();
            this.passErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.statusDD = new System.Windows.Forms.ComboBox();
            this.statusErrorLabel = new System.Windows.Forms.Label();
            this.userIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stausGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(853, 504);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.statusDD);
            this.leftPanel.Controls.Add(this.label8);
            this.leftPanel.Controls.Add(this.emailTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.phoneTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.passTxt);
            this.leftPanel.Controls.Add(this.usernameTxt);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.nameTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.emailErrorLabel);
            this.leftPanel.Controls.Add(this.phoneErrorLabel);
            this.leftPanel.Controls.Add(this.passErrorLabel);
            this.leftPanel.Controls.Add(this.usernameErrorLabel);
            this.leftPanel.Controls.Add(this.nameErrorLabel);
            this.leftPanel.Controls.Add(this.statusErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(250, 504);
            this.leftPanel.Controls.SetChildIndex(this.statusErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.passErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.emailErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.nameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.passTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.phoneTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.emailTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label8, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.statusDD, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(18, 204);
            this.nameTxt.MaxLength = 50;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(215, 20);
            this.nameTxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Username";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(18, 250);
            this.usernameTxt.MaxLength = 50;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(215, 20);
            this.usernameTxt.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Phone (03XX-XXXXXXX)";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(18, 351);
            this.phoneTxt.MaxLength = 50;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(215, 20);
            this.phoneTxt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(18, 400);
            this.emailTxt.MaxLength = 50;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(215, 20);
            this.emailTxt.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Password";
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(18, 299);
            this.passTxt.MaxLength = 50;
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(215, 20);
            this.passTxt.TabIndex = 3;
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.nameErrorLabel.Location = new System.Drawing.Point(50, 188);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.nameErrorLabel.TabIndex = 4;
            this.nameErrorLabel.Text = "*";
            this.nameErrorLabel.Visible = false;
            // 
            // usernameErrorLabel
            // 
            this.usernameErrorLabel.AutoSize = true;
            this.usernameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.usernameErrorLabel.Location = new System.Drawing.Point(68, 234);
            this.usernameErrorLabel.Name = "usernameErrorLabel";
            this.usernameErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.usernameErrorLabel.TabIndex = 4;
            this.usernameErrorLabel.Text = "*";
            this.usernameErrorLabel.Visible = false;
            // 
            // passErrorLabel
            // 
            this.passErrorLabel.AutoSize = true;
            this.passErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.passErrorLabel.Location = new System.Drawing.Point(68, 283);
            this.passErrorLabel.Name = "passErrorLabel";
            this.passErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.passErrorLabel.TabIndex = 4;
            this.passErrorLabel.Text = "*";
            this.passErrorLabel.Visible = false;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.phoneErrorLabel.Location = new System.Drawing.Point(137, 335);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.phoneErrorLabel.TabIndex = 4;
            this.phoneErrorLabel.Text = "*";
            this.phoneErrorLabel.Visible = false;
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.emailErrorLabel.Location = new System.Drawing.Point(48, 384);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.emailErrorLabel.TabIndex = 4;
            this.emailErrorLabel.Text = "*";
            this.emailErrorLabel.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDGV,
            this.NameGV,
            this.UserNameGV,
            this.PassGV,
            this.EmailGV,
            this.PhoneGV,
            this.stausGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(853, 406);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Status";
            // 
            // statusDD
            // 
            this.statusDD.FormattingEnabled = true;
            this.statusDD.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusDD.Location = new System.Drawing.Point(18, 449);
            this.statusDD.Name = "statusDD";
            this.statusDD.Size = new System.Drawing.Size(215, 21);
            this.statusDD.TabIndex = 5;
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.AutoSize = true;
            this.statusErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.statusErrorLabel.Location = new System.Drawing.Point(55, 433);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.statusErrorLabel.TabIndex = 6;
            this.statusErrorLabel.Text = "*";
            this.statusErrorLabel.Visible = false;
            // 
            // userIDGV
            // 
            this.userIDGV.HeaderText = "USerID";
            this.userIDGV.Name = "userIDGV";
            this.userIDGV.ReadOnly = true;
            this.userIDGV.Visible = false;
            // 
            // NameGV
            // 
            this.NameGV.HeaderText = "Name";
            this.NameGV.Name = "NameGV";
            this.NameGV.ReadOnly = true;
            // 
            // UserNameGV
            // 
            this.UserNameGV.HeaderText = "UserName";
            this.UserNameGV.Name = "UserNameGV";
            this.UserNameGV.ReadOnly = true;
            // 
            // PassGV
            // 
            this.PassGV.HeaderText = "Password";
            this.PassGV.Name = "PassGV";
            this.PassGV.ReadOnly = true;
            this.PassGV.Visible = false;
            // 
            // EmailGV
            // 
            this.EmailGV.HeaderText = "Email";
            this.EmailGV.Name = "EmailGV";
            this.EmailGV.ReadOnly = true;
            // 
            // PhoneGV
            // 
            this.PhoneGV.HeaderText = "Phone #";
            this.PhoneGV.Name = "PhoneGV";
            this.PhoneGV.ReadOnly = true;
            // 
            // stausGV
            // 
            this.stausGV.HeaderText = "Status";
            this.stausGV.Name = "stausGV";
            this.stausGV.ReadOnly = true;
            this.stausGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 504);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.rightPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label emailErrorLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
        private System.Windows.Forms.Label passErrorLabel;
        private System.Windows.Forms.Label usernameErrorLabel;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox statusDD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label statusErrorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn stausGV;
    }
}