namespace inventory
{
    partial class settings
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.databaseTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serverTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(959, 499);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.saveBtn);
            this.leftPanel.Controls.Add(this.isCB);
            this.leftPanel.Controls.Add(this.passTxt);
            this.leftPanel.Controls.Add(this.userTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.databaseTxt);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.serverTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(250, 499);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.databaseTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.userTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.passTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.isCB, 0);
            this.leftPanel.Controls.SetChildIndex(this.saveBtn, 0);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 2;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(8, 418);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(237, 31);
            this.saveBtn.TabIndex = 16;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Location = new System.Drawing.Point(8, 392);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(115, 17);
            this.isCB.TabIndex = 15;
            this.isCB.Text = "Integrated Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(8, 362);
            this.passTxt.MaxLength = 30;
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(237, 20);
            this.passTxt.TabIndex = 14;
            this.passTxt.UseSystemPasswordChar = true;
            this.passTxt.TextChanged += new System.EventHandler(this.passTxt_TextChanged);
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(8, 315);
            this.userTxt.MaxLength = 50;
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(237, 20);
            this.userTxt.TabIndex = 13;
            this.userTxt.TextChanged += new System.EventHandler(this.userTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // databaseTxt
            // 
            this.databaseTxt.Location = new System.Drawing.Point(8, 263);
            this.databaseTxt.MaxLength = 50;
            this.databaseTxt.Name = "databaseTxt";
            this.databaseTxt.Size = new System.Drawing.Size(237, 20);
            this.databaseTxt.TabIndex = 9;
            this.databaseTxt.TextChanged += new System.EventHandler(this.databaseTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "User ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Database";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // serverTxt
            // 
            this.serverTxt.Location = new System.Drawing.Point(8, 216);
            this.serverTxt.MaxLength = 50;
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(237, 20);
            this.serverTxt.TabIndex = 7;
            this.serverTxt.TextChanged += new System.EventHandler(this.serverTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Server";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 499);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "settings";
            this.Text = "settings";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox isCB;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox databaseTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverTxt;
        private System.Windows.Forms.Label label3;
    }
}