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
    public partial class frmKitaplar : Form
    {
        int ID = 0;
        Veritabani v;
        public frmKitaplar()
        {
            InitializeComponent();
            v = new Veritabani();
        }

        void Yenile()
        {
            dgKitaplar.DataSource = v.TumKitaplar();
        }
        void GuncelleTemizle()
        {
            gbKitapGuncelle.Enabled = false;
            ID = 0;
            txtGuncelleKitapAdi.Clear();
            txtGuncelleKitapYazari.Clear();
            rtbGuncelleKitapAciklama.Clear();
            txtGuncelleKitapAdet.Clear();
        }
        void EkleTemizle()
        {
            txtKaydetKitapAdi.Clear();
            txtKaydetKitapYazari.Clear();
            rtbKaydetKitapAciklama.Clear();
            txtKaydetKitapAdet.Clear();
        }

        private void dgKitaplar_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gbKitapGuncelle.Enabled = true;
            ID = int.Parse(dgKitaplar.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtGuncelleKitapAdi.Text = dgKitaplar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtGuncelleKitapYazari.Text = dgKitaplar.Rows[e.RowIndex].Cells[3].Value.ToString();
            rtbGuncelleKitapAciklama.Text = dgKitaplar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtGuncelleKitapAdet.Text = dgKitaplar.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void frmKitaplar_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {
            if (txtKaydetKitapAdet.Text != "" && txtKaydetKitapAdi.Text != "" && txtKaydetKitapYazari.Text != "" && rtbKaydetKitapAciklama.Text != "")
            {
                bool durum = v.KitapEkle(txtKaydetKitapAdi.Text, txtKaydetKitapYazari.Text, rtbKaydetKitapAciklama.Text, int.Parse(txtKaydetKitapAdet.Text));
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

        private void btnKitapGuncelle_Click(object sender, EventArgs e)
        {
            if (txtGuncelleKitapAdet.Text != "" && txtGuncelleKitapAdi.Text != "" && txtGuncelleKitapYazari.Text != "" && rtbGuncelleKitapAciklama.Text != "")
            {
                bool durum = v.KitapGuncelle(ID, txtGuncelleKitapAdi.Text, txtGuncelleKitapYazari.Text, rtbGuncelleKitapAciklama.Text, int.Parse(txtGuncelleKitapAdet.Text));
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

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Silmek İstediğinize Eminmisiniz ?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dg == System.Windows.Forms.DialogResult.Yes)
            {
                bool durum = v.KitapSil(ID);
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