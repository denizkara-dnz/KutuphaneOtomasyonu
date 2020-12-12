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
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnEmanetler = new System.Windows.Forms.Button();
            this.btnKitaplar = new System.Windows.Forms.Button();
            this.btnKisiler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.Controls.Add(this.btnCikis);
            this.pnlUst.Controls.Add(this.btnEmanetler);
            this.pnlUst.Controls.Add(this.btnKitaplar);
            this.pnlUst.Controls.Add(this.btnKisiler);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(895, 75);
            this.pnlUst.TabIndex = 0;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(643, 12);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(100, 50);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnEmanetler
            // 
            this.btnEmanetler.Location = new System.Drawing.Point(479, 12);
            this.btnEmanetler.Name = "btnEmanetler";
            this.btnEmanetler.Size = new System.Drawing.Size(100, 50);
            this.btnEmanetler.TabIndex = 2;
            this.btnEmanetler.Text = "Emanetler";
            this.btnEmanetler.UseVisualStyleBackColor = true;
            // 
            // btnKitaplar
            // 
            this.btnKitaplar.Location = new System.Drawing.Point(315, 12);
            this.btnKitaplar.Name = "btnKitaplar";
            this.btnKitaplar.Size = new System.Drawing.Size(100, 50);
            this.btnKitaplar.TabIndex = 1;
            this.btnKitaplar.Text = "Kitaplar";
            this.btnKitaplar.UseVisualStyleBackColor = true;
            // 
            // btnKisiler
            // 
            this.btnKisiler.Location = new System.Drawing.Point(151, 12);
            this.btnKisiler.Name = "btnKisiler";
            this.btnKisiler.Size = new System.Drawing.Size(100, 50);
            this.btnKisiler.TabIndex = 0;
            this.btnKisiler.Text = "Kişiler";
            this.btnKisiler.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 443);
            this.panel1.TabIndex = 1;
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlUst);
            this.MaximizeBox = false;
            this.Name = "frmAnaForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KutuphaneOtomasyonu";
            this.pnlUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnEmanetler;
        private System.Windows.Forms.Button btnKitaplar;
        private System.Windows.Forms.Button btnKisiler;
        private System.Windows.Forms.Panel panel1;
    }
}

