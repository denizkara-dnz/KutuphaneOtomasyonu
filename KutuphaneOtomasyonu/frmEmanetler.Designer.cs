namespace KutuphaneOtomasyonu
{
    partial class frmEmanetler
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
            this.dgEmanetler = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKisiAd_Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAlinanTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTeslimTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEmanetKaydet = new System.Windows.Forms.GroupBox();
            this.dtpKaydetiadeTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnEmanetKaydet = new System.Windows.Forms.Button();
            this.txtKaydetKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKaydetKisiAd_Soyad = new System.Windows.Forms.TextBox();
            this.lblKaydetiadeTarihi = new System.Windows.Forms.Label();
            this.lblKaydetKitapAdi = new System.Windows.Forms.Label();
            this.lblKaydetKisiAd_Soyad = new System.Windows.Forms.Label();
            this.btnEmanetSil = new System.Windows.Forms.Button();
            this.btnEmanetGuncelle = new System.Windows.Forms.Button();
            this.gbEmanetGuncelle = new System.Windows.Forms.GroupBox();
            this.dtpGuncelleiadeTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtGuncelleKitapAdi = new System.Windows.Forms.TextBox();
            this.txtGuncelleKisiAd_Soyad = new System.Windows.Forms.TextBox();
            this.lblGuncelleiadeTarihi = new System.Windows.Forms.Label();
            this.lblGuncelleKitapAdi = new System.Windows.Forms.Label();
            this.lblGuncelleKisiAd_Soyad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmanetler)).BeginInit();
            this.gbEmanetKaydet.SuspendLayout();
            this.gbEmanetGuncelle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgEmanetler
            // 
            this.dgEmanetler.AllowUserToAddRows = false;
            this.dgEmanetler.AllowUserToResizeColumns = false;
            this.dgEmanetler.AllowUserToResizeRows = false;
            this.dgEmanetler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmanetler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEmanetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgEmanetler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.clmKitapAdi,
            this.clmKisiAd_Soyad,
            this.clmAlinanTarih,
            this.clmTeslimTarihi});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEmanetler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgEmanetler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgEmanetler.Location = new System.Drawing.Point(0, 186);
            this.dgEmanetler.MultiSelect = false;
            this.dgEmanetler.Name = "dgEmanetler";
            this.dgEmanetler.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEmanetler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgEmanetler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgEmanetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmanetler.Size = new System.Drawing.Size(707, 324);
            this.dgEmanetler.TabIndex = 2;
            this.dgEmanetler.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgEmanetler_CellMouseDoubleClick);
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Visible = false;
            // 
            // clmKitapAdi
            // 
            this.clmKitapAdi.DataPropertyName = "KitapAdi";
            this.clmKitapAdi.HeaderText = "Kitap Adı";
            this.clmKitapAdi.Name = "clmKitapAdi";
            this.clmKitapAdi.ReadOnly = true;
            // 
            // clmKisiAd_Soyad
            // 
            this.clmKisiAd_Soyad.DataPropertyName = "KisiAd_Soyad";
            this.clmKisiAd_Soyad.HeaderText = "Alanın Adı Soyadı";
            this.clmKisiAd_Soyad.Name = "clmKisiAd_Soyad";
            this.clmKisiAd_Soyad.ReadOnly = true;
            // 
            // clmAlinanTarih
            // 
            this.clmAlinanTarih.DataPropertyName = "AldigiTarih";
            this.clmAlinanTarih.HeaderText = "Alınan Tarih";
            this.clmAlinanTarih.Name = "clmAlinanTarih";
            this.clmAlinanTarih.ReadOnly = true;
            // 
            // clmTeslimTarihi
            // 
            this.clmTeslimTarihi.DataPropertyName = "TeslimTarihi";
            this.clmTeslimTarihi.HeaderText = "Teslim Tarihi";
            this.clmTeslimTarihi.Name = "clmTeslimTarihi";
            this.clmTeslimTarihi.ReadOnly = true;
            // 
            // gbEmanetKaydet
            // 
            this.gbEmanetKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbEmanetKaydet.Controls.Add(this.dtpKaydetiadeTarihi);
            this.gbEmanetKaydet.Controls.Add(this.btnEmanetKaydet);
            this.gbEmanetKaydet.Controls.Add(this.txtKaydetKitapAdi);
            this.gbEmanetKaydet.Controls.Add(this.txtKaydetKisiAd_Soyad);
            this.gbEmanetKaydet.Controls.Add(this.lblKaydetiadeTarihi);
            this.gbEmanetKaydet.Controls.Add(this.lblKaydetKitapAdi);
            this.gbEmanetKaydet.Controls.Add(this.lblKaydetKisiAd_Soyad);
            this.gbEmanetKaydet.Location = new System.Drawing.Point(12, 12);
            this.gbEmanetKaydet.Name = "gbEmanetKaydet";
            this.gbEmanetKaydet.Size = new System.Drawing.Size(325, 168);
            this.gbEmanetKaydet.TabIndex = 6;
            this.gbEmanetKaydet.TabStop = false;
            this.gbEmanetKaydet.Text = "Emanet Kaydet";
            // 
            // dtpKaydetiadeTarihi
            // 
            this.dtpKaydetiadeTarihi.Location = new System.Drawing.Point(104, 97);
            this.dtpKaydetiadeTarihi.Name = "dtpKaydetiadeTarihi";
            this.dtpKaydetiadeTarihi.Size = new System.Drawing.Size(210, 20);
            this.dtpKaydetiadeTarihi.TabIndex = 18;
            // 
            // btnEmanetKaydet
            // 
            this.btnEmanetKaydet.Location = new System.Drawing.Point(117, 130);
            this.btnEmanetKaydet.Name = "btnEmanetKaydet";
            this.btnEmanetKaydet.Size = new System.Drawing.Size(91, 32);
            this.btnEmanetKaydet.TabIndex = 17;
            this.btnEmanetKaydet.Text = "Kaydet";
            this.btnEmanetKaydet.UseVisualStyleBackColor = true;
            this.btnEmanetKaydet.Click += new System.EventHandler(this.btnEmanetKaydet_Click);
            // 
            // txtKaydetKitapAdi
            // 
            this.txtKaydetKitapAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKaydetKitapAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKaydetKitapAdi.Location = new System.Drawing.Point(104, 62);
            this.txtKaydetKitapAdi.Name = "txtKaydetKitapAdi";
            this.txtKaydetKitapAdi.Size = new System.Drawing.Size(210, 20);
            this.txtKaydetKitapAdi.TabIndex = 5;
            // 
            // txtKaydetKisiAd_Soyad
            // 
            this.txtKaydetKisiAd_Soyad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtKaydetKisiAd_Soyad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKaydetKisiAd_Soyad.Location = new System.Drawing.Point(104, 27);
            this.txtKaydetKisiAd_Soyad.Name = "txtKaydetKisiAd_Soyad";
            this.txtKaydetKisiAd_Soyad.Size = new System.Drawing.Size(210, 20);
            this.txtKaydetKisiAd_Soyad.TabIndex = 4;
            // 
            // lblKaydetiadeTarihi
            // 
            this.lblKaydetiadeTarihi.AutoSize = true;
            this.lblKaydetiadeTarihi.Location = new System.Drawing.Point(10, 100);
            this.lblKaydetiadeTarihi.Name = "lblKaydetiadeTarihi";
            this.lblKaydetiadeTarihi.Size = new System.Drawing.Size(57, 13);
            this.lblKaydetiadeTarihi.TabIndex = 2;
            this.lblKaydetiadeTarihi.Text = "İade Tarihi";
            // 
            // lblKaydetKitapAdi
            // 
            this.lblKaydetKitapAdi.AutoSize = true;
            this.lblKaydetKitapAdi.Location = new System.Drawing.Point(10, 65);
            this.lblKaydetKitapAdi.Name = "lblKaydetKitapAdi";
            this.lblKaydetKitapAdi.Size = new System.Drawing.Size(49, 13);
            this.lblKaydetKitapAdi.TabIndex = 1;
            this.lblKaydetKitapAdi.Text = "Kitap Adı";
            // 
            // lblKaydetKisiAd_Soyad
            // 
            this.lblKaydetKisiAd_Soyad.AutoSize = true;
            this.lblKaydetKisiAd_Soyad.Location = new System.Drawing.Point(10, 30);
            this.lblKaydetKisiAd_Soyad.Name = "lblKaydetKisiAd_Soyad";
            this.lblKaydetKisiAd_Soyad.Size = new System.Drawing.Size(76, 13);
            this.lblKaydetKisiAd_Soyad.TabIndex = 0;
            this.lblKaydetKisiAd_Soyad.Text = "Kişi Adı Soyadı";
            // 
            // btnEmanetSil
            // 
            this.btnEmanetSil.Location = new System.Drawing.Point(27, 130);
            this.btnEmanetSil.Name = "btnEmanetSil";
            this.btnEmanetSil.Size = new System.Drawing.Size(91, 32);
            this.btnEmanetSil.TabIndex = 11;
            this.btnEmanetSil.Text = "Sil";
            this.btnEmanetSil.UseVisualStyleBackColor = true;
            this.btnEmanetSil.Click += new System.EventHandler(this.btnEmanetSil_Click);
            // 
            // btnEmanetGuncelle
            // 
            this.btnEmanetGuncelle.Location = new System.Drawing.Point(206, 130);
            this.btnEmanetGuncelle.Name = "btnEmanetGuncelle";
            this.btnEmanetGuncelle.Size = new System.Drawing.Size(91, 32);
            this.btnEmanetGuncelle.TabIndex = 10;
            this.btnEmanetGuncelle.Text = "Güncelle";
            this.btnEmanetGuncelle.UseVisualStyleBackColor = true;
            this.btnEmanetGuncelle.Click += new System.EventHandler(this.btnEmanetGuncelle_Click);
            // 
            // gbEmanetGuncelle
            // 
            this.gbEmanetGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbEmanetGuncelle.Controls.Add(this.dtpGuncelleiadeTarihi);
            this.gbEmanetGuncelle.Controls.Add(this.txtGuncelleKitapAdi);
            this.gbEmanetGuncelle.Controls.Add(this.txtGuncelleKisiAd_Soyad);
            this.gbEmanetGuncelle.Controls.Add(this.lblGuncelleiadeTarihi);
            this.gbEmanetGuncelle.Controls.Add(this.lblGuncelleKitapAdi);
            this.gbEmanetGuncelle.Controls.Add(this.lblGuncelleKisiAd_Soyad);
            this.gbEmanetGuncelle.Controls.Add(this.btnEmanetSil);
            this.gbEmanetGuncelle.Controls.Add(this.btnEmanetGuncelle);
            this.gbEmanetGuncelle.Enabled = false;
            this.gbEmanetGuncelle.Location = new System.Drawing.Point(370, 12);
            this.gbEmanetGuncelle.Name = "gbEmanetGuncelle";
            this.gbEmanetGuncelle.Size = new System.Drawing.Size(325, 168);
            this.gbEmanetGuncelle.TabIndex = 5;
            this.gbEmanetGuncelle.TabStop = false;
            this.gbEmanetGuncelle.Text = "Emanet Güncelle";
            // 
            // dtpGuncelleiadeTarihi
            // 
            this.dtpGuncelleiadeTarihi.Location = new System.Drawing.Point(104, 97);
            this.dtpGuncelleiadeTarihi.Name = "dtpGuncelleiadeTarihi";
            this.dtpGuncelleiadeTarihi.Size = new System.Drawing.Size(210, 20);
            this.dtpGuncelleiadeTarihi.TabIndex = 24;
            this.dtpGuncelleiadeTarihi.Value = new System.DateTime(2020, 12, 23, 1, 27, 13, 0);
            // 
            // txtGuncelleKitapAdi
            // 
            this.txtGuncelleKitapAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGuncelleKitapAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGuncelleKitapAdi.Location = new System.Drawing.Point(104, 62);
            this.txtGuncelleKitapAdi.Name = "txtGuncelleKitapAdi";
            this.txtGuncelleKitapAdi.Size = new System.Drawing.Size(210, 20);
            this.txtGuncelleKitapAdi.TabIndex = 23;
            // 
            // txtGuncelleKisiAd_Soyad
            // 
            this.txtGuncelleKisiAd_Soyad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGuncelleKisiAd_Soyad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGuncelleKisiAd_Soyad.Location = new System.Drawing.Point(104, 27);
            this.txtGuncelleKisiAd_Soyad.Name = "txtGuncelleKisiAd_Soyad";
            this.txtGuncelleKisiAd_Soyad.Size = new System.Drawing.Size(210, 20);
            this.txtGuncelleKisiAd_Soyad.TabIndex = 22;
            // 
            // lblGuncelleiadeTarihi
            // 
            this.lblGuncelleiadeTarihi.AutoSize = true;
            this.lblGuncelleiadeTarihi.Location = new System.Drawing.Point(10, 100);
            this.lblGuncelleiadeTarihi.Name = "lblGuncelleiadeTarihi";
            this.lblGuncelleiadeTarihi.Size = new System.Drawing.Size(57, 13);
            this.lblGuncelleiadeTarihi.TabIndex = 21;
            this.lblGuncelleiadeTarihi.Text = "İade Tarihi";
            // 
            // lblGuncelleKitapAdi
            // 
            this.lblGuncelleKitapAdi.AutoSize = true;
            this.lblGuncelleKitapAdi.Location = new System.Drawing.Point(10, 65);
            this.lblGuncelleKitapAdi.Name = "lblGuncelleKitapAdi";
            this.lblGuncelleKitapAdi.Size = new System.Drawing.Size(49, 13);
            this.lblGuncelleKitapAdi.TabIndex = 20;
            this.lblGuncelleKitapAdi.Text = "Kitap Adı";
            // 
            // lblGuncelleKisiAd_Soyad
            // 
            this.lblGuncelleKisiAd_Soyad.AutoSize = true;
            this.lblGuncelleKisiAd_Soyad.Location = new System.Drawing.Point(10, 30);
            this.lblGuncelleKisiAd_Soyad.Name = "lblGuncelleKisiAd_Soyad";
            this.lblGuncelleKisiAd_Soyad.Size = new System.Drawing.Size(76, 13);
            this.lblGuncelleKisiAd_Soyad.TabIndex = 19;
            this.lblGuncelleKisiAd_Soyad.Text = "Kişi Adı Soyadı";
            // 
            // frmEmanetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 510);
            this.Controls.Add(this.gbEmanetKaydet);
            this.Controls.Add(this.gbEmanetGuncelle);
            this.Controls.Add(this.dgEmanetler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmanetler";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmEmanetler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmanetler)).EndInit();
            this.gbEmanetKaydet.ResumeLayout(false);
            this.gbEmanetKaydet.PerformLayout();
            this.gbEmanetGuncelle.ResumeLayout(false);
            this.gbEmanetGuncelle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmanetler;
        private System.Windows.Forms.GroupBox gbEmanetKaydet;
        private System.Windows.Forms.TextBox txtKaydetKitapAdi;
        private System.Windows.Forms.TextBox txtKaydetKisiAd_Soyad;
        private System.Windows.Forms.Label lblKaydetiadeTarihi;
        private System.Windows.Forms.Label lblKaydetKitapAdi;
        private System.Windows.Forms.Label lblKaydetKisiAd_Soyad;
        private System.Windows.Forms.GroupBox gbEmanetGuncelle;
        private System.Windows.Forms.Button btnEmanetKaydet;
        private System.Windows.Forms.Button btnEmanetSil;
        private System.Windows.Forms.Button btnEmanetGuncelle;
        private System.Windows.Forms.DateTimePicker dtpKaydetiadeTarihi;
        private System.Windows.Forms.DateTimePicker dtpGuncelleiadeTarihi;
        private System.Windows.Forms.TextBox txtGuncelleKitapAdi;
        private System.Windows.Forms.TextBox txtGuncelleKisiAd_Soyad;
        private System.Windows.Forms.Label lblGuncelleiadeTarihi;
        private System.Windows.Forms.Label lblGuncelleKitapAdi;
        private System.Windows.Forms.Label lblGuncelleKisiAd_Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKisiAd_Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAlinanTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTeslimTarihi;
    }
}