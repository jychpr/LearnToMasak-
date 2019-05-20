namespace AppTA
{
    partial class AboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            this.btnReturnAU = new System.Windows.Forms.Button();
            this.lblAUTitle = new System.Windows.Forms.Label();
            this.lblAUContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturnAU
            // 
            this.btnReturnAU.BackColor = System.Drawing.Color.White;
            this.btnReturnAU.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnAU.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnReturnAU.Location = new System.Drawing.Point(12, 12);
            this.btnReturnAU.Name = "btnReturnAU";
            this.btnReturnAU.Size = new System.Drawing.Size(75, 35);
            this.btnReturnAU.TabIndex = 0;
            this.btnReturnAU.Text = "Return";
            this.btnReturnAU.UseVisualStyleBackColor = false;
            this.btnReturnAU.Click += new System.EventHandler(this.btnReturnAU_Click);
            // 
            // lblAUTitle
            // 
            this.lblAUTitle.AutoSize = true;
            this.lblAUTitle.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAUTitle.ForeColor = System.Drawing.Color.White;
            this.lblAUTitle.Location = new System.Drawing.Point(290, 87);
            this.lblAUTitle.Name = "lblAUTitle";
            this.lblAUTitle.Size = new System.Drawing.Size(217, 58);
            this.lblAUTitle.TabIndex = 1;
            this.lblAUTitle.Text = "About Us";
            // 
            // lblAUContent
            // 
            this.lblAUContent.AutoSize = true;
            this.lblAUContent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAUContent.ForeColor = System.Drawing.Color.White;
            this.lblAUContent.Location = new System.Drawing.Point(26, 184);
            this.lblAUContent.Name = "lblAUContent";
            this.lblAUContent.Size = new System.Drawing.Size(751, 133);
            this.lblAUContent.TabIndex = 2;
            this.lblAUContent.Text = resources.GetString("lblAUContent.Text");
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAUContent);
            this.Controls.Add(this.lblAUTitle);
            this.Controls.Add(this.btnReturnAU);
            this.Name = "AboutUs";
            this.Text = "AboutUs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnAU;
        private System.Windows.Forms.Label lblAUTitle;
        private System.Windows.Forms.Label lblAUContent;
    }
}