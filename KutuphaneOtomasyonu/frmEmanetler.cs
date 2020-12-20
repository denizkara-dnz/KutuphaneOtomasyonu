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
                txtKaydetKisiAd_Soyad.AutoCompleteCustomSource.Add(item);
            }
            foreach (string item in v.KitapAdlari())
            {
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
            if (txtKaydetKisiAd_Soyad.Text != "")
            {

            }
            else
            {
                MessageBox.Show("Lütfen Boşlukları Doğru Doldurunuz !","Bilgilendirme");
            }
        }
    }
}