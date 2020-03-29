namespace inventory
{
    partial class PurchaseInvoice
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
            this.label2 = new System.Windows.Forms.Label();
            this.SupplierDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pupTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.barcodeTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CartBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.totLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.grossLabel = new System.Windows.Forms.Label();
            this.supplierErrorLabel = new System.Windows.Forms.Label();
            this.barcodeErrorLabel = new System.Windows.Forms.Label();
            this.quantityErrorLabel = new System.Windows.Forms.Label();
            this.rightPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(903, 55);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backBtn.FlatAppearance.BorderSize = 2;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel4);
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(903, 513);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel4, 0);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.totLabel);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.CartBtn);
            this.leftPanel.Controls.Add(this.quantityTxt);
            this.leftPanel.Controls.Add(this.pupTxt);
            this.leftPanel.Controls.Add(this.barcodeTxt);
            this.leftPanel.Controls.Add(this.productTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.SupplierDD);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.quantityErrorLabel);
            this.leftPanel.Controls.Add(this.barcodeErrorLabel);
            this.leftPanel.Controls.Add(this.supplierErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(250, 513);
            this.leftPanel.Controls.SetChildIndex(this.supplierErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.quantityErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.SupplierDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.productTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.barcodeTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.pupTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.quantityTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.CartBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.totLabel, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Supplier";
            // 
            // SupplierDD
            // 
            this.SupplierDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SupplierDD.FormattingEnabled = true;
            this.SupplierDD.Location = new System.Drawing.Point(16, 110);
            this.SupplierDD.Name = "SupplierDD";
            this.SupplierDD.Size = new System.Drawing.Size(221, 21);
            this.SupplierDD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product";
            // 
            // productTxt
            // 
            this.productTxt.Location = new System.Drawing.Point(16, 214);
            this.productTxt.Name = "productTxt";
            this.productTxt.Size = new System.Drawing.Size(221, 20);
            this.productTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Per Unit Price";
            // 
            // pupTxt
            // 
            this.pupTxt.Location = new System.Drawing.Point(16, 264);
            this.pupTxt.Name = "pupTxt";
            this.pupTxt.Size = new System.Drawing.Size(221, 20);
            this.pupTxt.TabIndex = 5;
            this.pupTxt.TextChanged += new System.EventHandler(this.pupTxt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Barcode";
            // 
            // barcodeTxt
            // 
            this.barcodeTxt.Location = new System.Drawing.Point(16, 163);
            this.barcodeTxt.Name = "barcodeTxt";
            this.barcodeTxt.Size = new System.Drawing.Size(221, 20);
            this.barcodeTxt.TabIndex = 5;
            this.barcodeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.barcodeTxt_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Select Quantity";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(16, 316);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(221, 20);
            this.quantityTxt.TabIndex = 5;
            this.quantityTxt.TextChanged += new System.EventHandler(this.quantityTxt_TextChanged);
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(903, 300);
            this.dataGridView1.TabIndex = 4;
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
            // CartBtn
            // 
            this.CartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CartBtn.FlatAppearance.BorderSize = 2;
            this.CartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CartBtn.Location = new System.Drawing.Point(17, 353);
            this.CartBtn.Name = "CartBtn";
            this.CartBtn.Size = new System.Drawing.Size(221, 35);
            this.CartBtn.TabIndex = 6;
            this.CartBtn.Text = "Add To Cart";
            this.CartBtn.UseVisualStyleBackColor = true;
            this.CartBtn.Click += new System.EventHandler(this.CartBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total Amount";
            // 
            // totLabel
            // 
            this.totLabel.AutoSize = true;
            this.totLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totLabel.Location = new System.Drawing.Point(66, 430);
            this.totLabel.Name = "totLabel";
            this.totLabel.Size = new System.Drawing.Size(83, 39);
            this.totLabel.TabIndex = 8;
            this.totLabel.Text = "0.00";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 402);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(903, 111);
            this.panel4.TabIndex = 5;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(903, 111);
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
            this.grossLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossLabel.Location = new System.Drawing.Point(454, 0);
            this.grossLabel.Name = "grossLabel";
            this.grossLabel.Size = new System.Drawing.Size(83, 39);
            this.grossLabel.TabIndex = 9;
            this.grossLabel.Text = "0.00";
            this.grossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // supplierErrorLabel
            // 
            this.supplierErrorLabel.AutoSize = true;
            this.supplierErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.supplierErrorLabel.Location = new System.Drawing.Point(97, 94);
            this.supplierErrorLabel.Name = "supplierErrorLabel";
            this.supplierErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.supplierErrorLabel.TabIndex = 9;
            this.supplierErrorLabel.Text = "*";
            this.supplierErrorLabel.Visible = false;
            // 
            // barcodeErrorLabel
            // 
            this.barcodeErrorLabel.AutoSize = true;
            this.barcodeErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.barcodeErrorLabel.Location = new System.Drawing.Point(97, 147);
            this.barcodeErrorLabel.Name = "barcodeErrorLabel";
            this.barcodeErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.barcodeErrorLabel.TabIndex = 10;
            this.barcodeErrorLabel.Text = "*";
            this.barcodeErrorLabel.Visible = false;
            // 
            // quantityErrorLabel
            // 
            this.quantityErrorLabel.AutoSize = true;
            this.quantityErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.quantityErrorLabel.Location = new System.Drawing.Point(97, 300);
            this.quantityErrorLabel.Name = "quantityErrorLabel";
            this.quantityErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.quantityErrorLabel.TabIndex = 11;
            this.quantityErrorLabel.Text = "*";
            this.quantityErrorLabel.Visible = false;
            // 
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 513);
            this.Name = "PurchaseInvoice";
            this.Text = "PurchaseInvoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            this.rightPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SupplierDD;
        private System.Windows.Forms.TextBox pupTxt;
        private System.Windows.Forms.TextBox productTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox barcodeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CartBtn;
        private System.Windows.Forms.Label totLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label grossLabel;
        private System.Windows.Forms.Label quantityErrorLabel;
        private System.Windows.Forms.Label barcodeErrorLabel;
        private System.Windows.Forms.Label supplierErrorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totGV;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}