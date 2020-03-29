namespace inventory
{
    partial class ProductPricing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.categoryErrorLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectGV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyingPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitMarginGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.leftPanel.Controls.Add(this.label10);
            this.leftPanel.Controls.Add(this.categoryErrorLabel);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Size = new System.Drawing.Size(250, 450);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label10, 0);
            this.leftPanel.Controls.SetChildIndex(this.categoryCB, 0);
            // 
            // categoryCB
            // 
            this.categoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(13, 110);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(217, 21);
            this.categoryCB.TabIndex = 13;
            this.categoryCB.SelectedIndexChanged += new System.EventHandler(this.categoryCB_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Category";
            // 
            // categoryErrorLabel
            // 
            this.categoryErrorLabel.AutoSize = true;
            this.categoryErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryErrorLabel.ForeColor = System.Drawing.Color.Salmon;
            this.categoryErrorLabel.Location = new System.Drawing.Point(84, 94);
            this.categoryErrorLabel.Name = "categoryErrorLabel";
            this.categoryErrorLabel.Size = new System.Drawing.Size(20, 25);
            this.categoryErrorLabel.TabIndex = 11;
            this.categoryErrorLabel.Text = "*";
            this.categoryErrorLabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Salmon;
            this.label7.Location = new System.Drawing.Point(88, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "*";
            this.label7.Visible = false;
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
            this.SelectGV,
            this.proIDGV,
            this.proGV,
            this.BuyingPriceGV,
            this.ProfitMarginGV,
            this.discountGV,
            this.FinalPriceGV});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(550, 352);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // SelectGV
            // 
            this.SelectGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SelectGV.FalseValue = "0";
            this.SelectGV.HeaderText = "";
            this.SelectGV.Name = "SelectGV";
            this.SelectGV.TrueValue = "1";
            this.SelectGV.Width = 5;
            // 
            // proIDGV
            // 
            this.proIDGV.HeaderText = "proID";
            this.proIDGV.Name = "proIDGV";
            this.proIDGV.Visible = false;
            // 
            // proGV
            // 
            this.proGV.HeaderText = "Products";
            this.proGV.Name = "proGV";
            // 
            // BuyingPriceGV
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.BuyingPriceGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.BuyingPriceGV.HeaderText = "Buying Price";
            this.BuyingPriceGV.Name = "BuyingPriceGV";
            this.BuyingPriceGV.ReadOnly = true;
            this.BuyingPriceGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProfitMarginGV
            // 
            this.ProfitMarginGV.HeaderText = "Profit Margin %";
            this.ProfitMarginGV.Name = "ProfitMarginGV";
            // 
            // discountGV
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.discountGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.discountGV.HeaderText = "Discount";
            this.discountGV.Name = "discountGV";
            // 
            // FinalPriceGV
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.FinalPriceGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.FinalPriceGV.HeaderText = "Final Price";
            this.FinalPriceGV.Name = "FinalPriceGV";
            this.FinalPriceGV.ReadOnly = true;
            this.FinalPriceGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProductPricing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ProductPricing";
            this.Text = "ProductPricing";
            this.Load += new System.EventHandler(this.ProductPricing_Load);
            this.rightPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label categoryErrorLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyingPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitMarginGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalPriceGV;
    }
}