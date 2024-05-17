namespace periCikolata
{
    partial class Üretimler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Üretimler));
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxUrunNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxUretimNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBoxUretimMiktar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBoxUretimTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DTPUretim = new System.Windows.Forms.DateTimePicker();
            this.BtnUretimEkle = new System.Windows.Forms.Button();
            this.BtnUretimiSil = new System.Windows.Forms.Button();
            this.BtnUretimGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(163, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün No:";
            // 
            // TBoxUrunNo
            // 
            this.TBoxUrunNo.Location = new System.Drawing.Point(261, 94);
            this.TBoxUrunNo.Name = "TBoxUrunNo";
            this.TBoxUrunNo.Size = new System.Drawing.Size(100, 22);
            this.TBoxUrunNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(150, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Üretim No:";
            // 
            // TBoxUretimNo
            // 
            this.TBoxUretimNo.Location = new System.Drawing.Point(261, 41);
            this.TBoxUretimNo.Name = "TBoxUretimNo";
            this.TBoxUretimNo.ReadOnly = true;
            this.TBoxUretimNo.Size = new System.Drawing.Size(100, 22);
            this.TBoxUretimNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(65, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Üretim Miktarı (adet) :";
            // 
            // TBoxUretimMiktar
            // 
            this.TBoxUretimMiktar.AllowDrop = true;
            this.TBoxUretimMiktar.Location = new System.Drawing.Point(262, 147);
            this.TBoxUretimMiktar.Name = "TBoxUretimMiktar";
            this.TBoxUretimMiktar.Size = new System.Drawing.Size(100, 22);
            this.TBoxUretimMiktar.TabIndex = 5;
            this.TBoxUretimMiktar.Text = "28";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(126, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Üretim Tutarı:";
            // 
            // TBoxUretimTutar
            // 
            this.TBoxUretimTutar.AllowDrop = true;
            this.TBoxUretimTutar.Location = new System.Drawing.Point(262, 206);
            this.TBoxUretimTutar.Name = "TBoxUretimTutar";
            this.TBoxUretimTutar.Size = new System.Drawing.Size(100, 22);
            this.TBoxUretimTutar.TabIndex = 7;
            this.TBoxUretimTutar.Text = "4,5 ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(128, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Üretim Tarihi:";
            // 
            // DTPUretim
            // 
            this.DTPUretim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTPUretim.Location = new System.Drawing.Point(261, 260);
            this.DTPUretim.Name = "DTPUretim";
            this.DTPUretim.Size = new System.Drawing.Size(240, 27);
            this.DTPUretim.TabIndex = 9;
            // 
            // BtnUretimEkle
            // 
            this.BtnUretimEkle.BackColor = System.Drawing.Color.MistyRose;
            this.BtnUretimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUretimEkle.ForeColor = System.Drawing.Color.Black;
            this.BtnUretimEkle.Location = new System.Drawing.Point(421, 330);
            this.BtnUretimEkle.Name = "BtnUretimEkle";
            this.BtnUretimEkle.Size = new System.Drawing.Size(123, 82);
            this.BtnUretimEkle.TabIndex = 10;
            this.BtnUretimEkle.Text = "Üretimi Ekle";
            this.BtnUretimEkle.UseVisualStyleBackColor = false;
            this.BtnUretimEkle.Click += new System.EventHandler(this.BtnUretimEkle_Click);
            // 
            // BtnUretimiSil
            // 
            this.BtnUretimiSil.BackColor = System.Drawing.Color.MistyRose;
            this.BtnUretimiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUretimiSil.ForeColor = System.Drawing.Color.Black;
            this.BtnUretimiSil.Location = new System.Drawing.Point(46, 330);
            this.BtnUretimiSil.Name = "BtnUretimiSil";
            this.BtnUretimiSil.Size = new System.Drawing.Size(117, 82);
            this.BtnUretimiSil.TabIndex = 11;
            this.BtnUretimiSil.Text = "Üretimi Sil";
            this.BtnUretimiSil.UseVisualStyleBackColor = false;
            this.BtnUretimiSil.Click += new System.EventHandler(this.BtnUretimiSil_Click);
            // 
            // BtnUretimGuncelle
            // 
            this.BtnUretimGuncelle.BackColor = System.Drawing.Color.MistyRose;
            this.BtnUretimGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUretimGuncelle.ForeColor = System.Drawing.Color.Black;
            this.BtnUretimGuncelle.Location = new System.Drawing.Point(179, 330);
            this.BtnUretimGuncelle.Name = "BtnUretimGuncelle";
            this.BtnUretimGuncelle.Size = new System.Drawing.Size(117, 82);
            this.BtnUretimGuncelle.TabIndex = 12;
            this.BtnUretimGuncelle.Text = "Üretimi Güncelle";
            this.BtnUretimGuncelle.UseVisualStyleBackColor = false;
            this.BtnUretimGuncelle.Click += new System.EventHandler(this.BtnUretimGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.Location = new System.Drawing.Point(577, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(462, 373);
            this.dataGridView1.TabIndex = 13;
            // 
            // Üretimler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1079, 470);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnUretimGuncelle);
            this.Controls.Add(this.BtnUretimiSil);
            this.Controls.Add(this.BtnUretimEkle);
            this.Controls.Add(this.DTPUretim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBoxUretimTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBoxUretimMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBoxUretimNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBoxUrunNo);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Üretimler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üretimler";
            this.Load += new System.EventHandler(this.Üretimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxUrunNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxUretimNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBoxUretimMiktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBoxUretimTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTPUretim;
        private System.Windows.Forms.Button BtnUretimEkle;
        private System.Windows.Forms.Button BtnUretimiSil;
        private System.Windows.Forms.Button BtnUretimGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}