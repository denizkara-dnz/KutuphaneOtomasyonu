﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class frmAnaForm : Form
    {
        Veritabani v;
        public frmAnaForm()
        {
            InitializeComponent();
            v = new Veritabani();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKisiler_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Dispose();
            }
            frmKisiler Kisi = new frmKisiler();
            Kisi.MdiParent = this;
            //Kisi.Dock = DockStyle.Fill;
            Kisi.Show();
            Kisi.Location = new Point(0, 0);
            //MessageBox.Show(Kisi.Size.Width + " : " + Kisi.Size.Height);
        }

        private void btnKitaplar_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Dispose();
            }
            frmKitaplar Kitap = new frmKitaplar();
            Kitap.MdiParent = this;
            //Kitap.Dock = DockStyle.Fill;
            Kitap.Show();
            Kitap.Location = new Point(0, 0);
            //MessageBox.Show(Kitap.Size.Width + " : " + Kitap.Size.Height);
        }

        private void btnEmanetler_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Dispose();
            }
            frmEmanetler Emanet = new frmEmanetler();
            Emanet.MdiParent = this;
            //Emanet.Dock = DockStyle.Fill;
            Emanet.Show();
            Emanet.Location = new Point(0, 0);
            //MessageBox.Show(Emanet.Size.Width + " : " + Emanet.Size.Height);
        }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {
            dgEmanet.DataSource = v.EmanetGecenleri();
        }
    }
}