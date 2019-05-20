namespace AppTA
{
    partial class MainWindow
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
            this.lblTitleMW = new System.Windows.Forms.Label();
            this.lblJudulResep = new System.Windows.Forms.Label();
            this.tbCariResep = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.lblBahanMasak = new System.Windows.Forms.Label();
            this.lblLangkahMemasak = new System.Windows.Forms.Label();
            this.lblHasilBahanMasak = new System.Windows.Forms.Label();
            this.lblHasilLangkahMasak = new System.Windows.Forms.Label();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnTambahResep = new System.Windows.Forms.Button();
            this.btnHapusResep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitleMW
            // 
            this.lblTitleMW.AutoSize = true;
            this.lblTitleMW.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMW.ForeColor = System.Drawing.Color.White;
            this.lblTitleMW.Location = new System.Drawing.Point(240, 9);
            this.lblTitleMW.Name = "lblTitleMW";
            this.lblTitleMW.Size = new System.Drawing.Size(363, 58);
            this.lblTitleMW.TabIndex = 0;
            this.lblTitleMW.Text = "Learn to Masak!";
            // 
            // lblJudulResep
            // 
            this.lblJudulResep.AutoSize = true;
            this.lblJudulResep.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulResep.ForeColor = System.Drawing.Color.White;
            this.lblJudulResep.Location = new System.Drawing.Point(75, 74);
            this.lblJudulResep.Name = "lblJudulResep";
            this.lblJudulResep.Size = new System.Drawing.Size(94, 19);
            this.lblJudulResep.TabIndex = 1;
            this.lblJudulResep.Text = "Judul Resep";
            // 
            // tbCariResep
            // 
            this.tbCariResep.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCariResep.Location = new System.Drawing.Point(79, 96);
            this.tbCariResep.Name = "tbCariResep";
            this.tbCariResep.Size = new System.Drawing.Size(550, 21);
            this.tbCariResep.TabIndex = 2;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.White;
            this.btnCari.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCari.Location = new System.Drawing.Point(644, 90);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(100, 30);
            this.btnCari.TabIndex = 3;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // lblBahanMasak
            // 
            this.lblBahanMasak.AutoSize = true;
            this.lblBahanMasak.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBahanMasak.ForeColor = System.Drawing.Color.White;
            this.lblBahanMasak.Location = new System.Drawing.Point(75, 131);
            this.lblBahanMasak.Name = "lblBahanMasak";
            this.lblBahanMasak.Size = new System.Drawing.Size(100, 19);
            this.lblBahanMasak.TabIndex = 4;
            this.lblBahanMasak.Text = "Bahan Masak";
            // 
            // lblLangkahMemasak
            // 
            this.lblLangkahMemasak.AutoSize = true;
            this.lblLangkahMemasak.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLangkahMemasak.ForeColor = System.Drawing.Color.White;
            this.lblLangkahMemasak.Location = new System.Drawing.Point(297, 131);
            this.lblLangkahMemasak.Name = "lblLangkahMemasak";
            this.lblLangkahMemasak.Size = new System.Drawing.Size(138, 19);
            this.lblLangkahMemasak.TabIndex = 5;
            this.lblLangkahMemasak.Text = "Langkah Memasak";
            // 
            // lblHasilBahanMasak
            // 
            this.lblHasilBahanMasak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHasilBahanMasak.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasilBahanMasak.ForeColor = System.Drawing.Color.White;
            this.lblHasilBahanMasak.Location = new System.Drawing.Point(79, 154);
            this.lblHasilBahanMasak.Name = "lblHasilBahanMasak";
            this.lblHasilBahanMasak.Size = new System.Drawing.Size(200, 200);
            this.lblHasilBahanMasak.TabIndex = 6;
            this.lblHasilBahanMasak.Text = "-";
            // 
            // lblHasilLangkahMasak
            // 
            this.lblHasilLangkahMasak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHasilLangkahMasak.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasilLangkahMasak.ForeColor = System.Drawing.Color.White;
            this.lblHasilLangkahMasak.Location = new System.Drawing.Point(301, 154);
            this.lblHasilLangkahMasak.Name = "lblHasilLangkahMasak";
            this.lblHasilLangkahMasak.Size = new System.Drawing.Size(440, 200);
            this.lblHasilLangkahMasak.TabIndex = 7;
            this.lblHasilLangkahMasak.Text = "-";
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.White;
            this.btnAboutUs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAboutUs.Location = new System.Drawing.Point(12, 408);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(100, 30);
            this.btnAboutUs.TabIndex = 8;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnTambahResep
            // 
            this.btnTambahResep.BackColor = System.Drawing.Color.White;
            this.btnTambahResep.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahResep.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnTambahResep.Location = new System.Drawing.Point(538, 368);
            this.btnTambahResep.Name = "btnTambahResep";
            this.btnTambahResep.Size = new System.Drawing.Size(100, 30);
            this.btnTambahResep.TabIndex = 9;
            this.btnTambahResep.Text = "Tambah Resep";
            this.btnTambahResep.UseVisualStyleBackColor = false;
            this.btnTambahResep.Click += new System.EventHandler(this.btnTambahResep_Click);
            // 
            // btnHapusResep
            // 
            this.btnHapusResep.BackColor = System.Drawing.Color.White;
            this.btnHapusResep.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapusResep.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnHapusResep.Location = new System.Drawing.Point(644, 368);
            this.btnHapusResep.Name = "btnHapusResep";
            this.btnHapusResep.Size = new System.Drawing.Size(100, 30);
            this.btnHapusResep.TabIndex = 11;
            this.btnHapusResep.Text = "Hapus Resep";
            this.btnHapusResep.UseVisualStyleBackColor = false;
            this.btnHapusResep.Click += new System.EventHandler(this.btnHapusResep_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHapusResep);
            this.Controls.Add(this.btnTambahResep);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.lblHasilLangkahMasak);
            this.Controls.Add(this.lblHasilBahanMasak);
            this.Controls.Add(this.lblLangkahMemasak);
            this.Controls.Add(this.lblBahanMasak);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.tbCariResep);
            this.Controls.Add(this.lblJudulResep);
            this.Controls.Add(this.lblTitleMW);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleMW;
        private System.Windows.Forms.Label lblJudulResep;
        private System.Windows.Forms.TextBox tbCariResep;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label lblBahanMasak;
        private System.Windows.Forms.Label lblLangkahMemasak;
        private System.Windows.Forms.Label lblHasilBahanMasak;
        private System.Windows.Forms.Label lblHasilLangkahMasak;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnTambahResep;
        private System.Windows.Forms.Button btnHapusResep;
    }
}