namespace CostTracker
{
    partial class Logout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logout));
            this.lblLogout = new System.Windows.Forms.Label();
            this.btnLogoutNo = new System.Windows.Forms.Button();
            this.btnLogoutYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lblLogout.Font = new System.Drawing.Font("Microsoft PhagsPa", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Black;
            this.lblLogout.Location = new System.Drawing.Point(461, 292);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(325, 76);
            this.lblLogout.TabIndex = 0;
            this.lblLogout.Text = "Oh no! You’re leaving...\nAre you sure?";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogoutNo
            // 
            this.btnLogoutNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnLogoutNo.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnLogoutNo.Location = new System.Drawing.Point(419, 396);
            this.btnLogoutNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogoutNo.Name = "btnLogoutNo";
            this.btnLogoutNo.Size = new System.Drawing.Size(427, 74);
            this.btnLogoutNo.TabIndex = 1;
            this.btnLogoutNo.Text = "Naah, Just Kidding";
            this.btnLogoutNo.UseVisualStyleBackColor = false;
            this.btnLogoutNo.Click += new System.EventHandler(this.btnLogoutNo_Click);
            // 
            // btnLogoutYes
            // 
            this.btnLogoutYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnLogoutYes.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogoutYes.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutYes.Location = new System.Drawing.Point(419, 500);
            this.btnLogoutYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogoutYes.Name = "btnLogoutYes";
            this.btnLogoutYes.Size = new System.Drawing.Size(427, 74);
            this.btnLogoutYes.TabIndex = 2;
            this.btnLogoutYes.Text = "Yes, Log Me Out";
            this.btnLogoutYes.UseVisualStyleBackColor = false;
            this.btnLogoutYes.Click += new System.EventHandler(this.btnLogoutYes_Click);
            // 
            // Logout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 702);
            this.Controls.Add(this.btnLogoutYes);
            this.Controls.Add(this.btnLogoutNo);
            this.Controls.Add(this.lblLogout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Logout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Button btnLogoutNo;
        private System.Windows.Forms.Button btnLogoutYes;
    }
}