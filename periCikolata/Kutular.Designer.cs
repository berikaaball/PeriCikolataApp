namespace periCikolata
{
    partial class Kutular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kutular));
            this.label2 = new System.Windows.Forms.Label();
            this.YokRBtn = new System.Windows.Forms.RadioButton();
            this.KutuEkleBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBCikolataSecim = new System.Windows.Forms.ComboBox();
            this.KonfetiRBtn = new System.Windows.Forms.RadioButton();
            this.DrajeRBtn = new System.Windows.Forms.RadioButton();
            this.CakilRBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxKutulamaNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPKutulama = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.CBoxKutuNo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBoxNereye = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kutu Ekstrası:";
            // 
            // YokRBtn
            // 
            this.YokRBtn.AutoSize = true;
            this.YokRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YokRBtn.Location = new System.Drawing.Point(237, 54);
            this.YokRBtn.Name = "YokRBtn";
            this.YokRBtn.Size = new System.Drawing.Size(57, 24);
            this.YokRBtn.TabIndex = 8;
            this.YokRBtn.TabStop = true;
            this.YokRBtn.Text = "Yok";
            this.YokRBtn.UseVisualStyleBackColor = true;
            // 
            // KutuEkleBtn
            // 
            this.KutuEkleBtn.BackColor = System.Drawing.Color.MistyRose;
            this.KutuEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KutuEkleBtn.Location = new System.Drawing.Point(459, 482);
            this.KutuEkleBtn.Name = "KutuEkleBtn";
            this.KutuEkleBtn.Size = new System.Drawing.Size(121, 62);
            this.KutuEkleBtn.TabIndex = 14;
            this.KutuEkleBtn.Text = "Kutu Ekle";
            this.KutuEkleBtn.UseVisualStyleBackColor = false;
            this.KutuEkleBtn.Click += new System.EventHandler(this.KutuEkleBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Antep Fıstıklı Fildişi Çikolata",
            "Çilekli Bonbon Çikolata",
            "Hindistan Cevizli Çikolata",
            "Kuru Meyveli Çikolata",
            "Limonlu Bonbon Çikolata",
            "Portakal Aromalı Fıstıklı Çikolata",
            "Portakallı Bonbon Çİkolata",
            "Tahin Dolgulu Çikolata",
            "Tarçınlı Yulaf Ezmeli Fildişi Çikolata",
            "Türk Kahveli Çikolata",
            "Üç Fındık Pralin Çikolata"});
            this.listBox1.Location = new System.Drawing.Point(152, 238);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 224);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(459, 238);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(285, 224);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kutu İçeriği:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Çikolata Seçimi:";
            // 
            // CBCikolataSecim
            // 
            this.CBCikolataSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCikolataSecim.FormattingEnabled = true;
            this.CBCikolataSecim.Items.AddRange(new object[] {
            "Bitter",
            "Sütlü",
            "Karışık"});
            this.CBCikolataSecim.Location = new System.Drawing.Point(156, 130);
            this.CBCikolataSecim.Name = "CBCikolataSecim";
            this.CBCikolataSecim.Size = new System.Drawing.Size(121, 24);
            this.CBCikolataSecim.TabIndex = 12;
            // 
            // KonfetiRBtn
            // 
            this.KonfetiRBtn.AutoSize = true;
            this.KonfetiRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KonfetiRBtn.Location = new System.Drawing.Point(139, 14);
            this.KonfetiRBtn.Name = "KonfetiRBtn";
            this.KonfetiRBtn.Size = new System.Drawing.Size(82, 24);
            this.KonfetiRBtn.TabIndex = 5;
            this.KonfetiRBtn.TabStop = true;
            this.KonfetiRBtn.Text = "Konfeti";
            this.KonfetiRBtn.UseVisualStyleBackColor = true;
            // 
            // DrajeRBtn
            // 
            this.DrajeRBtn.AutoSize = true;
            this.DrajeRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DrajeRBtn.Location = new System.Drawing.Point(237, 14);
            this.DrajeRBtn.Name = "DrajeRBtn";
            this.DrajeRBtn.Size = new System.Drawing.Size(71, 24);
            this.DrajeRBtn.TabIndex = 6;
            this.DrajeRBtn.TabStop = true;
            this.DrajeRBtn.Text = "Draje";
            this.DrajeRBtn.UseVisualStyleBackColor = true;
            // 
            // CakilRBtn
            // 
            this.CakilRBtn.AutoSize = true;
            this.CakilRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CakilRBtn.Location = new System.Drawing.Point(120, 54);
            this.CakilRBtn.Name = "CakilRBtn";
            this.CakilRBtn.Size = new System.Drawing.Size(104, 24);
            this.CakilRBtn.TabIndex = 7;
            this.CakilRBtn.TabStop = true;
            this.CakilRBtn.Text = "Çakıl Taşı";
            this.CakilRBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kutulama No:";
            // 
            // TBoxKutulamaNo
            // 
            this.TBoxKutulamaNo.Location = new System.Drawing.Point(158, 45);
            this.TBoxKutulamaNo.Name = "TBoxKutulamaNo";
            this.TBoxKutulamaNo.ReadOnly = true;
            this.TBoxKutulamaNo.Size = new System.Drawing.Size(100, 22);
            this.TBoxKutulamaNo.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(290, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kutulama Tarihi:";
            // 
            // DTPKutulama
            // 
            this.DTPKutulama.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTPKutulama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DTPKutulama.Location = new System.Drawing.Point(446, 40);
            this.DTPKutulama.Name = "DTPKutulama";
            this.DTPKutulama.Size = new System.Drawing.Size(236, 27);
            this.DTPKutulama.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(71, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kutu Id:";
            // 
            // CBoxKutuNo
            // 
            this.CBoxKutuNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxKutuNo.FormattingEnabled = true;
            this.CBoxKutuNo.Location = new System.Drawing.Point(156, 85);
            this.CBoxKutuNo.Name = "CBoxKutuNo";
            this.CBoxKutuNo.Size = new System.Drawing.Size(121, 24);
            this.CBoxKutuNo.TabIndex = 22;
            this.CBoxKutuNo.SelectedIndexChanged += new System.EventHandler(this.CBoxKutuNo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(71, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nereye:";
            // 
            // CBoxNereye
            // 
            this.CBoxNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBoxNereye.FormattingEnabled = true;
            this.CBoxNereye.Items.AddRange(new object[] {
            "Dükkan",
            "Müşteri"});
            this.CBoxNereye.Location = new System.Drawing.Point(155, 175);
            this.CBoxNereye.Name = "CBoxNereye";
            this.CBoxNereye.Size = new System.Drawing.Size(121, 24);
            this.CBoxNereye.TabIndex = 10;
            this.CBoxNereye.SelectedIndexChanged += new System.EventHandler(this.CBoxNereye_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.GridColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.Location = new System.Drawing.Point(772, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(464, 502);
            this.dataGridView1.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 28);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.YokRBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.KonfetiRBtn);
            this.panel1.Controls.Add(this.DrajeRBtn);
            this.panel1.Controls.Add(this.CakilRBtn);
            this.panel1.Location = new System.Drawing.Point(354, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 114);
            this.panel1.TabIndex = 23;
            this.panel1.Visible = false;
            // 
            // Kutular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1248, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CBoxNereye);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CBoxKutuNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DTPKutulama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBoxKutulamaNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBCikolataSecim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.KutuEkleBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kutular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kutular";
            this.Load += new System.EventHandler(this.Kutular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton YokRBtn;
        private System.Windows.Forms.Button KutuEkleBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBCikolataSecim;
        private System.Windows.Forms.RadioButton KonfetiRBtn;
        private System.Windows.Forms.RadioButton DrajeRBtn;
        private System.Windows.Forms.RadioButton CakilRBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxKutulamaNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPKutulama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBoxKutuNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBoxNereye;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}