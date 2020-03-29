namespace inventory
{
    partial class HomeScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.userBtn = new System.Windows.Forms.Button();
            this.catBtn = new System.Windows.Forms.Button();
            this.suppliersBtn = new System.Windows.Forms.Button();
            this.priceBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rightPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Size = new System.Drawing.Size(977, 494);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(250, 494);
            // 
            // userLabel
            // 
            this.userLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.purchaseBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.userBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.catBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.suppliersBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.priceBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 451);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::inventory.Properties.Resources.download__2_;
            this.button2.Location = new System.Drawing.Point(198, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 106);
            this.button2.TabIndex = 5;
            this.button2.Text = "Products";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::inventory.Properties.Resources.images__1_1;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(783, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 106);
            this.button5.TabIndex = 4;
            this.button5.Text = "Sales";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purchaseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.purchaseBtn.FlatAppearance.BorderSize = 2;
            this.purchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseBtn.Image = global::inventory.Properties.Resources.download__1_1;
            this.purchaseBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.purchaseBtn.Location = new System.Drawing.Point(588, 3);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(189, 106);
            this.purchaseBtn.TabIndex = 3;
            this.purchaseBtn.Text = "Purchase Invoice";
            this.purchaseBtn.UseVisualStyleBackColor = true;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::inventory.Properties.Resources.images;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(393, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 106);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stock";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userBtn
            // 
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userBtn.FlatAppearance.BorderSize = 2;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Image = global::inventory.Properties.Resources.download__1_;
            this.userBtn.Location = new System.Drawing.Point(3, 3);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(189, 106);
            this.userBtn.TabIndex = 0;
            this.userBtn.Text = "Users";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // catBtn
            // 
            this.catBtn.BackgroundImage = global::inventory.Properties.Resources.download__2_1;
            this.catBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.catBtn.FlatAppearance.BorderSize = 2;
            this.catBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catBtn.Location = new System.Drawing.Point(3, 115);
            this.catBtn.Name = "catBtn";
            this.catBtn.Size = new System.Drawing.Size(189, 106);
            this.catBtn.TabIndex = 6;
            this.catBtn.Text = "Categories";
            this.catBtn.UseVisualStyleBackColor = true;
            this.catBtn.Click += new System.EventHandler(this.catBtn_Click);
            // 
            // suppliersBtn
            // 
            this.suppliersBtn.BackgroundImage = global::inventory.Properties.Resources.download__1_2;
            this.suppliersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suppliersBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.suppliersBtn.FlatAppearance.BorderSize = 2;
            this.suppliersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suppliersBtn.Location = new System.Drawing.Point(198, 115);
            this.suppliersBtn.Name = "suppliersBtn";
            this.suppliersBtn.Size = new System.Drawing.Size(189, 106);
            this.suppliersBtn.TabIndex = 7;
            this.suppliersBtn.Text = "Suppliers";
            this.suppliersBtn.UseVisualStyleBackColor = true;
            this.suppliersBtn.Click += new System.EventHandler(this.suppliersBtn_Click);
            // 
            // priceBtn
            // 
            this.priceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceBtn.FlatAppearance.BorderSize = 2;
            this.priceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceBtn.Image = global::inventory.Properties.Resources.download__1_1;
            this.priceBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.priceBtn.Location = new System.Drawing.Point(393, 115);
            this.priceBtn.Name = "priceBtn";
            this.priceBtn.Size = new System.Drawing.Size(189, 106);
            this.priceBtn.TabIndex = 8;
            this.priceBtn.Text = "Product Pricing";
            this.priceBtn.UseVisualStyleBackColor = true;
            this.priceBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::inventory.Properties.Resources.download__1_1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(588, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 106);
            this.button1.TabIndex = 9;
            this.button1.Text = "Daily Sales";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::inventory.Properties.Resources.download__2_1;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(783, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 106);
            this.button4.TabIndex = 10;
            this.button4.Text = "Sales Return";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 494);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "HomeScreen";
            this.Text = "Home Screen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.rightPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button catBtn;
        private System.Windows.Forms.Button suppliersBtn;
        private System.Windows.Forms.Button priceBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}