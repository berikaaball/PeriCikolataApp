namespace periCikolata
{
    partial class Mallar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mallar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxMalNo = new System.Windows.Forms.TextBox();
            this.TBoxMalAdi = new System.Windows.Forms.TextBox();
            this.BtnMalEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mal No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(76, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mal Adı:";
            // 
            // TBoxMalNo
            // 
            this.TBoxMalNo.Location = new System.Drawing.Point(175, 54);
            this.TBoxMalNo.Name = "TBoxMalNo";
            this.TBoxMalNo.ReadOnly = true;
            this.TBoxMalNo.Size = new System.Drawing.Size(100, 22);
            this.TBoxMalNo.TabIndex = 2;
            // 
            // TBoxMalAdi
            // 
            this.TBoxMalAdi.Location = new System.Drawing.Point(175, 113);
            this.TBoxMalAdi.Name = "TBoxMalAdi";
            this.TBoxMalAdi.Size = new System.Drawing.Size(100, 22);
            this.TBoxMalAdi.TabIndex = 3;
            // 
            // BtnMalEkle
            // 
            this.BtnMalEkle.BackColor = System.Drawing.Color.MistyRose;
            this.BtnMalEkle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnMalEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnMalEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnMalEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMalEkle.ForeColor = System.Drawing.Color.Black;
            this.BtnMalEkle.Location = new System.Drawing.Point(175, 173);
            this.BtnMalEkle.Name = "BtnMalEkle";
            this.BtnMalEkle.Size = new System.Drawing.Size(100, 65);
            this.BtnMalEkle.TabIndex = 4;
            this.BtnMalEkle.Text = "Mal Ekle";
            this.BtnMalEkle.UseVisualStyleBackColor = false;
            this.BtnMalEkle.Click += new System.EventHandler(this.BtnMalEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.GridColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.Location = new System.Drawing.Point(352, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(400, 366);
            this.dataGridView1.TabIndex = 5;
            // 
            // Mallar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnMalEkle);
            this.Controls.Add(this.TBoxMalAdi);
            this.Controls.Add(this.TBoxMalNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mallar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mallar";
            this.Load += new System.EventHandler(this.Mallar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxMalNo;
        private System.Windows.Forms.TextBox TBoxMalAdi;
        private System.Windows.Forms.Button BtnMalEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}