namespace periCikolata
{
    partial class MüşteriKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MüşteriKayıt));
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxMusteriNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxMusteriAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBoxFirmaAdi = new System.Windows.Forms.TextBox();
            this.BtnMusteriEkle = new System.Windows.Forms.Button();
            this.BtnMusteriGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TBoxTelefon = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TBoxSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri No:";
            // 
            // TBoxMusteriNo
            // 
            this.TBoxMusteriNo.Location = new System.Drawing.Point(171, 72);
            this.TBoxMusteriNo.Name = "TBoxMusteriNo";
            this.TBoxMusteriNo.ReadOnly = true;
            this.TBoxMusteriNo.Size = new System.Drawing.Size(100, 22);
            this.TBoxMusteriNo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri Adı:";
            // 
            // TBoxMusteriAdi
            // 
            this.TBoxMusteriAdi.Location = new System.Drawing.Point(171, 131);
            this.TBoxMusteriAdi.Name = "TBoxMusteriAdi";
            this.TBoxMusteriAdi.Size = new System.Drawing.Size(184, 22);
            this.TBoxMusteriAdi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(56, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Firma Adı:";
            // 
            // TBoxFirmaAdi
            // 
            this.TBoxFirmaAdi.Location = new System.Drawing.Point(171, 231);
            this.TBoxFirmaAdi.Name = "TBoxFirmaAdi";
            this.TBoxFirmaAdi.Size = new System.Drawing.Size(184, 22);
            this.TBoxFirmaAdi.TabIndex = 8;
            // 
            // BtnMusteriEkle
            // 
            this.BtnMusteriEkle.BackColor = System.Drawing.Color.MistyRose;
            this.BtnMusteriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriEkle.ForeColor = System.Drawing.Color.Black;
            this.BtnMusteriEkle.Location = new System.Drawing.Point(255, 343);
            this.BtnMusteriEkle.Name = "BtnMusteriEkle";
            this.BtnMusteriEkle.Size = new System.Drawing.Size(100, 45);
            this.BtnMusteriEkle.TabIndex = 10;
            this.BtnMusteriEkle.Text = "Kaydet";
            this.BtnMusteriEkle.UseVisualStyleBackColor = false;
            this.BtnMusteriEkle.Click += new System.EventHandler(this.BtnMusteriEkle_Click);
            // 
            // BtnMusteriGuncelle
            // 
            this.BtnMusteriGuncelle.BackColor = System.Drawing.Color.MistyRose;
            this.BtnMusteriGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriGuncelle.ForeColor = System.Drawing.Color.Black;
            this.BtnMusteriGuncelle.Location = new System.Drawing.Point(60, 343);
            this.BtnMusteriGuncelle.Name = "BtnMusteriGuncelle";
            this.BtnMusteriGuncelle.Size = new System.Drawing.Size(102, 45);
            this.BtnMusteriGuncelle.TabIndex = 11;
            this.BtnMusteriGuncelle.Text = "Güncelle";
            this.BtnMusteriGuncelle.UseVisualStyleBackColor = false;
            this.BtnMusteriGuncelle.Click += new System.EventHandler(this.BtnMusteriGuncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(43, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefon No:";
            // 
            // TBoxTelefon
            // 
            this.TBoxTelefon.Location = new System.Drawing.Point(171, 281);
            this.TBoxTelefon.Name = "TBoxTelefon";
            this.TBoxTelefon.Size = new System.Drawing.Size(184, 22);
            this.TBoxTelefon.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.GridColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.Location = new System.Drawing.Point(434, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(527, 342);
            this.dataGridView1.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 52);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // TBoxSoyad
            // 
            this.TBoxSoyad.Location = new System.Drawing.Point(171, 181);
            this.TBoxSoyad.Name = "TBoxSoyad";
            this.TBoxSoyad.Size = new System.Drawing.Size(184, 22);
            this.TBoxSoyad.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Müşteri Soyadı:";
            // 
            // MüşteriKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(993, 458);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBoxSoyad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TBoxTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnMusteriGuncelle);
            this.Controls.Add(this.BtnMusteriEkle);
            this.Controls.Add(this.TBoxFirmaAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBoxMusteriAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBoxMusteriNo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MüşteriKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MüşteriKayıt";
            this.Load += new System.EventHandler(this.MüşteriKayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxMusteriNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxMusteriAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBoxFirmaAdi;
        private System.Windows.Forms.Button BtnMusteriEkle;
        private System.Windows.Forms.Button BtnMusteriGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBoxTelefon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TBoxSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}