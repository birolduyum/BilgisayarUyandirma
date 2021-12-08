namespace Uyandirma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUyandir = new System.Windows.Forms.Button();
            this.cmbxPC = new System.Windows.Forms.ComboBox();
            this.btnBilgisayarListesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUyandir
            // 
            this.btnUyandir.Location = new System.Drawing.Point(341, 12);
            this.btnUyandir.Name = "btnUyandir";
            this.btnUyandir.Size = new System.Drawing.Size(138, 71);
            this.btnUyandir.TabIndex = 0;
            this.btnUyandir.Text = "Uyandır";
            this.btnUyandir.UseVisualStyleBackColor = true;
            this.btnUyandir.Click += new System.EventHandler(this.btnUyandir_Click);
            // 
            // cmbxPC
            // 
            this.cmbxPC.FormattingEnabled = true;
            this.cmbxPC.Location = new System.Drawing.Point(12, 31);
            this.cmbxPC.Name = "cmbxPC";
            this.cmbxPC.Size = new System.Drawing.Size(323, 23);
            this.cmbxPC.TabIndex = 1;
            // 
            // btnBilgisayarListesi
            // 
            this.btnBilgisayarListesi.Location = new System.Drawing.Point(0, 89);
            this.btnBilgisayarListesi.Name = "btnBilgisayarListesi";
            this.btnBilgisayarListesi.Size = new System.Drawing.Size(75, 23);
            this.btnBilgisayarListesi.TabIndex = 2;
            this.btnBilgisayarListesi.Text = "Bilgisayarları göster";
            this.btnBilgisayarListesi.UseVisualStyleBackColor = true;
            this.btnBilgisayarListesi.Click += new System.EventHandler(this.btnBilgisayarListesi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 114);
            this.Controls.Add(this.btnBilgisayarListesi);
            this.Controls.Add(this.cmbxPC);
            this.Controls.Add(this.btnUyandir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnUyandir;
        private ComboBox cmbxPC;
        private Button btnBilgisayarListesi;
    }
}