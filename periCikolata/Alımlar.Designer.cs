namespace periCikolata
{
    partial class Alımlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alımlar));
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxAlimNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPMalSKT = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TBoxAlimMiktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBoxAlimTutari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CBoxOdemeTuru = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DTPAlimTarih = new System.Windows.Forms.DateTimePicker();
            this.BtnAlimEkle = new System.Windows.Forms.Button();
            this.BtnAlimGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CBoxMalNo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alım No:";
            // 
            // TBoxAlimNo
            // 
            this.TBoxAlimNo.Location = new System.Drawing.Point(194, 47);
            this.TBoxAlimNo.Name = "TBoxAlimNo";
            this.TBoxAlimNo.ReadOnly = true;
            this.TBoxAlimNo.Size = new System.Drawing.Size(100, 22);
            this.TBoxAlimNo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(105, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mal Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(95, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mal SKT:";
            // 
            // DTPMalSKT
            // 
            this.DTPMalSKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTPMalSKT.Location = new System.Drawing.Point(194, 140);
            this.DTPMalSKT.Name = "DTPMalSKT";
            this.DTPMalSKT.Size = new System.Drawing.Size(239, 27);
            this.DTPMalSKT.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alım Miktarı (kg):";
            // 
            // TBoxAlimMiktar
            // 
            this.TBoxAlimMiktar.Location = new System.Drawing.Point(194, 193);
            this.TBoxAlimMiktar.Name = "TBoxAlimMiktar";
            this.TBoxAlimMiktar.Size = new System.Drawing.Size(100, 22);
            this.TBoxAlimMiktar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(63, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ödeme Türü:";
            // 
            // TBoxAlimTutari
            // 
            this.TBoxAlimTutari.Location = new System.Drawing.Point(194, 289);
            this.TBoxAlimTutari.Name = "TBoxAlimTutari";
            this.TBoxAlimTutari.Size = new System.Drawing.Size(100, 22);
            this.TBoxAlimTutari.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(78, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alım Tutarı:";
            // 
            // CBoxOdemeTuru
            // 
            this.CBoxOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxOdemeTuru.FormattingEnabled = true;
            this.CBoxOdemeTuru.Items.AddRange(new object[] {
            "Kredi Kartı",
            "Nakit"});
            this.CBoxOdemeTuru.Location = new System.Drawing.Point(194, 240);
            this.CBoxOdemeTuru.Name = "CBoxOdemeTuru";
            this.CBoxOdemeTuru.Size = new System.Drawing.Size(121, 24);
            this.CBoxOdemeTuru.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(79, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Alım Tarihi:";
            // 
            // DTPAlimTarih
            // 
            this.DTPAlimTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTPAlimTarih.Location = new System.Drawing.Point(194, 333);
            this.DTPAlimTarih.Name = "DTPAlimTarih";
            this.DTPAlimTarih.Size = new System.Drawing.Size(239, 27);
            this.DTPAlimTarih.TabIndex = 13;
            // 
            // BtnAlimEkle
            // 
            this.BtnAlimEkle.BackColor = System.Drawing.Color.MistyRose;
            this.BtnAlimEkle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAlimEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnAlimEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnAlimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAlimEkle.ForeColor = System.Drawing.Color.Black;
            this.BtnAlimEkle.Location = new System.Drawing.Point(333, 404);
            this.BtnAlimEkle.Name = "BtnAlimEkle";
            this.BtnAlimEkle.Size = new System.Drawing.Size(100, 65);
            this.BtnAlimEkle.TabIndex = 14;
            this.BtnAlimEkle.Text = "Alımı Ekle";
            this.BtnAlimEkle.UseVisualStyleBackColor = false;
            this.BtnAlimEkle.Click += new System.EventHandler(this.BtnAlimEkle_Click);
            // 
            // BtnAlimGuncelle
            // 
            this.BtnAlimGuncelle.BackColor = System.Drawing.Color.MistyRose;
            this.BtnAlimGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAlimGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnAlimGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnAlimGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAlimGuncelle.ForeColor = System.Drawing.Color.Black;
            this.BtnAlimGuncelle.Location = new System.Drawing.Point(67, 404);
            this.BtnAlimGuncelle.Name = "BtnAlimGuncelle";
            this.BtnAlimGuncelle.Size = new System.Drawing.Size(114, 65);
            this.BtnAlimGuncelle.TabIndex = 15;
            this.BtnAlimGuncelle.Text = "Alımı Güncelle";
            this.BtnAlimGuncelle.UseVisualStyleBackColor = false;
            this.BtnAlimGuncelle.Click += new System.EventHandler(this.BtnAlimGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.GridColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.Location = new System.Drawing.Point(502, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(586, 422);
            this.dataGridView1.TabIndex = 17;
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
            // CBoxMalNo
            // 
            this.CBoxMalNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxMalNo.FormattingEnabled = true;
            this.CBoxMalNo.Items.AddRange(new object[] {
            "Beyaz Kuvertur Çikolata",
            "Bitter Kuvertur Çikolata",
            "Sürlü Kuvertur Çikolata",
            "Türk Kahvesi",
            "Krema",
            "Kuru Meyve",
            "Tahin",
            "Yulaf Ezmesi",
            "Tarçın",
            "Badem",
            "Antep Fıstığı",
            "Yer Fıstığı"});
            this.CBoxMalNo.Location = new System.Drawing.Point(194, 91);
            this.CBoxMalNo.Name = "CBoxMalNo";
            this.CBoxMalNo.Size = new System.Drawing.Size(239, 24);
            this.CBoxMalNo.TabIndex = 8;
            // 
            // Alımlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1120, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAlimGuncelle);
            this.Controls.Add(this.CBoxMalNo);
            this.Controls.Add(this.BtnAlimEkle);
            this.Controls.Add(this.DTPAlimTarih);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBoxOdemeTuru);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBoxAlimTutari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBoxAlimMiktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTPMalSKT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBoxAlimNo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alımlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alımlar";
            this.Load += new System.EventHandler(this.Alımlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxAlimNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTPMalSKT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBoxAlimMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBoxAlimTutari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBoxOdemeTuru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTPAlimTarih;
        private System.Windows.Forms.Button BtnAlimEkle;
        private System.Windows.Forms.Button BtnAlimGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ComboBox CBoxMalNo;
    }
}