using System;
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
    public partial class frmKisiler : Form
    {
        int ID = 0;
        Veritabani v;
        public frmKisiler()
        {
            InitializeComponent();
            v = new Veritabani();
        }

        void Yenile()
        {
            dgKisiler.DataSource = v.TumKisiler();
        }
        void GuncelleTemizle()
        {
            gbKisiGuncelle.Enabled = false;
            ID = 0;
            txtGuncelleKisiAd_Soyad.Clear();
            txtGuncelleKisiTelNo.Clear();
            txtGuncelleKisiTcNo.Clear();
            rtbGuncelleKisiAdres.Clear();
        }
        void EkleTemizle()
        {
            txtKaydetKisiAd_Soyad.Clear();
            txtKaydetKisiTelNo.Clear();
            txtKaydetKisiTcNo.Clear();
            rtbKaydetKisiAdres.Clear();
        }

        private void dgKisiler_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gbKisiGuncelle.Enabled = true;
            ID = int.Parse(dgKisiler.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtGuncelleKisiAd_Soyad.Text = dgKisiler.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtGuncelleKisiTelNo.Text = dgKisiler.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtGuncelleKisiTcNo.Text = dgKisiler.Rows[e.RowIndex].Cells[3].Value.ToString();
            rtbGuncelleKisiAdres.Text = dgKisiler.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void frmKisiler_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btnKisiKaydet_Click(object sender, EventArgs e)
        {
            if (txtKaydetKisiAd_Soyad.Text != "" && txtKaydetKisiTelNo.Text != "" && txtKaydetKisiTcNo.Text != "" && rtbKaydetKisiAdres.Text != "")
            {
                bool durum = v.KisiEkle(txtKaydetKisiAd_Soyad.Text, txtKaydetKisiTelNo.Text, txtKaydetKisiTcNo.Text, rtbKaydetKisiAdres.Text);
                if (durum)
                {
                    EkleTemizle();
                    Yenile();
                    MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İşelminizde Hata Oluştu !", "Bilgilendirme");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boşlukları Doğru Doldurunuz !", "Bilgilendirme");
            }
        }

        private void btnKisiGuncelle_Click(object sender, EventArgs e)
        {
            if (txtGuncelleKisiAd_Soyad.Text != "" && txtGuncelleKisiTelNo.Text != "" && txtGuncelleKisiTcNo.Text != "" && rtbGuncelleKisiAdres.Text != "")
            {
                bool durum = v.KisiGuncelle(ID, txtGuncelleKisiAd_Soyad.Text, txtGuncelleKisiTelNo.Text, txtGuncelleKisiTcNo.Text, rtbGuncelleKisiAdres.Text);
                if (durum)
                {
                    GuncelleTemizle();
                    Yenile();
                    MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İşelminizde Hata Oluştu !", "Bilgilendirme");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boşlukları Doğru Doldurunuz !", "Bilgilendirme");
            }
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Silmek İstediğinize Eminmisiniz ?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dg == System.Windows.Forms.DialogResult.Yes)
            {
                bool durum = v.KisiSil(ID);
                if (durum)
                {
                    Yenile();
                    GuncelleTemizle();
                    MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("İşleminizde Hata Oluştu !", "Bilgilendirme");
            }
        }
    }
}