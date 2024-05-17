namespace periCikolata
{
    partial class Satışlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Satışlar));
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxSatisNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxKutulama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBoxSatisTuru = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBoxSatisMiktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBoxSatisTutari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DTPSatis = new System.Windows.Forms.DateTimePicker();
            this.BtnSatisEkle = new System.Windows.Forms.Button();
            this.BtnSatisSil = new System.Windows.Forms.Button();
            this.BtnSatisGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(100, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satış No:";
            // 
            // TBoxSatisNo
            // 
            this.TBoxSatisNo.Location = new System.Drawing.Point(200, 100);
            this.TBoxSatisNo.Name = "TBoxSatisNo";
            this.TBoxSatisNo.ReadOnly = true;
            this.TBoxSatisNo.Size = new System.Drawing.Size(100, 22);
            this.TBoxSatisNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kutulama No:";
            // 
            // TBoxKutulama
            // 
            this.TBoxKutulama.Location = new System.Drawing.Point(200, 149);
            this.TBoxKutulama.Name = "TBoxKutulama";
            this.TBoxKutulama.Size = new System.Drawing.Size(100, 22);
            this.TBoxKutulama.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(85, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Satış Türü:";
            // 
            // CBoxSatisTuru
            // 
            this.CBoxSatisTuru.FormattingEnabled = true;
            this.CBoxSatisTuru.Items.AddRange(new object[] {
            "Kredi Kartı",
            "Nakit"});
            this.CBoxSatisTuru.Location = new System.Drawing.Point(200, 197);
            this.CBoxSatisTuru.Name = "CBoxSatisTuru";
            this.CBoxSatisTuru.Size = new System.Drawing.Size(121, 24);
            this.CBoxSatisTuru.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Satış Miktarı (adet):";
            // 
            // TBoxSatisMiktar
            // 
            this.TBoxSatisMiktar.Location = new System.Drawing.Point(200, 246);
            this.TBoxSatisMiktar.Name = "TBoxSatisMiktar";
            this.TBoxSatisMiktar.Size = new System.Drawing.Size(100, 22);
            this.TBoxSatisMiktar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(76, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Satış Tutarı:";
            // 
            // TBoxSatisTutari
            // 
            this.TBoxSatisTutari.Location = new System.Drawing.Point(200, 301);
            this.TBoxSatisTutari.Name = "TBoxSatisTutari";
            this.TBoxSatisTutari.Size = new System.Drawing.Size(100, 22);
            this.TBoxSatisTutari.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(77, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Satış Tarihi:";
            // 
            // DTPSatis
            // 
            this.DTPSatis.Location = new System.Drawing.Point(200, 358);
            this.DTPSatis.Name = "DTPSatis";
            this.DTPSatis.Size = new System.Drawing.Size(200, 22);
            this.DTPSatis.TabIndex = 11;
            // 
            // BtnSatisEkle
            // 
            this.BtnSatisEkle.BackColor = System.Drawing.Color.MistyRose;
            this.BtnSatisEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSatisEkle.ForeColor = System.Drawing.Color.Black;
            this.BtnSatisEkle.Location = new System.Drawing.Point(369, 422);
            this.BtnSatisEkle.Name = "BtnSatisEkle";
            this.BtnSatisEkle.Size = new System.Drawing.Size(124, 70);
            this.BtnSatisEkle.TabIndex = 12;
            this.BtnSatisEkle.Text = "Satış Ekle";
            this.BtnSatisEkle.UseVisualStyleBackColor = false;
            this.BtnSatisEkle.Click += new System.EventHandler(this.BtnSatisEkle_Click);
            // 
            // BtnSatisSil
            // 
            this.BtnSatisSil.BackColor = System.Drawing.Color.MistyRose;
            this.BtnSatisSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSatisSil.ForeColor = System.Drawing.Color.Black;
            this.BtnSatisSil.Location = new System.Drawing.Point(36, 422);
            this.BtnSatisSil.Name = "BtnSatisSil";
            this.BtnSatisSil.Size = new System.Drawing.Size(123, 70);
            this.BtnSatisSil.TabIndex = 13;
            this.BtnSatisSil.Text = "Satışı Sil";
            this.BtnSatisSil.UseVisualStyleBackColor = false;
            this.BtnSatisSil.Click += new System.EventHandler(this.BtnSatisSil_Click);
            // 
            // BtnSatisGuncelle
            // 
            this.BtnSatisGuncelle.BackColor = System.Drawing.Color.MistyRose;
            this.BtnSatisGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSatisGuncelle.ForeColor = System.Drawing.Color.Black;
            this.BtnSatisGuncelle.Location = new System.Drawing.Point(173, 422);
            this.BtnSatisGuncelle.Name = "BtnSatisGuncelle";
            this.BtnSatisGuncelle.Size = new System.Drawing.Size(124, 70);
            this.BtnSatisGuncelle.TabIndex = 14;
            this.BtnSatisGuncelle.Text = "Satışı Güncelle";
            this.BtnSatisGuncelle.UseVisualStyleBackColor = false;
            this.BtnSatisGuncelle.Click += new System.EventHandler(this.BtnSatisGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.Location = new System.Drawing.Point(529, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(496, 394);
            this.dataGridView1.TabIndex = 15;
            // 
            // Satışlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1065, 611);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSatisGuncelle);
            this.Controls.Add(this.BtnSatisSil);
            this.Controls.Add(this.BtnSatisEkle);
            this.Controls.Add(this.DTPSatis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBoxSatisTutari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBoxSatisMiktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBoxSatisTuru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBoxKutulama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBoxSatisNo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Satışlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satışlar";
            this.Load += new System.EventHandler(this.Satışlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxSatisNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxKutulama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBoxSatisTuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBoxSatisMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBoxSatisTutari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTPSatis;
        private System.Windows.Forms.Button BtnSatisEkle;
        private System.Windows.Forms.Button BtnSatisSil;
        private System.Windows.Forms.Button BtnSatisGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}