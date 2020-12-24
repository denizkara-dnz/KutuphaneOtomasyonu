namespace KutuphaneOtomasyonu
{
    partial class frmAnaForm
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnEmanetler = new System.Windows.Forms.Button();
            this.btnKitaplar = new System.Windows.Forms.Button();
            this.btnKisiler = new System.Windows.Forms.Button();
            this.pnlSol = new System.Windows.Forms.Panel();
            this.dgEmanet = new System.Windows.Forms.DataGridView();
            this.clmKitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKisiAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmanet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUst.Controls.Add(this.pictureBox1);
            this.pnlUst.Controls.Add(this.btnCikis);
            this.pnlUst.Controls.Add(this.btnEmanetler);
            this.pnlUst.Controls.Add(this.btnKitaplar);
            this.pnlUst.Controls.Add(this.btnKisiler);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(931, 75);
            this.pnlUst.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 75);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(768, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(100, 50);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnEmanetler
            // 
            this.btnEmanetler.Location = new System.Drawing.Point(604, 12);
            this.btnEmanetler.Name = "btnEmanetler";
            this.btnEmanetler.Size = new System.Drawing.Size(100, 50);
            this.btnEmanetler.TabIndex = 2;
            this.btnEmanetler.Text = "Emanetler";
            this.btnEmanetler.UseVisualStyleBackColor = true;
            this.btnEmanetler.Click += new System.EventHandler(this.btnEmanetler_Click);
            // 
            // btnKitaplar
            // 
            this.btnKitaplar.Location = new System.Drawing.Point(440, 12);
            this.btnKitaplar.Name = "btnKitaplar";
            this.btnKitaplar.Size = new System.Drawing.Size(100, 50);
            this.btnKitaplar.TabIndex = 1;
            this.btnKitaplar.Text = "Kitaplar";
            this.btnKitaplar.UseVisualStyleBackColor = true;
            this.btnKitaplar.Click += new System.EventHandler(this.btnKitaplar_Click);
            // 
            // btnKisiler
            // 
            this.btnKisiler.Location = new System.Drawing.Point(276, 12);
            this.btnKisiler.Name = "btnKisiler";
            this.btnKisiler.Size = new System.Drawing.Size(100, 50);
            this.btnKisiler.TabIndex = 0;
            this.btnKisiler.Text = "Kişiler";
            this.btnKisiler.UseVisualStyleBackColor = true;
            this.btnKisiler.Click += new System.EventHandler(this.btnKisiler_Click);
            // 
            // pnlSol
            // 
            this.pnlSol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSol.Controls.Add(this.dgEmanet);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 75);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(220, 514);
            this.pnlSol.TabIndex = 1;
            // 
            // dgEmanet
            // 
            this.dgEmanet.AllowUserToAddRows = false;
            this.dgEmanet.AllowUserToResizeColumns = false;
            this.dgEmanet.AllowUserToResizeRows = false;
            this.dgEmanet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgEmanet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmKitapAdi,
            this.clmKisiAdi});
            this.dgEmanet.Location = new System.Drawing.Point(3, 6);
            this.dgEmanet.MultiSelect = false;
            this.dgEmanet.Name = "dgEmanet";
            this.dgEmanet.ReadOnly = true;
            this.dgEmanet.RowHeadersVisible = false;
            this.dgEmanet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgEmanet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmanet.Size = new System.Drawing.Size(214, 150);
            this.dgEmanet.TabIndex = 0;
            // 
            // clmKitapAdi
            // 
            this.clmKitapAdi.DataPropertyName = "KitapAdi";
            this.clmKitapAdi.HeaderText = "Kitap Adı";
            this.clmKitapAdi.Name = "clmKitapAdi";
            this.clmKitapAdi.ReadOnly = true;
            // 
            // clmKisiAdi
            // 
            this.clmKisiAdi.DataPropertyName = "KisiAd_Soyad";
            this.clmKisiAdi.HeaderText = "Ad Soyad";
            this.clmKisiAdi.Name = "clmKisiAdi";
            this.clmKisiAdi.ReadOnly = true;
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 589);
            this.Controls.Add(this.pnlSol);
            this.Controls.Add(this.pnlUst);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmAnaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KutuphaneOtomasyonu";
            this.Load += new System.EventHandler(this.frmAnaForm_Load);
            this.pnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmanet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnEmanetler;
        private System.Windows.Forms.Button btnKitaplar;
        private System.Windows.Forms.Button btnKisiler;
        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgEmanet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKisiAdi;
    }
}

