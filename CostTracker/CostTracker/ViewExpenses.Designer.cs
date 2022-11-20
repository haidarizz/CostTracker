﻿
namespace CostTracker
{
    partial class ViewExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewExpenses));
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbIncome = new System.Windows.Forms.PictureBox();
            this.pbExpenses = new System.Windows.Forms.PictureBox();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.dgvExpense = new System.Windows.Forms.DataGridView();
            this.btnLoadExpense = new System.Windows.Forms.Button();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(76, 178);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(160, 125);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHome.TabIndex = 1;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pbIncome
            // 
            this.pbIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.pbIncome.Image = ((System.Drawing.Image)(resources.GetObject("pbIncome.Image")));
            this.pbIncome.Location = new System.Drawing.Point(72, 334);
            this.pbIncome.Name = "pbIncome";
            this.pbIncome.Size = new System.Drawing.Size(170, 120);
            this.pbIncome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIncome.TabIndex = 2;
            this.pbIncome.TabStop = false;
            this.pbIncome.Click += new System.EventHandler(this.pbIncome_Click);
            // 
            // pbExpenses
            // 
            this.pbExpenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.pbExpenses.Image = ((System.Drawing.Image)(resources.GetObject("pbExpenses.Image")));
            this.pbExpenses.Location = new System.Drawing.Point(72, 483);
            this.pbExpenses.Name = "pbExpenses";
            this.pbExpenses.Size = new System.Drawing.Size(170, 150);
            this.pbExpenses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExpenses.TabIndex = 3;
            this.pbExpenses.TabStop = false;
            // 
            // pbLogout
            // 
            this.pbLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.pbLogout.Image = ((System.Drawing.Image)(resources.GetObject("pbLogout.Image")));
            this.pbLogout.Location = new System.Drawing.Point(104, 669);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(104, 55);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogout.TabIndex = 4;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // dgvExpense
            // 
            this.dgvExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpense.Location = new System.Drawing.Point(371, 290);
            this.dgvExpense.Name = "dgvExpense";
            this.dgvExpense.RowHeadersWidth = 51;
            this.dgvExpense.RowTemplate.Height = 24;
            this.dgvExpense.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpense.Size = new System.Drawing.Size(844, 416);
            this.dgvExpense.TabIndex = 9;
            this.dgvExpense.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpense_CellContentClick);
            // 
            // btnLoadExpense
            // 
            this.btnLoadExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(99)))), ((int)(((byte)(87)))));
            this.btnLoadExpense.Font = new System.Drawing.Font("Microsoft PhagsPa", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadExpense.ForeColor = System.Drawing.Color.White;
            this.btnLoadExpense.Location = new System.Drawing.Point(820, 188);
            this.btnLoadExpense.Margin = new System.Windows.Forms.Padding(1);
            this.btnLoadExpense.Name = "btnLoadExpense";
            this.btnLoadExpense.Size = new System.Drawing.Size(229, 53);
            this.btnLoadExpense.TabIndex = 16;
            this.btnLoadExpense.Text = "Load Expense";
            this.btnLoadExpense.UseVisualStyleBackColor = false;
            this.btnLoadExpense.Click += new System.EventHandler(this.btnLoadExpense_Click);
            // 
            // btnDeleteExpense
            // 
            this.btnDeleteExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(99)))), ((int)(((byte)(87)))));
            this.btnDeleteExpense.Font = new System.Drawing.Font("Microsoft PhagsPa", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExpense.ForeColor = System.Drawing.Color.White;
            this.btnDeleteExpense.Location = new System.Drawing.Point(550, 188);
            this.btnDeleteExpense.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(229, 53);
            this.btnDeleteExpense.TabIndex = 17;
            this.btnDeleteExpense.Text = "Delete Expense";
            this.btnDeleteExpense.UseVisualStyleBackColor = false;
            this.btnDeleteExpense.Click += new System.EventHandler(this.btnDeleteExpense_Click);
            // 
            // ViewExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.btnDeleteExpense);
            this.Controls.Add(this.btnLoadExpense);
            this.Controls.Add(this.dgvExpense);
            this.Controls.Add(this.pbLogout);
            this.Controls.Add(this.pbExpenses);
            this.Controls.Add(this.pbIncome);
            this.Controls.Add(this.pbHome);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ViewExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewExpenses";
            this.Load += new System.EventHandler(this.ViewExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.PictureBox pbIncome;
        private System.Windows.Forms.PictureBox pbExpenses;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.DataGridView dgvExpense;
        private System.Windows.Forms.Button btnLoadExpense;
        private System.Windows.Forms.Button btnDeleteExpense;
    }
}