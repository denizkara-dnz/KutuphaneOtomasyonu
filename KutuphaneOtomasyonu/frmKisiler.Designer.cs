namespace KutuphaneOtomasyonu
{
    partial class frmKisiler
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgKisiler = new System.Windows.Forms.DataGridView();
            this.clmKisiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKisiAd_Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKisiTel_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKisiTcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKisiAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbKisiKaydet = new System.Windows.Forms.GroupBox();
            this.btnKisiKaydet = new System.Windows.Forms.Button();
            this.txtKaydetKisiAdres = new System.Windows.Forms.RichTextBox();
            this.txtKaydetKisiTcNo = new System.Windows.Forms.TextBox();
            this.txtKaydetKisiTelNo = new System.Windows.Forms.TextBox();
            this.txtKaydetKisiAd_Soyad = new System.Windows.Forms.TextBox();
            this.lblKaydetKisiAdres = new System.Windows.Forms.Label();
            this.lblKaydetKisiTcNo = new System.Windows.Forms.Label();
            this.lblKaydetKisiTelNo = new System.Windows.Forms.Label();
            this.lblKaydetKisiAd_Soyad = new System.Windows.Forms.Label();
            this.btnKisiSil = new System.Windows.Forms.Button();
            this.btnKisiGuncelle = new System.Windows.Forms.Button();
            this.gbKisiGuncelle = new System.Windows.Forms.GroupBox();
            this.txtGuncelleKisiAdres = new System.Windows.Forms.RichTextBox();
            this.txtGuncelleKisiTcNo = new System.Windows.Forms.TextBox();
            this.txtGuncelleKisiTelNo = new System.Windows.Forms.TextBox();
            this.txtGuncelleKisiAd_Soyad = new System.Windows.Forms.TextBox();
            this.lblGuncelleKitapAciklama = new System.Windows.Forms.Label();
            this.lblGuncelleKisiTcNo = new System.Windows.Forms.Label();
            this.lblGuncelleKisiTelNo = new System.Windows.Forms.Label();
            this.lblGuncelleKisiAd_Soyad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgKisiler)).BeginInit();
            this.gbKisiKaydet.SuspendLayout();
            this.gbKisiGuncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgKisiler
            // 
            this.dgKisiler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgKisiler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgKisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKisiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmKisiID,
            this.clmKisiAd_Soyad,
            this.clmKisiTel_No,
            this.clmKisiTcNo,
            this.clmKisiAdres});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgKisiler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgKisiler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgKisiler.Location = new System.Drawing.Point(0, 277);
            this.dgKisiler.Name = "dgKisiler";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgKisiler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgKisiler.Size = new System.Drawing.Size(707, 233);
            this.dgKisiler.TabIndex = 1;
            // 
            // clmKisiID
            // 
            this.clmKisiID.DataPropertyName = "KisiID";
            this.clmKisiID.HeaderText = "KisiID";
            this.clmKisiID.Name = "clmKisiID";
            this.clmKisiID.Visible = false;
            // 
            // clmKisiAd_Soyad
            // 
            this.clmKisiAd_Soyad.DataPropertyName = "KisiAd_Soyad";
            this.clmKisiAd_Soyad.HeaderText = "Ad Soyad";
            this.clmKisiAd_Soyad.Name = "clmKisiAd_Soyad";
            // 
            // clmKisiTel_No
            // 
            this.clmKisiTel_No.DataPropertyName = "KisiTel_No";
            this.clmKisiTel_No.HeaderText = "Telefon Numarası";
            this.clmKisiTel_No.Name = "clmKisiTel_No";
            // 
            // clmKisiTcNo
            // 
            this.clmKisiTcNo.DataPropertyName = "KisiTcNo";
            this.clmKisiTcNo.HeaderText = "TC Kimlik No";
            this.clmKisiTcNo.Name = "clmKisiTcNo";
            // 
            // clmKisiAdres
            // 
            this.clmKisiAdres.DataPropertyName = "KisiAdres";
            this.clmKisiAdres.HeaderText = "Adres";
            this.clmKisiAdres.Name = "clmKisiAdres";
            // 
            // gbKisiKaydet
            // 
            this.gbKisiKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbKisiKaydet.Controls.Add(this.btnKisiKaydet);
            this.gbKisiKaydet.Controls.Add(this.txtKaydetKisiAdres);
            this.gbKisiKaydet.Controls.Add(this.txtKaydetKisiTcNo);
            this.gbKisiKaydet.Controls.Add(this.txtKaydetKisiTelNo);
            this.gbKisiKaydet.Controls.Add(this.txtKaydetKisiAd_Soyad);
            this.gbKisiKaydet.Controls.Add(this.lblKaydetKisiAdres);
            this.gbKisiKaydet.Controls.Add(this.lblKaydetKisiTcNo);
            this.gbKisiKaydet.Controls.Add(this.lblKaydetKisiTelNo);
            this.gbKisiKaydet.Controls.Add(this.lblKaydetKisiAd_Soyad);
            this.gbKisiKaydet.Location = new System.Drawing.Point(12, 12);
            this.gbKisiKaydet.Name = "gbKisiKaydet";
            this.gbKisiKaydet.Size = new System.Drawing.Size(325, 259);
            this.gbKisiKaydet.TabIndex = 4;
            this.gbKisiKaydet.TabStop = false;
            this.gbKisiKaydet.Text = "Kişi Kaydet";
            // 
            // btnKisiKaydet
            // 
            this.btnKisiKaydet.Location = new System.Drawing.Point(117, 221);
            this.btnKisiKaydet.Name = "btnKisiKaydet";
            this.btnKisiKaydet.Size = new System.Drawing.Size(91, 32);
            this.btnKisiKaydet.TabIndex = 17;
            this.btnKisiKaydet.Text = "Kaydet";
            this.btnKisiKaydet.UseVisualStyleBackColor = true;
            // 
            // txtKaydetKisiAdres
            // 
            this.txtKaydetKisiAdres.Location = new System.Drawing.Point(104, 132);
            this.txtKaydetKisiAdres.Name = "txtKaydetKisiAdres";
            this.txtKaydetKisiAdres.Size = new System.Drawing.Size(210, 79);
            this.txtKaydetKisiAdres.TabIndex = 7;
            this.txtKaydetKisiAdres.Text = "";
            // 
            // txtKaydetKisiTcNo
            // 
            this.txtKaydetKisiTcNo.Location = new System.Drawing.Point(104, 97);
            this.txtKaydetKisiTcNo.Name = "txtKaydetKisiTcNo";
            this.txtKaydetKisiTcNo.Size = new System.Drawing.Size(210, 20);
            this.txtKaydetKisiTcNo.TabIndex = 6;
            // 
            // txtKaydetKisiTelNo
            // 
            this.txtKaydetKisiTelNo.Location = new System.Drawing.Point(104, 62);
            this.txtKaydetKisiTelNo.Name = "txtKaydetKisiTelNo";
            this.txtKaydetKisiTelNo.Size = new System.Drawing.Size(210, 20);
            this.txtKaydetKisiTelNo.TabIndex = 5;
            // 
            // txtKaydetKisiAd_Soyad
            // 
            this.txtKaydetKisiAd_Soyad.Location = new System.Drawing.Point(104, 27);
            this.txtKaydetKisiAd_Soyad.Name = "txtKaydetKisiAd_Soyad";
            this.txtKaydetKisiAd_Soyad.Size = new System.Drawing.Size(210, 20);
            this.txtKaydetKisiAd_Soyad.TabIndex = 4;
            // 
            // lblKaydetKisiAdres
            // 
            this.lblKaydetKisiAdres.AutoSize = true;
            this.lblKaydetKisiAdres.Location = new System.Drawing.Point(10, 135);
            this.lblKaydetKisiAdres.Name = "lblKaydetKisiAdres";
            this.lblKaydetKisiAdres.Size = new System.Drawing.Size(34, 13);
            this.lblKaydetKisiAdres.TabIndex = 3;
            this.lblKaydetKisiAdres.Text = "Adres";
            // 
            // lblKaydetKisiTcNo
            // 
            this.lblKaydetKisiTcNo.AutoSize = true;
            this.lblKaydetKisiTcNo.Location = new System.Drawing.Point(10, 100);
            this.lblKaydetKisiTcNo.Name = "lblKaydetKisiTcNo";
            this.lblKaydetKisiTcNo.Size = new System.Drawing.Size(68, 13);
            this.lblKaydetKisiTcNo.TabIndex = 2;
            this.lblKaydetKisiTcNo.Text = "TC Kimlik No";
            // 
            // lblKaydetKisiTelNo
            // 
            this.lblKaydetKisiTelNo.AutoSize = true;
            this.lblKaydetKisiTelNo.Location = new System.Drawing.Point(10, 65);
            this.lblKaydetKisiTelNo.Name = "lblKaydetKisiTelNo";
            this.lblKaydetKisiTelNo.Size = new System.Drawing.Size(90, 13);
            this.lblKaydetKisiTelNo.TabIndex = 1;
            this.lblKaydetKisiTelNo.Text = "Telefon Numarası";
            // 
            // lblKaydetKisiAd_Soyad
            // 
            this.lblKaydetKisiAd_Soyad.AutoSize = true;
            this.lblKaydetKisiAd_Soyad.Location = new System.Drawing.Point(10, 30);
            this.lblKaydetKisiAd_Soyad.Name = "lblKaydetKisiAd_Soyad";
            this.lblKaydetKisiAd_Soyad.Size = new System.Drawing.Size(53, 13);
            this.lblKaydetKisiAd_Soyad.TabIndex = 0;
            this.lblKaydetKisiAd_Soyad.Text = "Ad Soyad";
            // 
            // btnKisiSil
            // 
            this.btnKisiSil.Location = new System.Drawing.Point(27, 221);
            this.btnKisiSil.Name = "btnKisiSil";
            this.btnKisiSil.Size = new System.Drawing.Size(91, 32);
            this.btnKisiSil.TabIndex = 9;
            this.btnKisiSil.Text = "Sil";
            this.btnKisiSil.UseVisualStyleBackColor = true;
            // 
            // btnKisiGuncelle
            // 
            this.btnKisiGuncelle.Location = new System.Drawing.Point(206, 221);
            this.btnKisiGuncelle.Name = "btnKisiGuncelle";
            this.btnKisiGuncelle.Size = new System.Drawing.Size(91, 32);
            this.btnKisiGuncelle.TabIndex = 8;
            this.btnKisiGuncelle.Text = "Güncelle";
            this.btnKisiGuncelle.UseVisualStyleBackColor = true;
            // 
            // gbKisiGuncelle
            // 
            this.gbKisiGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbKisiGuncelle.Controls.Add(this.txtGuncelleKisiAdres);
            this.gbKisiGuncelle.Controls.Add(this.btnKisiSil);
            this.gbKisiGuncelle.Controls.Add(this.btnKisiGuncelle);
            this.gbKisiGuncelle.Controls.Add(this.txtGuncelleKisiTcNo);
            this.gbKisiGuncelle.Controls.Add(this.txtGuncelleKisiTelNo);
            this.gbKisiGuncelle.Controls.Add(this.txtGuncelleKisiAd_Soyad);
            this.gbKisiGuncelle.Controls.Add(this.lblGuncelleKitapAciklama);
            this.gbKisiGuncelle.Controls.Add(this.lblGuncelleKisiTcNo);
            this.gbKisiGuncelle.Controls.Add(this.lblGuncelleKisiTelNo);
            this.gbKisiGuncelle.Controls.Add(this.lblGuncelleKisiAd_Soyad);
            this.gbKisiGuncelle.Location = new System.Drawing.Point(370, 12);
            this.gbKisiGuncelle.Name = "gbKisiGuncelle";
            this.gbKisiGuncelle.Size = new System.Drawing.Size(325, 259);
            this.gbKisiGuncelle.TabIndex = 3;
            this.gbKisiGuncelle.TabStop = false;
            this.gbKisiGuncelle.Text = "Kişi Güncelle";
            // 
            // txtGuncelleKisiAdres
            // 
            this.txtGuncelleKisiAdres.Location = new System.Drawing.Point(104, 132);
            this.txtGuncelleKisiAdres.Name = "txtGuncelleKisiAdres";
            this.txtGuncelleKisiAdres.Size = new System.Drawing.Size(210, 79);
            this.txtGuncelleKisiAdres.TabIndex = 16;
            this.txtGuncelleKisiAdres.Text = "";
            // 
            // txtGuncelleKisiTcNo
            // 
            this.txtGuncelleKisiTcNo.Location = new System.Drawing.Point(104, 97);
            this.txtGuncelleKisiTcNo.Name = "txtGuncelleKisiTcNo";
            this.txtGuncelleKisiTcNo.Size = new System.Drawing.Size(210, 20);
            this.txtGuncelleKisiTcNo.TabIndex = 15;
            // 
            // txtGuncelleKisiTelNo
            // 
            this.txtGuncelleKisiTelNo.Location = new System.Drawing.Point(104, 62);
            this.txtGuncelleKisiTelNo.Name = "txtGuncelleKisiTelNo";
            this.txtGuncelleKisiTelNo.Size = new System.Drawing.Size(210, 20);
            this.txtGuncelleKisiTelNo.TabIndex = 14;
            // 
            // txtGuncelleKisiAd_Soyad
            // 
            this.txtGuncelleKisiAd_Soyad.Location = new System.Drawing.Point(104, 27);
            this.txtGuncelleKisiAd_Soyad.Name = "txtGuncelleKisiAd_Soyad";
            this.txtGuncelleKisiAd_Soyad.Size = new System.Drawing.Size(210, 20);
            this.txtGuncelleKisiAd_Soyad.TabIndex = 13;
            // 
            // lblGuncelleKitapAciklama
            // 
            this.lblGuncelleKitapAciklama.AutoSize = true;
            this.lblGuncelleKitapAciklama.Location = new System.Drawing.Point(10, 135);
            this.lblGuncelleKitapAciklama.Name = "lblGuncelleKitapAciklama";
            this.lblGuncelleKitapAciklama.Size = new System.Drawing.Size(34, 13);
            this.lblGuncelleKitapAciklama.TabIndex = 12;
            this.lblGuncelleKitapAciklama.Text = "Adres";
            // 
            // lblGuncelleKisiTcNo
            // 
            this.lblGuncelleKisiTcNo.AutoSize = true;
            this.lblGuncelleKisiTcNo.Location = new System.Drawing.Point(10, 100);
            this.lblGuncelleKisiTcNo.Name = "lblGuncelleKisiTcNo";
            this.lblGuncelleKisiTcNo.Size = new System.Drawing.Size(68, 13);
            this.lblGuncelleKisiTcNo.TabIndex = 11;
            this.lblGuncelleKisiTcNo.Text = "TC Kimlik No";
            // 
            // lblGuncelleKisiTelNo
            // 
            this.lblGuncelleKisiTelNo.AutoSize = true;
            this.lblGuncelleKisiTelNo.Location = new System.Drawing.Point(10, 65);
            this.lblGuncelleKisiTelNo.Name = "lblGuncelleKisiTelNo";
            this.lblGuncelleKisiTelNo.Size = new System.Drawing.Size(90, 13);
            this.lblGuncelleKisiTelNo.TabIndex = 10;
            this.lblGuncelleKisiTelNo.Text = "Telefon Numarası";
            // 
            // lblGuncelleKisiAd_Soyad
            // 
            this.lblGuncelleKisiAd_Soyad.AutoSize = true;
            this.lblGuncelleKisiAd_Soyad.Location = new System.Drawing.Point(10, 30);
            this.lblGuncelleKisiAd_Soyad.Name = "lblGuncelleKisiAd_Soyad";
            this.lblGuncelleKisiAd_Soyad.Size = new System.Drawing.Size(53, 13);
            this.lblGuncelleKisiAd_Soyad.TabIndex = 9;
            this.lblGuncelleKisiAd_Soyad.Text = "Ad Soyad";
            // 
            // frmKisiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 510);
            this.Controls.Add(this.gbKisiKaydet);
            this.Controls.Add(this.gbKisiGuncelle);
            this.Controls.Add(this.dgKisiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKisiler";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.dgKisiler)).EndInit();
            this.gbKisiKaydet.ResumeLayout(false);
            this.gbKisiKaydet.PerformLayout();
            this.gbKisiGuncelle.ResumeLayout(false);
            this.gbKisiGuncelle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKisiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKisiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKisiAd_Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKisiTel_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKisiTcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKisiAdres;
        private System.Windows.Forms.GroupBox gbKisiKaydet;
        private System.Windows.Forms.Button btnKisiGuncelle;
        private System.Windows.Forms.GroupBox gbKisiGuncelle;
        private System.Windows.Forms.Button btnKisiKaydet;
        private System.Windows.Forms.RichTextBox txtGuncelleKisiAdres;
        private System.Windows.Forms.TextBox txtGuncelleKisiTcNo;
        private System.Windows.Forms.TextBox txtGuncelleKisiTelNo;
        private System.Windows.Forms.TextBox txtGuncelleKisiAd_Soyad;
        private System.Windows.Forms.Label lblGuncelleKitapAciklama;
        private System.Windows.Forms.Label lblGuncelleKisiTcNo;
        private System.Windows.Forms.Label lblGuncelleKisiTelNo;
        private System.Windows.Forms.Label lblGuncelleKisiAd_Soyad;
        private System.Windows.Forms.RichTextBox txtKaydetKisiAdres;
        private System.Windows.Forms.TextBox txtKaydetKisiTcNo;
        private System.Windows.Forms.TextBox txtKaydetKisiTelNo;
        private System.Windows.Forms.TextBox txtKaydetKisiAd_Soyad;
        private System.Windows.Forms.Label lblKaydetKisiAdres;
        private System.Windows.Forms.Label lblKaydetKisiTcNo;
        private System.Windows.Forms.Label lblKaydetKisiTelNo;
        private System.Windows.Forms.Label lblKaydetKisiAd_Soyad;
        private System.Windows.Forms.Button btnKisiSil;
    }
}