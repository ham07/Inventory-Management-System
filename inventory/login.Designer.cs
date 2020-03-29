namespace inventory
{
    partial class login
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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameErrorLabel = new System.Windows.Forms.Label();
            this.passErrorlabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(1002, 494);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.LoginBtn);
            this.leftPanel.Controls.Add(this.passTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.usernameTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.usernameErrorLabel);
            this.leftPanel.Controls.Add(this.passErrorlabel);
            this.leftPanel.Size = new System.Drawing.Size(250, 494);
            this.leftPanel.Controls.SetChildIndex(this.passErrorlabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.passTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.LoginBtn, 0);
            // 
            // LoginBtn
            // 
            this.LoginBtn.FlatAppearance.BorderSize = 2;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Location = new System.Drawing.Point(8, 265);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(237, 30);
            this.LoginBtn.TabIndex = 9;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(8, 223);
            this.passTxt.MaxLength = 30;
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(237, 20);
            this.passTxt.TabIndex = 7;
            this.passTxt.Text = "abc";
            this.passTxt.UseSystemPasswordChar = true;
            this.passTxt.TextChanged += new System.EventHandler(this.passTxt_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(8, 173);
            this.usernameTxt.MaxLength = 30;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(237, 20);
            this.usernameTxt.TabIndex = 8;
            this.usernameTxt.Text = "waqas";
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // usernameErrorLabel
            // 
            this.usernameErrorLabel.AutoSize = true;
            this.usernameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.usernameErrorLabel.Location = new System.Drawing.Point(68, 155);
            this.usernameErrorLabel.Name = "usernameErrorLabel";
            this.usernameErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.usernameErrorLabel.TabIndex = 10;
            this.usernameErrorLabel.Text = "*";
            this.usernameErrorLabel.Visible = false;
            this.usernameErrorLabel.Click += new System.EventHandler(this.usernameErrorLabel_Click);
            // 
            // passErrorlabel
            // 
            this.passErrorlabel.AutoSize = true;
            this.passErrorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passErrorlabel.ForeColor = System.Drawing.Color.Salmon;
            this.passErrorlabel.Location = new System.Drawing.Point(68, 205);
            this.passErrorlabel.Name = "passErrorlabel";
            this.passErrorlabel.Size = new System.Drawing.Size(20, 25);
            this.passErrorlabel.TabIndex = 11;
            this.passErrorlabel.Text = "*";
            this.passErrorlabel.Visible = false;
            this.passErrorlabel.Click += new System.EventHandler(this.passErrorlabel_Click);
            // 
            // login
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 494);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "login";
            this.Text = "login";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label usernameErrorLabel;
        private System.Windows.Forms.Label passErrorlabel;
    }
}