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
    public partial class frmEmanetler : Form
    {
        int ID = 0;
        Veritabani v;
        public frmEmanetler()
        {
            InitializeComponent();
            v = new Veritabani();
        }

        void Yenile()
        {
            dgEmanetler.DataSource = v.TumEmanetler();
        }
        void textBoxlaraBilgiCek()
        {
            foreach (string item in v.KisiAd_Soyad())
            {
                txtGuncelleKisiAd_Soyad.AutoCompleteCustomSource.Add(item);
                txtKaydetKisiAd_Soyad.AutoCompleteCustomSource.Add(item);
            }
            foreach (string item in v.KitapAdlari())
            {
                txtGuncelleKitapAdi.AutoCompleteCustomSource.Add(item);
                txtKaydetKitapAdi.AutoCompleteCustomSource.Add(item);
            }
        }
        void EkleTemizle()
        {
            txtKaydetKisiAd_Soyad.Clear();
            txtKaydetKitapAdi.Clear();
            dtpKaydetiadeTarihi.Value = DateTime.Now;
        }
        void GuncelleTemizle()
        {
            gbEmanetGuncelle.Enabled = false;
            txtGuncelleKisiAd_Soyad.Clear();
            txtGuncelleKitapAdi.Clear();
            dtpGuncelleiadeTarihi.Value = DateTime.Now;
        }

        private void frmEmanetler_Load(object sender, EventArgs e)
        {
            Yenile();
            textBoxlaraBilgiCek();
        }

        private void dgEmanetler_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gbEmanetGuncelle.Enabled = true;
            ID = int.Parse(dgEmanetler.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtGuncelleKitapAdi.Text = dgEmanetler.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtGuncelleKisiAd_Soyad.Text = dgEmanetler.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpGuncelleiadeTarihi.Value = DateTime.Parse(dgEmanetler.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private void btnEmanetKaydet_Click(object sender, EventArgs e)
        {
            if (txtKaydetKisiAd_Soyad.Text != "" && txtKaydetKitapAdi.Text != "")
            {
                bool durum = v.EmanetEkle(txtKaydetKisiAd_Soyad.Text, txtKaydetKitapAdi.Text, DateTime.Now.ToShortDateString(), dtpKaydetiadeTarihi.Value.ToShortDateString());
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

        private void btnEmanetGuncelle_Click(object sender, EventArgs e)
        {
            if (txtGuncelleKisiAd_Soyad.Text != "" && txtGuncelleKitapAdi.Text != "")
            {
                bool durum = v.EmanetGuncelle(ID, txtGuncelleKitapAdi.Text, txtGuncelleKisiAd_Soyad.Text, dtpGuncelleiadeTarihi.Value.ToShortDateString());
                if (durum)
                {
                    GuncelleTemizle();
                    Yenile();
                    MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir !", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İşleminizde Hata Oluştu !", "Bilgilendirme");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boşlukları Doğru Doldurunuz !", "Bilgilendirme");
            }
        }

        private void btnEmanetSil_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Silmek İstediğinize Eminmisiniz ?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dg == System.Windows.Forms.DialogResult.Yes)
            {
                bool durum = v.EmanetSil(ID);
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