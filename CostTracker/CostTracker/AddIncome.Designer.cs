﻿namespace CostTracker
{
    partial class AddIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIncome));
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbIncome = new System.Windows.Forms.PictureBox();
            this.pbExpenses = new System.Windows.Forms.PictureBox();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lbSource = new System.Windows.Forms.ListBox();
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.btnSaveIncome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHome
            // 
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(76, 178);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(160, 125);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 0;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pbIncome
            // 
            this.pbIncome.Image = ((System.Drawing.Image)(resources.GetObject("pbIncome.Image")));
            this.pbIncome.Location = new System.Drawing.Point(72, 334);
            this.pbIncome.Name = "pbIncome";
            this.pbIncome.Size = new System.Drawing.Size(170, 120);
            this.pbIncome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIncome.TabIndex = 1;
            this.pbIncome.TabStop = false;
            // 
            // pbExpenses
            // 
            this.pbExpenses.Image = ((System.Drawing.Image)(resources.GetObject("pbExpenses.Image")));
            this.pbExpenses.Location = new System.Drawing.Point(72, 483);
            this.pbExpenses.Name = "pbExpenses";
            this.pbExpenses.Size = new System.Drawing.Size(170, 150);
            this.pbExpenses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExpenses.TabIndex = 2;
            this.pbExpenses.TabStop = false;
            // 
            // pbLogout
            // 
            this.pbLogout.Image = ((System.Drawing.Image)(resources.GetObject("pbLogout.Image")));
            this.pbLogout.Location = new System.Drawing.Point(104, 669);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(104, 55);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogout.TabIndex = 3;
            this.pbLogout.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblDate.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(417, 108);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(105, 51);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblAmount.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.White;
            this.lblAmount.Location = new System.Drawing.Point(417, 249);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(165, 51);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Amount";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblSource.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.ForeColor = System.Drawing.Color.White;
            this.lblSource.Location = new System.Drawing.Point(837, 108);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(142, 51);
            this.lblSource.TabIndex = 6;
            this.lblSource.Text = "Source";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblCategory.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(837, 249);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(182, 51);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblNote.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.White;
            this.lblNote.Location = new System.Drawing.Point(417, 411);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(110, 51);
            this.lblNote.TabIndex = 8;
            this.lblNote.Text = "Note";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(426, 178);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(333, 45);
            this.dtpDate.TabIndex = 9;
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.tbAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tbAmount.Location = new System.Drawing.Point(426, 324);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(333, 45);
            this.tbAmount.TabIndex = 10;
            // 
            // lbSource
            // 
            this.lbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lbSource.FormattingEnabled = true;
            this.lbSource.ItemHeight = 44;
            this.lbSource.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Debit Card",
            "eMoney",
            "Accounts",
            "Savings"});
            this.lbSource.Location = new System.Drawing.Point(846, 178);
            this.lbSource.Name = "lbSource";
            this.lbSource.Size = new System.Drawing.Size(333, 44);
            this.lbSource.TabIndex = 11;
            // 
            // lbCategory
            // 
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.ItemHeight = 44;
            this.lbCategory.Items.AddRange(new object[] {
            "Salary",
            "Income",
            "Allowance",
            "Cashback",
            "Gift",
            "Unexpected"});
            this.lbCategory.Location = new System.Drawing.Point(846, 324);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(333, 44);
            this.lbCategory.TabIndex = 12;
            // 
            // tbNote
            // 
            this.tbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F);
            this.tbNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tbNote.Location = new System.Drawing.Point(426, 483);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(753, 45);
            this.tbNote.TabIndex = 13;
            // 
            // btnSaveIncome
            // 
            this.btnSaveIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(205)))), ((int)(((byte)(150)))));
            this.btnSaveIncome.Font = new System.Drawing.Font("Microsoft PhagsPa", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveIncome.ForeColor = System.Drawing.Color.White;
            this.btnSaveIncome.Location = new System.Drawing.Point(648, 591);
            this.btnSaveIncome.Margin = new System.Windows.Forms.Padding(1);
            this.btnSaveIncome.Name = "btnSaveIncome";
            this.btnSaveIncome.Size = new System.Drawing.Size(313, 67);
            this.btnSaveIncome.TabIndex = 14;
            this.btnSaveIncome.Text = "Save Income";
            this.btnSaveIncome.UseVisualStyleBackColor = false;
            this.btnSaveIncome.Click += new System.EventHandler(this.btnSaveIncome_Click);
            // 
            // AddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.btnSaveIncome);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbSource);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.pbLogout);
            this.Controls.Add(this.pbExpenses);
            this.Controls.Add(this.pbIncome);
            this.Controls.Add(this.pbHome);
            this.Name = "AddIncome";
            this.Text = "AddIncome";
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.PictureBox pbIncome;
        private System.Windows.Forms.PictureBox pbExpenses;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.ListBox lbSource;
        private System.Windows.Forms.ListBox lbCategory;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Button btnSaveIncome;
    }
}