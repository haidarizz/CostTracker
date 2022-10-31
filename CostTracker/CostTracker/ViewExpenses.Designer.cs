
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
            this.lblAccount = new System.Windows.Forms.Label();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbCategory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
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
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAccount.ForeColor = System.Drawing.Color.White;
            this.lblAccount.Location = new System.Drawing.Point(383, 209);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(119, 29);
            this.lblAccount.TabIndex = 5;
            this.lblAccount.Text = "Account :";
            // 
            // tbAccount
            // 
            this.tbAccount.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F);
            this.tbAccount.Location = new System.Drawing.Point(504, 204);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(276, 39);
            this.tbAccount.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblCategory.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(794, 207);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(127, 32);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category :";
            // 
            // tbCategory
            // 
            this.tbCategory.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCategory.Location = new System.Drawing.Point(924, 204);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(276, 39);
            this.tbCategory.TabIndex = 8;
            // 
            // ViewExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.tbAccount);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.pbLogout);
            this.Controls.Add(this.pbExpenses);
            this.Controls.Add(this.pbIncome);
            this.Controls.Add(this.pbHome);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ViewExpenses";
            this.Text = "ViewExpenses";
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
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox tbCategory;
    }
}