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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AySonuVeriler));
            this.label1 = new System.Windows.Forms.Label();
            this.UrtmGrBtn = new System.Windows.Forms.Button();
            this.StsGrBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MlytBtn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.TBoxNetSayi = new System.Windows.Forms.TextBox();
            this.WorkshopGorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih veya Aralık Seçiniz:";
            // 
            // UrtmGrBtn
            // 
            this.UrtmGrBtn.BackColor = System.Drawing.Color.MistyRose;
            this.UrtmGrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrtmGrBtn.Location = new System.Drawing.Point(80, 336);
            this.UrtmGrBtn.Name = "UrtmGrBtn";
            this.UrtmGrBtn.Size = new System.Drawing.Size(128, 73);
            this.UrtmGrBtn.TabIndex = 2;
            this.UrtmGrBtn.Text = "Üretimleri Gör";
            this.UrtmGrBtn.UseVisualStyleBackColor = false;
            this.UrtmGrBtn.Click += new System.EventHandler(this.UrtmGrBtn_Click);
            // 
            // StsGrBtn
            // 
            this.StsGrBtn.BackColor = System.Drawing.Color.MistyRose;
            this.StsGrBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StsGrBtn.Location = new System.Drawing.Point(229, 336);
            this.StsGrBtn.Name = "StsGrBtn";
            this.StsGrBtn.Size = new System.Drawing.Size(128, 73);
            this.StsGrBtn.TabIndex = 3;
            this.StsGrBtn.Text = "Satışları Gör";
            this.StsGrBtn.UseVisualStyleBackColor = false;
            this.StsGrBtn.Click += new System.EventHandler(this.StsGrBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(425, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(522, 450);
            this.dataGridView1.TabIndex = 6;
            // 
            // MlytBtn
            // 
            this.MlytBtn.BackColor = System.Drawing.Color.MistyRose;
            this.MlytBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MlytBtn.Location = new System.Drawing.Point(80, 429);
            this.MlytBtn.Name = "MlytBtn";
            this.MlytBtn.Size = new System.Drawing.Size(125, 73);
            this.MlytBtn.TabIndex = 4;
            this.MlytBtn.Text = "Alımları Gör";
            this.MlytBtn.UseVisualStyleBackColor = false;
            this.MlytBtn.Click += new System.EventHandler(this.MlytBtn_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(80, 83);
            this.monthCalendar1.MaxSelectionCount = 31;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.MistyRose;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(422, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Net Sayı:";
            // 
            // TBoxNetSayi
            // 
            this.TBoxNetSayi.Location = new System.Drawing.Point(525, 560);
            this.TBoxNetSayi.Name = "TBoxNetSayi";
            this.TBoxNetSayi.Size = new System.Drawing.Size(143, 22);
            this.TBoxNetSayi.TabIndex = 8;
            // 
            // WorkshopGorBtn
            // 
            this.WorkshopGorBtn.BackColor = System.Drawing.Color.MistyRose;
            this.WorkshopGorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WorkshopGorBtn.Location = new System.Drawing.Point(229, 429);
            this.WorkshopGorBtn.Name = "WorkshopGorBtn";
            this.WorkshopGorBtn.Size = new System.Drawing.Size(128, 73);
            this.WorkshopGorBtn.TabIndex = 5;
            this.WorkshopGorBtn.Text = "Workshopları Gör";
            this.WorkshopGorBtn.UseVisualStyleBackColor = false;
            this.WorkshopGorBtn.Click += new System.EventHandler(this.WorkshopGorBtn_Click);
            // 
            // AySonuVeriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(972, 672);
            this.Controls.Add(this.WorkshopGorBtn);
            this.Controls.Add(this.TBoxNetSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.MlytBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StsGrBtn);
            this.Controls.Add(this.UrtmGrBtn);
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
        private System.Windows.Forms.Button UrtmGrBtn;
        private System.Windows.Forms.Button StsGrBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MlytBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBoxNetSayi;
        private System.Windows.Forms.Button WorkshopGorBtn;
    }
}