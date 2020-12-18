namespace KutuphaneOtomasyonu
{
    partial class frmKitaplar
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
            this.dgKitaplar = new System.Windows.Forms.DataGridView();
            this.KitapID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKitapYazari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKitapAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKitapAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbKitapGuncelle = new System.Windows.Forms.GroupBox();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.txtGuncelleKitapAciklama = new System.Windows.Forms.RichTextBox();
            this.txtGuncelleKitapAdet = new System.Windows.Forms.TextBox();
            this.txtGuncelleKitapYazar = new System.Windows.Forms.TextBox();
            this.txtGuncelleKitapAdi = new System.Windows.Forms.TextBox();
            this.lblGuncelleKitapAciklama = new System.Windows.Forms.Label();
            this.lblGuncelleKitapAdet = new System.Windows.Forms.Label();
            this.lblGuncelleKitapYazar = new System.Windows.Forms.Label();
            this.lblGuncelleKitapAdi = new System.Windows.Forms.Label();
            this.gbKitapKaydet = new System.Windows.Forms.GroupBox();
            this.btnKitapKaydet = new System.Windows.Forms.Button();
            this.txtKaydetKitapAciklama = new System.Windows.Forms.RichTextBox();
            this.txtKaydetKitapAdet = new System.Windows.Forms.TextBox();
            this.txtKaydetKitapYazari = new System.Windows.Forms.TextBox();
            this.txtKaydetKitapAdi = new System.Windows.Forms.TextBox();
            this.lblKaydetKitapAciklamasi = new System.Windows.Forms.Label();
            this.lblKaydetKitapAdet = new System.Windows.Forms.Label();
            this.lblKaydetKitapYazar = new System.Windows.Forms.Label();
            this.lblKaydetKitapAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgKitaplar)).BeginInit();
            this.gbKitapGuncelle.SuspendLayout();
            this.gbKitapKaydet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgKitaplar
            // 
            this.dgKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKitaplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KitapID,
            this.clmKitapAdi,
            this.clmKitapYazari,
            this.clmKitapAciklama,
            this.clmKitapAdet});
            this.dgKitaplar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgKitaplar.Location = new System.Drawing.Point(0, 277);
            this.dgKitaplar.Name = "dgKitaplar";
            this.dgKitaplar.Size = new System.Drawing.Size(707, 233);
            this.dgKitaplar.TabIndex = 0;
            // 
            // KitapID
            // 
            this.KitapID.DataPropertyName = "KitapID";
            this.KitapID.HeaderText = "KitapID";
            this.KitapID.Name = "KitapID";
            this.KitapID.Visible = false;
            // 
            // clmKitapAdi
            // 
            this.clmKitapAdi.DataPropertyName = "KitapAdi";
            this.clmKitapAdi.HeaderText = "Kitap Adı";
            this.clmKitapAdi.Name = "clmKitapAdi";
            // 
            // clmKitapYazari
            // 
            this.clmKitapYazari.DataPropertyName = "KitapYazari";
            this.clmKitapYazari.HeaderText = "Kitap Yazarı";
            this.clmKitapYazari.Name = "clmKitapYazari";
            // 
            // clmKitapAciklama
            // 
            this.clmKitapAciklama.DataPropertyName = "KitapAciklama";
            this.clmKitapAciklama.HeaderText = "Kitap Açıklaması";
            this.clmKitapAciklama.Name = "clmKitapAciklama";
            // 
            // clmKitapAdet
            // 
            this.clmKitapAdet.DataPropertyName = "KitapAdet";
            this.clmKitapAdet.HeaderText = "Kitap Adet";
            this.clmKitapAdet.Name = "clmKitapAdet";
            // 
            // gbKitapGuncelle
            // 
            this.gbKitapGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbKitapGuncelle.Controls.Add(this.btnKitapGuncelle);
            this.gbKitapGuncelle.Controls.Add(this.txtGuncelleKitapAciklama);
            this.gbKitapGuncelle.Controls.Add(this.txtGuncelleKitapAdet);
            this.gbKitapGuncelle.Controls.Add(this.txtGuncelleKitapYazar);
            this.gbKitapGuncelle.Controls.Add(this.txtGuncelleKitapAdi);
            this.gbKitapGuncelle.Controls.Add(this.lblGuncelleKitapAciklama);
            this.gbKitapGuncelle.Controls.Add(this.lblGuncelleKitapAdet);
            this.gbKitapGuncelle.Controls.Add(this.lblGuncelleKitapYazar);
            this.gbKitapGuncelle.Controls.Add(this.lblGuncelleKitapAdi);
            this.gbKitapGuncelle.Location = new System.Drawing.Point(370, 12);
            this.gbKitapGuncelle.Name = "gbKitapGuncelle";
            this.gbKitapGuncelle.Size = new System.Drawing.Size(325, 259);
            this.gbKitapGuncelle.TabIndex = 1;
            this.gbKitapGuncelle.TabStop = false;
            this.gbKitapGuncelle.Text = "Güncelle";
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.Location = new System.Drawing.Point(112, 221);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.Size = new System.Drawing.Size(91, 32);
            this.btnKitapGuncelle.TabIndex = 17;
            this.btnKitapGuncelle.Text = "Güncelle";
            this.btnKitapGuncelle.UseVisualStyleBackColor = true;
            // 
            // txtGuncelleKitapAciklama
            // 
            this.txtGuncelleKitapAciklama.Location = new System.Drawing.Point(104, 132);
            this.txtGuncelleKitapAciklama.Name = "txtGuncelleKitapAciklama";
            this.txtGuncelleKitapAciklama.Size = new System.Drawing.Size(210, 79);
            this.txtGuncelleKitapAciklama.TabIndex = 16;
            this.txtGuncelleKitapAciklama.Text = "";
            // 
            // txtGuncelleKitapAdet
            // 
            this.txtGuncelleKitapAdet.Location = new System.Drawing.Point(104, 97);
            this.txtGuncelleKitapAdet.Name = "txtGuncelleKitapAdet";
            this.txtGuncelleKitapAdet.Size = new System.Drawing.Size(210, 20);
            this.txtGuncelleKitapAdet.TabIndex = 15;
            // 
            // txtGuncelleKitapYazar
            // 
            this.txtGuncelleKitapYazar.Location = new System.Drawing.Point(104, 62);
            this.txtGuncelleKitapYazar.Name = "txtGuncelleKitapYazar";
            this.txtGuncelleKitapYazar.Size = new System.Drawing.Size(210, 20);
            this.txtGuncelleKitapYazar.TabIndex = 14;
            // 
            // txtGuncelleKitapAdi
            // 
            this.txtGuncelleKitapAdi.Location = new System.Drawing.Point(104, 27);
            this.txtGuncelleKitapAdi.Name = "txtGuncelleKitapAdi";
            this.txtGuncelleKitapAdi.Size = new System.Drawing.Size(210, 20);
            this.txtGuncelleKitapAdi.TabIndex = 13;
            // 
            // lblGuncelleKitapAciklama
            // 
            this.lblGuncelleKitapAciklama.AutoSize = true;
            this.lblGuncelleKitapAciklama.Location = new System.Drawing.Point(10, 135);
            this.lblGuncelleKitapAciklama.Name = "lblGuncelleKitapAciklama";
            this.lblGuncelleKitapAciklama.Size = new System.Drawing.Size(84, 13);
            this.lblGuncelleKitapAciklama.TabIndex = 12;
            this.lblGuncelleKitapAciklama.Text = "Kitap Açıklaması";
            // 
            // lblGuncelleKitapAdet
            // 
            this.lblGuncelleKitapAdet.AutoSize = true;
            this.lblGuncelleKitapAdet.Location = new System.Drawing.Point(10, 100);
            this.lblGuncelleKitapAdet.Name = "lblGuncelleKitapAdet";
            this.lblGuncelleKitapAdet.Size = new System.Drawing.Size(56, 13);
            this.lblGuncelleKitapAdet.TabIndex = 11;
            this.lblGuncelleKitapAdet.Text = "Kitap Adet";
            // 
            // lblGuncelleKitapYazar
            // 
            this.lblGuncelleKitapYazar.AutoSize = true;
            this.lblGuncelleKitapYazar.Location = new System.Drawing.Point(10, 65);
            this.lblGuncelleKitapYazar.Name = "lblGuncelleKitapYazar";
            this.lblGuncelleKitapYazar.Size = new System.Drawing.Size(63, 13);
            this.lblGuncelleKitapYazar.TabIndex = 10;
            this.lblGuncelleKitapYazar.Text = "Kitap Yazarı";
            // 
            // lblGuncelleKitapAdi
            // 
            this.lblGuncelleKitapAdi.AutoSize = true;
            this.lblGuncelleKitapAdi.Location = new System.Drawing.Point(10, 30);
            this.lblGuncelleKitapAdi.Name = "lblGuncelleKitapAdi";
            this.lblGuncelleKitapAdi.Size = new System.Drawing.Size(49, 13);
            this.lblGuncelleKitapAdi.TabIndex = 9;
            this.lblGuncelleKitapAdi.Text = "Kitap Adı";
            // 
            // gbKitapKaydet
            // 
            this.gbKitapKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbKitapKaydet.Controls.Add(this.btnKitapKaydet);
            this.gbKitapKaydet.Controls.Add(this.txtKaydetKitapAciklama);
            this.gbKitapKaydet.Controls.Add(this.txtKaydetKitapAdet);
            this.gbKitapKaydet.Controls.Add(this.txtKaydetKitapYazari);
            this.gbKitapKaydet.Controls.Add(this.txtKaydetKitapAdi);
            this.gbKitapKaydet.Controls.Add(this.lblKaydetKitapAciklamasi);
            this.gbKitapKaydet.Controls.Add(this.lblKaydetKitapAdet);
            this.gbKitapKaydet.Controls.Add(this.lblKaydetKitapYazar);
            this.gbKitapKaydet.Controls.Add(this.lblKaydetKitapAdi);
            this.gbKitapKaydet.Location = new System.Drawing.Point(12, 12);
            this.gbKitapKaydet.Name = "gbKitapKaydet";
            this.gbKitapKaydet.Size = new System.Drawing.Size(325, 259);
            this.gbKitapKaydet.TabIndex = 2;
            this.gbKitapKaydet.TabStop = false;
            this.gbKitapKaydet.Text = "Kaydet";
            // 
            // btnKitapKaydet
            // 
            this.btnKitapKaydet.Location = new System.Drawing.Point(112, 221);
            this.btnKitapKaydet.Name = "btnKitapKaydet";
            this.btnKitapKaydet.Size = new System.Drawing.Size(91, 32);
            this.btnKitapKaydet.TabIndex = 8;
            this.btnKitapKaydet.Text = "Kaydet";
            this.btnKitapKaydet.UseVisualStyleBackColor = true;
            // 
            // txtKaydetKitapAciklama
            // 
            this.txtKaydetKitapAciklama.Location = new System.Drawing.Point(104, 132);
            this.txtKaydetKitapAciklama.Name = "txtKaydetKitapAciklama";
            this.txtKaydetKitapAciklama.Size = new System.Drawing.Size(210, 79);
            this.txtKaydetKitapAciklama.TabIndex = 7;
            this.txtKaydetKitapAciklama.Text = "";
            // 
            // txtKaydetKitapAdet
            // 
            this.txtKaydetKitapAdet.Location = new System.Drawing.Point(104, 97);
            this.txtKaydetKitapAdet.Name = "txtKaydetKitapAdet";
            this.txtKaydetKitapAdet.Size = new System.Drawing.Size(210, 20);
            this.txtKaydetKitapAdet.TabIndex = 6;
            // 
            // txtKaydetKitapYazari
            // 
            this.txtKaydetKitapYazari.Location = new System.Drawing.Point(104, 62);
            this.txtKaydetKitapYazari.Name = "txtKaydetKitapYazari";
            this.txtKaydetKitapYazari.Size = new System.Drawing.Size(210, 20);
            this.txtKaydetKitapYazari.TabIndex = 5;
            // 
            // txtKaydetKitapAdi
            // 
            this.txtKaydetKitapAdi.Location = new System.Drawing.Point(104, 27);
            this.txtKaydetKitapAdi.Name = "txtKaydetKitapAdi";
            this.txtKaydetKitapAdi.Size = new System.Drawing.Size(210, 20);
            this.txtKaydetKitapAdi.TabIndex = 4;
            // 
            // lblKaydetKitapAciklamasi
            // 
            this.lblKaydetKitapAciklamasi.AutoSize = true;
            this.lblKaydetKitapAciklamasi.Location = new System.Drawing.Point(10, 135);
            this.lblKaydetKitapAciklamasi.Name = "lblKaydetKitapAciklamasi";
            this.lblKaydetKitapAciklamasi.Size = new System.Drawing.Size(84, 13);
            this.lblKaydetKitapAciklamasi.TabIndex = 3;
            this.lblKaydetKitapAciklamasi.Text = "Kitap Açıklaması";
            // 
            // lblKaydetKitapAdet
            // 
            this.lblKaydetKitapAdet.AutoSize = true;
            this.lblKaydetKitapAdet.Location = new System.Drawing.Point(10, 100);
            this.lblKaydetKitapAdet.Name = "lblKaydetKitapAdet";
            this.lblKaydetKitapAdet.Size = new System.Drawing.Size(56, 13);
            this.lblKaydetKitapAdet.TabIndex = 2;
            this.lblKaydetKitapAdet.Text = "Kitap Adet";
            // 
            // lblKaydetKitapYazar
            // 
            this.lblKaydetKitapYazar.AutoSize = true;
            this.lblKaydetKitapYazar.Location = new System.Drawing.Point(10, 65);
            this.lblKaydetKitapYazar.Name = "lblKaydetKitapYazar";
            this.lblKaydetKitapYazar.Size = new System.Drawing.Size(63, 13);
            this.lblKaydetKitapYazar.TabIndex = 1;
            this.lblKaydetKitapYazar.Text = "Kitap Yazarı";
            // 
            // lblKaydetKitapAdi
            // 
            this.lblKaydetKitapAdi.AutoSize = true;
            this.lblKaydetKitapAdi.Location = new System.Drawing.Point(10, 30);
            this.lblKaydetKitapAdi.Name = "lblKaydetKitapAdi";
            this.lblKaydetKitapAdi.Size = new System.Drawing.Size(49, 13);
            this.lblKaydetKitapAdi.TabIndex = 0;
            this.lblKaydetKitapAdi.Text = "Kitap Adı";
            // 
            // frmKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 510);
            this.Controls.Add(this.gbKitapKaydet);
            this.Controls.Add(this.gbKitapGuncelle);
            this.Controls.Add(this.dgKitaplar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKitaplar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.dgKitaplar)).EndInit();
            this.gbKitapGuncelle.ResumeLayout(false);
            this.gbKitapGuncelle.PerformLayout();
            this.gbKitapKaydet.ResumeLayout(false);
            this.gbKitapKaydet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgKitaplar;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKitapYazari;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKitapAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKitapAdet;
        private System.Windows.Forms.GroupBox gbKitapGuncelle;
        private System.Windows.Forms.Button btnKitapGuncelle;
        private System.Windows.Forms.RichTextBox txtGuncelleKitapAciklama;
        private System.Windows.Forms.TextBox txtGuncelleKitapAdet;
        private System.Windows.Forms.TextBox txtGuncelleKitapYazar;
        private System.Windows.Forms.TextBox txtGuncelleKitapAdi;
        private System.Windows.Forms.Label lblGuncelleKitapAciklama;
        private System.Windows.Forms.Label lblGuncelleKitapAdet;
        private System.Windows.Forms.Label lblGuncelleKitapYazar;
        private System.Windows.Forms.Label lblGuncelleKitapAdi;
        private System.Windows.Forms.GroupBox gbKitapKaydet;
        private System.Windows.Forms.Button btnKitapKaydet;
        private System.Windows.Forms.RichTextBox txtKaydetKitapAciklama;
        private System.Windows.Forms.TextBox txtKaydetKitapAdet;
        private System.Windows.Forms.TextBox txtKaydetKitapYazari;
        private System.Windows.Forms.TextBox txtKaydetKitapAdi;
        private System.Windows.Forms.Label lblKaydetKitapAciklamasi;
        private System.Windows.Forms.Label lblKaydetKitapAdet;
        private System.Windows.Forms.Label lblKaydetKitapYazar;
        private System.Windows.Forms.Label lblKaydetKitapAdi;
    }
}