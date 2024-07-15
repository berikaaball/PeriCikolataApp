namespace periCikolata
{
    partial class Ürünler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ürünler));
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxUrunNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBoxDolgu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CBoxMeyve = new System.Windows.Forms.ComboBox();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.BtnUrunGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TBoxUrunAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün No:";
            // 
            // TBoxUrunNo
            // 
            this.TBoxUrunNo.Location = new System.Drawing.Point(165, 65);
            this.TBoxUrunNo.Name = "TBoxUrunNo";
            this.TBoxUrunNo.ReadOnly = true;
            this.TBoxUrunNo.Size = new System.Drawing.Size(100, 22);
            this.TBoxUrunNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Dolgusu:";
            // 
            // CBoxDolgu
            // 
            this.CBoxDolgu.FormattingEnabled = true;
            this.CBoxDolgu.Items.AddRange(new object[] {
            "Beyaz Krema",
            "Siyah Krema",
            "Limonlu Krema",
            "Portakallı Krema",
            "Çilekli Krema",
            "Tahin",
            "Yok"});
            this.CBoxDolgu.Location = new System.Drawing.Point(165, 164);
            this.CBoxDolgu.Name = "CBoxDolgu";
            this.CBoxDolgu.Size = new System.Drawing.Size(121, 24);
            this.CBoxDolgu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Meyvesi:";
            // 
            // CBoxMeyve
            // 
            this.CBoxMeyve.FormattingEnabled = true;
            this.CBoxMeyve.Items.AddRange(new object[] {
            "Çilek",
            "Portakal",
            "Limon",
            "Muz",
            "Yok"});
            this.CBoxMeyve.Location = new System.Drawing.Point(165, 212);
            this.CBoxMeyve.Name = "CBoxMeyve";
            this.CBoxMeyve.Size = new System.Drawing.Size(121, 24);
            this.CBoxMeyve.TabIndex = 7;
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.BackColor = System.Drawing.Color.MistyRose;
            this.BtnUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunEkle.ForeColor = System.Drawing.Color.Black;
            this.BtnUrunEkle.Location = new System.Drawing.Point(284, 280);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(100, 69);
            this.BtnUrunEkle.TabIndex = 8;
            this.BtnUrunEkle.Text = "Ürünü Ekle";
            this.BtnUrunEkle.UseVisualStyleBackColor = false;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click_1);
            // 
            // BtnUrunGuncelle
            // 
            this.BtnUrunGuncelle.BackColor = System.Drawing.Color.MistyRose;
            this.BtnUrunGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunGuncelle.ForeColor = System.Drawing.Color.Black;
            this.BtnUrunGuncelle.Location = new System.Drawing.Point(39, 280);
            this.BtnUrunGuncelle.Name = "BtnUrunGuncelle";
            this.BtnUrunGuncelle.Size = new System.Drawing.Size(116, 69);
            this.BtnUrunGuncelle.TabIndex = 10;
            this.BtnUrunGuncelle.Text = "Ürünü Güncelle";
            this.BtnUrunGuncelle.UseVisualStyleBackColor = false;
            this.BtnUrunGuncelle.Click += new System.EventHandler(this.BtnUrunGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.GridColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.Location = new System.Drawing.Point(418, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(389, 286);
            this.dataGridView1.TabIndex = 11;
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
            // TBoxUrunAdi
            // 
            this.TBoxUrunAdi.Location = new System.Drawing.Point(165, 111);
            this.TBoxUrunAdi.Name = "TBoxUrunAdi";
            this.TBoxUrunAdi.Size = new System.Drawing.Size(100, 22);
            this.TBoxUrunAdi.TabIndex = 5;
            // 
            // Ürünler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(855, 425);
            this.Controls.Add(this.TBoxUrunAdi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnUrunGuncelle);
            this.Controls.Add(this.BtnUrunEkle);
            this.Controls.Add(this.CBoxMeyve);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBoxDolgu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBoxUrunNo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ürünler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ürünler";
            this.Load += new System.EventHandler(this.Ürünler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxUrunNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBoxDolgu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBoxMeyve;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.Button BtnUrunGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.TextBox TBoxUrunAdi;
    }
}