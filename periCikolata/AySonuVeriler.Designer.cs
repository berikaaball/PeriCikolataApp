namespace periCikolata
{
    partial class AySonuVeriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AySonuVeriler));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.UrtmGrBtn = new System.Windows.Forms.Button();
            this.StsGrBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MlytBtn = new System.Windows.Forms.Button();
            this.tbtarih = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih Seçiniz:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // UrtmGrBtn
            // 
            this.UrtmGrBtn.BackColor = System.Drawing.Color.MistyRose;
            this.UrtmGrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrtmGrBtn.Location = new System.Drawing.Point(80, 137);
            this.UrtmGrBtn.Name = "UrtmGrBtn";
            this.UrtmGrBtn.Size = new System.Drawing.Size(115, 73);
            this.UrtmGrBtn.TabIndex = 2;
            this.UrtmGrBtn.Text = "Üretimleri Gör";
            this.UrtmGrBtn.UseVisualStyleBackColor = false;
            this.UrtmGrBtn.Click += new System.EventHandler(this.UrtmGrBtn_Click);
            // 
            // StsGrBtn
            // 
            this.StsGrBtn.BackColor = System.Drawing.Color.MistyRose;
            this.StsGrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StsGrBtn.Location = new System.Drawing.Point(219, 137);
            this.StsGrBtn.Name = "StsGrBtn";
            this.StsGrBtn.Size = new System.Drawing.Size(115, 73);
            this.StsGrBtn.TabIndex = 3;
            this.StsGrBtn.Text = "Satışları Gör";
            this.StsGrBtn.UseVisualStyleBackColor = false;
            this.StsGrBtn.Click += new System.EventHandler(this.StsGrBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(391, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(522, 450);
            this.dataGridView1.TabIndex = 4;
            // 
            // MlytBtn
            // 
            this.MlytBtn.BackColor = System.Drawing.Color.MistyRose;
            this.MlytBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MlytBtn.Location = new System.Drawing.Point(80, 232);
            this.MlytBtn.Name = "MlytBtn";
            this.MlytBtn.Size = new System.Drawing.Size(115, 73);
            this.MlytBtn.TabIndex = 5;
            this.MlytBtn.Text = "Alımları Gör";
            this.MlytBtn.UseVisualStyleBackColor = false;
            this.MlytBtn.Click += new System.EventHandler(this.MlytBtn_Click);
            // 
            // tbtarih
            // 
            this.tbtarih.Location = new System.Drawing.Point(80, 366);
            this.tbtarih.Name = "tbtarih";
            this.tbtarih.Size = new System.Drawing.Size(100, 22);
            this.tbtarih.TabIndex = 6;
            // 
            // AySonuVeriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(972, 584);
            this.Controls.Add(this.tbtarih);
            this.Controls.Add(this.MlytBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StsGrBtn);
            this.Controls.Add(this.UrtmGrBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AySonuVeriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AySonuVeriler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button UrtmGrBtn;
        private System.Windows.Forms.Button StsGrBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MlytBtn;
        private System.Windows.Forms.TextBox tbtarih;
    }
}