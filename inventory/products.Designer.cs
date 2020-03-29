namespace inventory
{
    partial class products
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
            this.proTxt = new System.Windows.Forms.TextBox();
            this.proErrorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.barTxt = new System.Windows.Forms.TextBox();
            this.barErrorLabel = new System.Windows.Forms.Label();
            this.expErrorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryErrorLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(550, 55);
            // 
            // searchTxt
            // 
            this.searchTxt.Size = new System.Drawing.Size(83, 23);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backBtn.FlatAppearance.BorderSize = 2;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(550, 450);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.categoryCB);
            this.leftPanel.Controls.Add(this.dateTimePicker);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.label10);
            this.leftPanel.Controls.Add(this.barTxt);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.proTxt);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.categoryErrorLabel);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.expErrorLabel);
            this.leftPanel.Controls.Add(this.proErrorLabel);
            this.leftPanel.Controls.Add(this.barErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(250, 450);
            this.leftPanel.Controls.SetChildIndex(this.barErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.proErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.expErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.proTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.barTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label10, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.dateTimePicker, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryCB, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            // 
            // proTxt
            // 
            this.proTxt.Location = new System.Drawing.Point(12, 102);
            this.proTxt.Multiline = true;
            this.proTxt.Name = "proTxt";
            this.proTxt.Size = new System.Drawing.Size(217, 20);
            this.proTxt.TabIndex = 2;
            // 
            // proErrorLabel
            // 
            this.proErrorLabel.AutoSize = true;
            this.proErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.proErrorLabel.Location = new System.Drawing.Point(83, 86);
            this.proErrorLabel.Name = "proErrorLabel";
            this.proErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.proErrorLabel.TabIndex = 5;
            this.proErrorLabel.Text = "*";
            this.proErrorLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Barcode";
            // 
            // barTxt
            // 
            this.barTxt.Location = new System.Drawing.Point(12, 151);
            this.barTxt.Multiline = true;
            this.barTxt.Name = "barTxt";
            this.barTxt.Size = new System.Drawing.Size(217, 20);
            this.barTxt.TabIndex = 2;
            // 
            // barErrorLabel
            // 
            this.barErrorLabel.AutoSize = true;
            this.barErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.barErrorLabel.Location = new System.Drawing.Point(83, 135);
            this.barErrorLabel.Name = "barErrorLabel";
            this.barErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.barErrorLabel.TabIndex = 6;
            this.barErrorLabel.Text = "*";
            this.barErrorLabel.Visible = false;
            // 
            // expErrorLabel
            // 
            this.expErrorLabel.AutoSize = true;
            this.expErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.expErrorLabel.Location = new System.Drawing.Point(83, 188);
            this.expErrorLabel.Name = "expErrorLabel";
            this.expErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.expErrorLabel.TabIndex = 6;
            this.expErrorLabel.Text = "*";
            this.expErrorLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Expiry Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dateTimePicker.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(12, 204);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(217, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Salmon;
            this.label7.Location = new System.Drawing.Point(87, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "*";
            this.label7.Visible = false;
            // 
            // categoryErrorLabel
            // 
            this.categoryErrorLabel.AutoSize = true;
            this.categoryErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.categoryErrorLabel.Location = new System.Drawing.Point(83, 238);
            this.categoryErrorLabel.Name = "categoryErrorLabel";
            this.categoryErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.categoryErrorLabel.TabIndex = 6;
            this.categoryErrorLabel.Text = "*";
            this.categoryErrorLabel.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Category";
            // 
            // categoryCB
            // 
            this.categoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(12, 254);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(217, 21);
            this.categoryCB.TabIndex = 9;
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
            this.barcodeGV,
            this.expiryGV,
            this.catIDGV,
            this.catGV});
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
            this.dataGridView1.Size = new System.Drawing.Size(550, 352);
            this.dataGridView1.TabIndex = 3;
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
            // barcodeGV
            // 
            this.barcodeGV.HeaderText = "Barcode";
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // expiryGV
            // 
            this.expiryGV.HeaderText = "ExpiryDate";
            this.expiryGV.Name = "expiryGV";
            this.expiryGV.ReadOnly = true;
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "CategoryID";
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // catGV
            // 
            this.catGV.HeaderText = "Category";
            this.catGV.Name = "catGV";
            this.catGV.ReadOnly = true;
            this.catGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.products_Load);
            this.rightPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox proTxt;
        private System.Windows.Forms.Label proErrorLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox barTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label expErrorLabel;
        private System.Windows.Forms.Label barErrorLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label categoryErrorLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catGV;
    }
}