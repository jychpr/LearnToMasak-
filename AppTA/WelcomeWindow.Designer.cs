namespace AppTA
{
    partial class WelcomeWindow
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
            this.lblWPNamaApp = new System.Windows.Forms.Label();
            this.lblWPGreeting = new System.Windows.Forms.Label();
            this.btnEnterWP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWPNamaApp
            // 
            this.lblWPNamaApp.AutoSize = true;
            this.lblWPNamaApp.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWPNamaApp.ForeColor = System.Drawing.Color.White;
            this.lblWPNamaApp.Location = new System.Drawing.Point(43, 154);
            this.lblWPNamaApp.Name = "lblWPNamaApp";
            this.lblWPNamaApp.Size = new System.Drawing.Size(729, 116);
            this.lblWPNamaApp.TabIndex = 0;
            this.lblWPNamaApp.Text = "Learn to Masak!";
            // 
            // lblWPGreeting
            // 
            this.lblWPGreeting.AutoSize = true;
            this.lblWPGreeting.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWPGreeting.ForeColor = System.Drawing.Color.White;
            this.lblWPGreeting.Location = new System.Drawing.Point(53, 115);
            this.lblWPGreeting.Name = "lblWPGreeting";
            this.lblWPGreeting.Size = new System.Drawing.Size(274, 58);
            this.lblWPGreeting.TabIndex = 1;
            this.lblWPGreeting.Text = "Welcome to";
            // 
            // btnEnterWP
            // 
            this.btnEnterWP.BackColor = System.Drawing.Color.White;
            this.btnEnterWP.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterWP.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnEnterWP.Location = new System.Drawing.Point(337, 329);
            this.btnEnterWP.Name = "btnEnterWP";
            this.btnEnterWP.Size = new System.Drawing.Size(150, 50);
            this.btnEnterWP.TabIndex = 2;
            this.btnEnterWP.Text = "Enter";
            this.btnEnterWP.UseVisualStyleBackColor = false;
            this.btnEnterWP.Click += new System.EventHandler(this.btnEnterWP_Click);
            // 
            // WelcomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnterWP);
            this.Controls.Add(this.lblWPGreeting);
            this.Controls.Add(this.lblWPNamaApp);
            this.Name = "WelcomeWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWPNamaApp;
        private System.Windows.Forms.Label lblWPGreeting;
        private System.Windows.Forms.Button btnEnterWP;
    }
}

