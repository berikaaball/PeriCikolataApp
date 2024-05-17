namespace periCikolata
{
    partial class Workshop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workshop));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EtkAdTBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.KapasiteTBox = new System.Windows.Forms.TextBox();
            this.EtkKaydetBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AdresTBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EtkNoTBox = new System.Windows.Forms.TextBox();
            this.BtnEtkinlikSil = new System.Windows.Forms.Button();
            this.BtnEtkinlikGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(82, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etkinlik Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Etkinlik Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(28, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Etkinlik Kapasitesi:";
            // 
            // EtkAdTBox
            // 
            this.EtkAdTBox.Location = new System.Drawing.Point(198, 122);
            this.EtkAdTBox.Multiline = true;
            this.EtkAdTBox.Name = "EtkAdTBox";
            this.EtkAdTBox.Size = new System.Drawing.Size(138, 22);
            this.EtkAdTBox.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // KapasiteTBox
            // 
            this.KapasiteTBox.Location = new System.Drawing.Point(198, 231);
            this.KapasiteTBox.Name = "KapasiteTBox";
            this.KapasiteTBox.Size = new System.Drawing.Size(100, 22);
            this.KapasiteTBox.TabIndex = 5;
            // 
            // EtkKaydetBtn
            // 
            this.EtkKaydetBtn.BackColor = System.Drawing.Color.MistyRose;
            this.EtkKaydetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EtkKaydetBtn.Location = new System.Drawing.Point(464, 334);
            this.EtkKaydetBtn.Name = "EtkKaydetBtn";
            this.EtkKaydetBtn.Size = new System.Drawing.Size(155, 74);
            this.EtkKaydetBtn.TabIndex = 6;
            this.EtkKaydetBtn.Text = "Etkinliği Kaydet";
            this.EtkKaydetBtn.UseVisualStyleBackColor = false;
            this.EtkKaydetBtn.Click += new System.EventHandler(this.EtkKaydetBtn_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(58, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Etkinlik Adresi:";
            // 
            // AdresTBox
            // 
            this.AdresTBox.Location = new System.Drawing.Point(198, 290);
            this.AdresTBox.Multiline = true;
            this.AdresTBox.Name = "AdresTBox";
            this.AdresTBox.Size = new System.Drawing.Size(152, 22);
            this.AdresTBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(34, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Etkinlik Numarası:";
            // 
            // EtkNoTBox
            // 
            this.EtkNoTBox.Location = new System.Drawing.Point(198, 68);
            this.EtkNoTBox.Name = "EtkNoTBox";
            this.EtkNoTBox.ReadOnly = true;
            this.EtkNoTBox.Size = new System.Drawing.Size(100, 22);
            this.EtkNoTBox.TabIndex = 10;
            // 
            // BtnEtkinlikSil
            // 
            this.BtnEtkinlikSil.BackColor = System.Drawing.Color.MistyRose;
            this.BtnEtkinlikSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEtkinlikSil.Location = new System.Drawing.Point(63, 334);
            this.BtnEtkinlikSil.Name = "BtnEtkinlikSil";
            this.BtnEtkinlikSil.Size = new System.Drawing.Size(155, 74);
            this.BtnEtkinlikSil.TabIndex = 11;
            this.BtnEtkinlikSil.Text = "Etkinliği Sil";
            this.BtnEtkinlikSil.UseVisualStyleBackColor = false;
            this.BtnEtkinlikSil.Click += new System.EventHandler(this.BtnEtkinlikSil_Click);
            // 
            // BtnEtkinlikGuncelle
            // 
            this.BtnEtkinlikGuncelle.BackColor = System.Drawing.Color.MistyRose;
            this.BtnEtkinlikGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEtkinlikGuncelle.Location = new System.Drawing.Point(224, 334);
            this.BtnEtkinlikGuncelle.Name = "BtnEtkinlikGuncelle";
            this.BtnEtkinlikGuncelle.Size = new System.Drawing.Size(155, 74);
            this.BtnEtkinlikGuncelle.TabIndex = 12;
            this.BtnEtkinlikGuncelle.Text = "Etkinliği Güncelle";
            this.BtnEtkinlikGuncelle.UseVisualStyleBackColor = false;
            this.BtnEtkinlikGuncelle.Click += new System.EventHandler(this.BtnEtkinlikGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.Location = new System.Drawing.Point(464, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(504, 265);
            this.dataGridView1.TabIndex = 13;
            // 
            // Workshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnEtkinlikGuncelle);
            this.Controls.Add(this.BtnEtkinlikSil);
            this.Controls.Add(this.EtkNoTBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdresTBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EtkKaydetBtn);
            this.Controls.Add(this.KapasiteTBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.EtkAdTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Workshop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workshop";
            this.Load += new System.EventHandler(this.Workshop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EtkAdTBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox KapasiteTBox;
        private System.Windows.Forms.Button EtkKaydetBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdresTBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EtkNoTBox;
        private System.Windows.Forms.Button BtnEtkinlikSil;
        private System.Windows.Forms.Button BtnEtkinlikGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}