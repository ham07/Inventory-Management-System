namespace inventory
{
    partial class Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.grossLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.barcodeTxt = new System.Windows.Forms.TextBox();
            this.payBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.CashBTXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CashRecTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PaymentCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.disTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gosTotTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rightPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(998, 55);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backBtn.FlatAppearance.BorderSize = 2;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel4);
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(998, 606);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel4, 0);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.panel7);
            this.leftPanel.Controls.Add(this.panel5);
            this.leftPanel.Controls.Add(this.groupBox2);
            this.leftPanel.Size = new System.Drawing.Size(250, 606);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.groupBox2, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel5, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel7, 0);
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
            this.proIDGV,
            this.proNameGV,
            this.quantityGV,
            this.pupGV,
            this.disGV,
            this.totGV,
            this.deleteGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(998, 508);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // proIDGV
            // 
            this.proIDGV.HeaderText = "proID";
            this.proIDGV.Name = "proIDGV";
            this.proIDGV.ReadOnly = true;
            this.proIDGV.Visible = false;
            // 
            // proNameGV
            // 
            this.proNameGV.HeaderText = "Products";
            this.proNameGV.Name = "proNameGV";
            this.proNameGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            // 
            // pupGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.pupGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.pupGV.HeaderText = "Per Unit Price";
            this.pupGV.Name = "pupGV";
            this.pupGV.ReadOnly = true;
            // 
            // disGV
            // 
            this.disGV.HeaderText = "Discount%";
            this.disGV.Name = "disGV";
            this.disGV.ReadOnly = true;
            this.disGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.disGV.Visible = false;
            // 
            // totGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.totGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.totGV.HeaderText = "Total Amount";
            this.totGV.Name = "totGV";
            this.totGV.ReadOnly = true;
            // 
            // deleteGV
            // 
            this.deleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Text = "Delete";
            this.deleteGV.UseColumnTextForButtonValue = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 495);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(998, 111);
            this.panel4.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grossLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(998, 111);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 45);
            this.label8.TabIndex = 9;
            this.label8.Text = "Gross Total ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grossLabel
            // 
            this.grossLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grossLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossLabel.Location = new System.Drawing.Point(502, 0);
            this.grossLabel.Name = "grossLabel";
            this.grossLabel.Size = new System.Drawing.Size(493, 111);
            this.grossLabel.TabIndex = 9;
            this.grossLabel.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barcode";
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.Location = new System.Drawing.Point(4, 3);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.Size = new System.Drawing.Size(230, 20);
            this.barcodeTxt.TabIndex = 3;
            this.barcodeTxt.TextChanged += new System.EventHandler(this.barcodeTxt_TextChanged);
            this.barcodeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.barcodeTxt_Validating);
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.Maroon;
            this.payBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payBtn.FlatAppearance.BorderSize = 2;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.Location = new System.Drawing.Point(12, 374);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(220, 70);
            this.payBtn.TabIndex = 4;
            this.payBtn.Text = "&Pay";
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBtn);
            this.groupBox2.Controls.Add(this.CashBTXT);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CashRecTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.PaymentCB);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.disTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.gosTotTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.payBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 470);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // checkBtn
            // 
            this.checkBtn.BackColor = System.Drawing.Color.Maroon;
            this.checkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBtn.FlatAppearance.BorderSize = 2;
            this.checkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBtn.Location = new System.Drawing.Point(14, 289);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(220, 70);
            this.checkBtn.TabIndex = 17;
            this.checkBtn.Text = "&Checkout";
            this.checkBtn.UseVisualStyleBackColor = false;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // CashBTXT
            // 
            this.CashBTXT.Enabled = false;
            this.CashBTXT.Location = new System.Drawing.Point(6, 234);
            this.CashBTXT.Name = "CashBTXT";
            this.CashBTXT.Size = new System.Drawing.Size(230, 20);
            this.CashBTXT.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cash Back";
            // 
            // CashRecTxt
            // 
            this.CashRecTxt.Location = new System.Drawing.Point(6, 188);
            this.CashRecTxt.Name = "CashRecTxt";
            this.CashRecTxt.Size = new System.Drawing.Size(230, 20);
            this.CashRecTxt.TabIndex = 13;
            this.CashRecTxt.TextChanged += new System.EventHandler(this.CashRecTxt_TextChanged);
            this.CashRecTxt.Validating += new System.ComponentModel.CancelEventHandler(this.CashRecTxt_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cash Recieved";
            // 
            // PaymentCB
            // 
            this.PaymentCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentCB.FormattingEnabled = true;
            this.PaymentCB.Items.AddRange(new object[] {
            "Cash",
            "Debit Card",
            "Credit Card"});
            this.PaymentCB.Location = new System.Drawing.Point(6, 138);
            this.PaymentCB.Name = "PaymentCB";
            this.PaymentCB.Size = new System.Drawing.Size(230, 21);
            this.PaymentCB.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Payment Type";
            // 
            // disTxt
            // 
            this.disTxt.Location = new System.Drawing.Point(6, 89);
            this.disTxt.Name = "disTxt";
            this.disTxt.Size = new System.Drawing.Size(230, 20);
            this.disTxt.TabIndex = 9;
            this.disTxt.Text = "0";
            this.disTxt.Validating += new System.ComponentModel.CancelEventHandler(this.disTxt_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total discount %";
            // 
            // gosTotTxt
            // 
            this.gosTotTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gosTotTxt.Enabled = false;
            this.gosTotTxt.Location = new System.Drawing.Point(6, 41);
            this.gosTotTxt.Name = "gosTotTxt";
            this.gosTotTxt.Size = new System.Drawing.Size(230, 20);
            this.gosTotTxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gross Total";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 43);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 50);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 52);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 30);
            this.panel6.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.barcodeTxt);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 93);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 30);
            this.panel7.TabIndex = 7;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 606);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.rightPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label grossLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barcodeTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn disGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox PaymentCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox disTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gosTotTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CashBTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CashRecTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button checkBtn;
    }
}