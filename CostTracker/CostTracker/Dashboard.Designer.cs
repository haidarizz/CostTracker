
namespace CostTracker
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbIncome = new System.Windows.Forms.PictureBox();
            this.pbExpenses = new System.Windows.Forms.PictureBox();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.boxIncome = new System.Windows.Forms.PictureBox();
            this.boxExpenses = new System.Windows.Forms.PictureBox();
            this.boxBalance = new System.Windows.Forms.PictureBox();
            this.btIncome = new System.Windows.Forms.PictureBox();
            this.btExpenses = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIncome = new System.Windows.Forms.Label();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btExpenses)).BeginInit();
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
            this.pbHome.TabIndex = 0;
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
            this.pbIncome.TabIndex = 1;
            this.pbIncome.TabStop = false;
            this.pbIncome.Click += new System.EventHandler(this.pbIncome_Click);
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
            this.pbExpenses.Click += new System.EventHandler(this.pbExpenses_Click);
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
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lblUser.Font = new System.Drawing.Font("Microsoft PhagsPa", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(1003, 66);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(152, 43);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Hi, User!";
            // 
            // boxIncome
            // 
            this.boxIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.boxIncome.Image = ((System.Drawing.Image)(resources.GetObject("boxIncome.Image")));
            this.boxIncome.Location = new System.Drawing.Point(370, 237);
            this.boxIncome.Name = "boxIncome";
            this.boxIncome.Size = new System.Drawing.Size(400, 250);
            this.boxIncome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxIncome.TabIndex = 5;
            this.boxIncome.TabStop = false;
            // 
            // boxExpenses
            // 
            this.boxExpenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.boxExpenses.Image = ((System.Drawing.Image)(resources.GetObject("boxExpenses.Image")));
            this.boxExpenses.Location = new System.Drawing.Point(803, 237);
            this.boxExpenses.Name = "boxExpenses";
            this.boxExpenses.Size = new System.Drawing.Size(400, 250);
            this.boxExpenses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxExpenses.TabIndex = 6;
            this.boxExpenses.TabStop = false;
            // 
            // boxBalance
            // 
            this.boxBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.boxBalance.Image = ((System.Drawing.Image)(resources.GetObject("boxBalance.Image")));
            this.boxBalance.Location = new System.Drawing.Point(636, 533);
            this.boxBalance.Name = "boxBalance";
            this.boxBalance.Size = new System.Drawing.Size(300, 100);
            this.boxBalance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxBalance.TabIndex = 7;
            this.boxBalance.TabStop = false;
            this.boxBalance.Click += new System.EventHandler(this.boxBalance_Click);
            // 
            // btIncome
            // 
            this.btIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(205)))), ((int)(((byte)(150)))));
            this.btIncome.Image = ((System.Drawing.Image)(resources.GetObject("btIncome.Image")));
            this.btIncome.Location = new System.Drawing.Point(665, 379);
            this.btIncome.Name = "btIncome";
            this.btIncome.Size = new System.Drawing.Size(75, 75);
            this.btIncome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btIncome.TabIndex = 8;
            this.btIncome.TabStop = false;
            this.btIncome.Click += new System.EventHandler(this.btIncome_Click);
            // 
            // btExpenses
            // 
            this.btExpenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(99)))), ((int)(((byte)(87)))));
            this.btExpenses.Image = ((System.Drawing.Image)(resources.GetObject("btExpenses.Image")));
            this.btExpenses.Location = new System.Drawing.Point(1095, 379);
            this.btExpenses.Name = "btExpenses";
            this.btExpenses.Size = new System.Drawing.Size(75, 75);
            this.btExpenses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btExpenses.TabIndex = 9;
            this.btExpenses.TabStop = false;
            this.btExpenses.Click += new System.EventHandler(this.btExpenses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(205)))), ((int)(((byte)(150)))));
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(401, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(99)))), ((int)(((byte)(87)))));
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(835, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total :";
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(205)))), ((int)(((byte)(150)))));
            this.lblIncome.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.ForeColor = System.Drawing.Color.White;
            this.lblIncome.Location = new System.Drawing.Point(467, 301);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(70, 26);
            this.lblIncome.TabIndex = 12;
            this.lblIncome.Text = "label3";
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(99)))), ((int)(((byte)(87)))));
            this.lblOutcome.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.ForeColor = System.Drawing.Color.White;
            this.lblOutcome.Location = new System.Drawing.Point(901, 305);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(70, 26);
            this.lblOutcome.TabIndex = 13;
            this.lblOutcome.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(667, 581);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rp";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(706, 581);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(135, 33);
            this.lblBalance.TabIndex = 15;
            this.lblBalance.Text = "lblBalance";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft PhagsPa", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(673, 669);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(229, 53);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExpenses);
            this.Controls.Add(this.btIncome);
            this.Controls.Add(this.boxExpenses);
            this.Controls.Add(this.boxIncome);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pbLogout);
            this.Controls.Add(this.pbExpenses);
            this.Controls.Add(this.pbIncome);
            this.Controls.Add(this.pbHome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxBalance);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.PictureBox pbIncome;
        private System.Windows.Forms.PictureBox pbExpenses;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox boxIncome;
        private System.Windows.Forms.PictureBox boxExpenses;
        private System.Windows.Forms.PictureBox boxBalance;
        private System.Windows.Forms.PictureBox btIncome;
        private System.Windows.Forms.PictureBox btExpenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnRefresh;
    }
}