namespace periCikolata
{
    partial class KullaniciGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxSifre = new System.Windows.Forms.TextBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kullanıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // TBoxKullaniciAdi
            // 
            this.TBoxKullaniciAdi.Location = new System.Drawing.Point(181, 65);
            this.TBoxKullaniciAdi.Name = "TBoxKullaniciAdi";
            this.TBoxKullaniciAdi.Size = new System.Drawing.Size(178, 22);
            this.TBoxKullaniciAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(115, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // TBoxSifre
            // 
            this.TBoxSifre.Location = new System.Drawing.Point(181, 131);
            this.TBoxSifre.Name = "TBoxSifre";
            this.TBoxSifre.PasswordChar = '*';
            this.TBoxSifre.Size = new System.Drawing.Size(178, 22);
            this.TBoxSifre.TabIndex = 3;
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.MistyRose;
            this.BtnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiris.ForeColor = System.Drawing.Color.Black;
            this.BtnGiris.Location = new System.Drawing.Point(181, 202);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(85, 49);
            this.BtnGiris.TabIndex = 11;
            this.BtnGiris.Text = "Giriş";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.MistyRose;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.Location = new System.Drawing.Point(311, 202);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(48, 49);
            this.btnKapat.TabIndex = 12;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıEkleToolStripMenuItem,
            this.kullanıcıSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 52);
            this.contextMenuStrip1.Text = "Yönet";
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            this.kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            this.kullanıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.kullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            this.kullanıcıEkleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEkleToolStripMenuItem_Click);
            // 
            // kullanıcıSilToolStripMenuItem
            // 
            this.kullanıcıSilToolStripMenuItem.Name = "kullanıcıSilToolStripMenuItem";
            this.kullanıcıSilToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.kullanıcıSilToolStripMenuItem.Text = "Kullanıcı Sil";
            this.kullanıcıSilToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıSilToolStripMenuItem_Click);
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(468, 313);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.TBoxSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBoxKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciGiris";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxSifre;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıSilToolStripMenuItem;
    }
}