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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgisayarEkleÇıkartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUyandir
            // 
            this.btnUyandir.Location = new System.Drawing.Point(341, 31);
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
            this.cmbxPC.Location = new System.Drawing.Point(12, 46);
            this.cmbxPC.Name = "cmbxPC";
            this.cmbxPC.Size = new System.Drawing.Size(323, 23);
            this.cmbxPC.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgisayarEkleÇıkartToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // bilgisayarEkleÇıkartToolStripMenuItem
            // 
            this.bilgisayarEkleÇıkartToolStripMenuItem.Name = "bilgisayarEkleÇıkartToolStripMenuItem";
            this.bilgisayarEkleÇıkartToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.bilgisayarEkleÇıkartToolStripMenuItem.Text = "Bilgisayar Ekle/Çıkart";
            this.bilgisayarEkleÇıkartToolStripMenuItem.Click += new System.EventHandler(this.bilgisayarEkleÇıkartToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 114);
            this.Controls.Add(this.cmbxPC);
            this.Controls.Add(this.btnUyandir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bilgisayar Uyandırma Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUyandir;
        private ComboBox cmbxPC;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem bilgisayarEkleÇıkartToolStripMenuItem;
    }
}