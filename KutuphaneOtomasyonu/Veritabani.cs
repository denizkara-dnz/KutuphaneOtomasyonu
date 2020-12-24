using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu
{
    class Veritabani
    {
        SqlConnection con;
        public Veritabani()
        {
            con = new SqlConnection("Data Source=VAIO-SONY\\SQLEXPRESS;Initial Catalog=KutuphaneDB;Integrated Security=True");
        }

        #region Kitaplar
        public bool KitapEkle(string KitapAdi, string YazarAdi, string Aciklama, int Adet)
        {
            bool durum = false;
            SqlCommand cmd = new SqlCommand("INSERT INTO Kitaplar(KitapAdi,KitapAciklamasi,KitapYazari,KitapAdet) VALUES(@KitapAdi,@KitapAciklama,@KitapYazari,@KitapAdet)", con);
            cmd.Parameters.AddWithValue("@KitapAdi", KitapAdi);
            cmd.Parameters.AddWithValue("@KitapAciklama", Aciklama);
            cmd.Parameters.AddWithValue("@KitapYazari", YazarAdi);
            cmd.Parameters.AddWithValue("@KitapAdet", Adet);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {
            }
            con.Close();
            return durum;
        }
        public bool KitapGuncelle(int ID, string KitapAdi, string YazarAdi, string Aciklama, int Adet)
        {
            bool durum = false;
            SqlCommand cmd = new SqlCommand("UPDATE Kitaplar SET KitapAdi = @KitapAdi,KitapAciklamasi = @KitapAciklama,KitapYazari = @KitapYazari,KitapAdet=@KitapAdet WHERE Kitaplar.KitapID = @ID", con);
            cmd.Parameters.AddWithValue("@KitapAdi", KitapAdi);
            cmd.Parameters.AddWithValue("@KitapAciklama", Aciklama);
            cmd.Parameters.AddWithValue("@KitapYazari", YazarAdi);
            cmd.Parameters.AddWithValue("@KitapAdet", Adet);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {
            }
            con.Close();
            return durum;
        }
        public bool KitapSil(int ID)
        {
            bool durum = false;
            SqlCommand cmd = new SqlCommand(@"DELETE FROM Kitaplar WHERE Kitaplar.KitapID = @ID
DELETE FROM Kisi_Kitap WHERE KitapID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {
            }
            con.Close();
            return durum;
        }
        #endregion
        /*--------------*/
        #region Kisiler
        public bool KisiEkle(string Ad_Soyad, string TelNo, string TcNo, string Adres)
        {
            bool durum = false;
            SqlCommand cmd = new SqlCommand("INSERT INTO Kisiler(KisiAd_Soyad,KisiTel_No,KisiTcNo,KisiAdres) VALUES(@Ad,@Tel,@TC,@Adres)", con);
            cmd.Parameters.AddWithValue("@Ad", Ad_Soyad);
            cmd.Parameters.AddWithValue("@Tel", TelNo);
            cmd.Parameters.AddWithValue("@TC", TcNo);
            cmd.Parameters.AddWithValue("@Adres", Adres);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {
            }
            con.Close();
            return durum;
        }
        public bool KisiGuncelle(int ID, string Ad_Soyad, string TelNo, string TcNo, string Adres)
        {
            bool durum = false;
            SqlCommand cmd = new SqlCommand("UPDATE Kisiler SET KisiAd_Soyad =@Ad,KisiTel_No = @Tel,KisiTcNo = @TC,KisiAdres = @Adres WHERE Kisiler.KisiID = @ID", con);
            cmd.Parameters.AddWithValue("@Ad", Ad_Soyad);
            cmd.Parameters.AddWithValue("@Tel", TelNo);
            cmd.Parameters.AddWithValue("@TC", TcNo);
            cmd.Parameters.AddWithValue("@Adres", Adres);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {
            }
            con.Close();
            return durum;
        }
        public bool KisiSil(int ID)
        {
            bool durum = false;
            SqlCommand cmd = new SqlCommand(@"DELETE FROM Kisiler WHERE Kisiler.KisiID = @ID
DELETE FROM Kisi_Kitap WHERE KisiID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {
            }
            con.Close();
            return durum;
        }
        #endregion
        /*--------------*/
        #region Emanetler
        public bool EmanetEkle(string Ad_Soyad, string KitapAdi, string AldigiTarih, string iadeTarihi)
        {
            bool durum = false;
            SqlCommand cmd = new SqlCommand(@"DECLARE @KisiID int, @KitapID int, @AldigiTarih varchar(50)=@Aldigi, @iadeTarihi varchar(50)=@Teslim
------------------
SELECT @KitapID = Kitaplar.KitapID FROM Kitaplar WHERE Kitaplar.KitapAdi=@KitapAdi
SELECT @KisiID = Kisiler.KisiID FROM Kisiler WHERE Kisiler.KisiAd_Soyad=@KisiAdi
------------------
INSERT INTO Kisi_Kitap(KisiID,KitapID,AldigiTarih,TeslimTarihi) VALUES(@KisiID,@KitapID,@AldigiTarih,@iadeTarihi)", con);
            cmd.Parameters.AddWithValue("@Aldigi", AldigiTarih);
            cmd.Parameters.AddWithValue("@Teslim", iadeTarihi);
            cmd.Parameters.AddWithValue("@KitapAdi", KitapAdi);
            cmd.Parameters.AddWithValue("@KisiAdi", Ad_Soyad);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {
            }
            con.Close();
            return durum;
        }
        public bool EmanetGuncelle(int ID, string KitapAdi, string KisiAdi, string iadeTarihi)
        {
            bool durum = false;
            SqlCommand cmd = new SqlCommand(@"
DECLARE @TeslimTarihi varchar(50) = @Teslim
DECLARE @KisiAd_Soyad varchar(150) = @KisiAdi, @KitapAdi varchar(100) = @Kitap
UPDATE Kisi_Kitap SET KisiID = (SELECT Kisiler.KisiID FROM Kisiler WHERE Kisiler.KisiAd_Soyad = @KisiAd_Soyad),
KitapID = (SELECT Kitaplar.KitapID FROM Kitaplar WHERE Kitaplar.KitapAdi = @KitapAdi),
TeslimTarihi = @TeslimTarihi
WHERE Kisi_Kitap.ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@KisiAdi", KisiAdi);
            cmd.Parameters.AddWithValue("@Kitap", KitapAdi);
            cmd.Parameters.AddWithValue("@Teslim", iadeTarihi);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {
            }
            con.Close();
            return durum;
        }
        public bool EmanetSil(int ID)
        {
            bool durum = false;
            SqlCommand cmd = new SqlCommand(@"DELETE FROM Kisi_Kitap WHERE Kisi_Kitap.ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                durum = true;
            }
            catch (Exception)
            {
            }
            con.Close();
            return durum;
        }
        #endregion
        /*--------------*/
        #region Listeleme
        public DataTable TumKitaplar()
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kitaplar", con);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                tbl.Load(sr);
            }
            catch (Exception)
            {

                throw;
            }
            con.Close();
            return tbl;
        }
        public DataTable TumKisiler()
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kisiler", con);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                tbl.Load(sr);
            }
            catch (Exception)
            {

                throw;
            }
            con.Close();
            return tbl;
        }
        public DataTable TumEmanetler()
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand(@"CREATE TABLE #table
(
GelenID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
ID int NULL,
KitapAdi varchar(150) NULL,
KisiAd_Soyad varchar(100) NULL,
AldigiTarih varchar(50) NULL,
TeslimTarihi varchar(50) NULL
)
INSERT INTO #table(ID,AldigiTarih,TeslimTarihi) SELECT ID,AldigiTarih,TeslimTarihi FROM Kisi_Kitap
DECLARE @uzunluk int = 0,@sayac int = 1;

SELECT @uzunluk = COUNT(#table.GelenID) FROM #table

DECLARE @ID int = 0
WHILE @uzunluk >= @sayac
BEGIN
SELECT @ID = #table.ID FROM #table WHERE #table.GelenID = @sayac
UPDATE #table SET 
KisiAd_Soyad = (SELECT Kisiler.KisiAd_Soyad FROM Kisiler WHERE Kisiler.KisiID = (SELECT Kisi_Kitap.KisiID FROM Kisi_Kitap WHERE Kisi_Kitap.ID = @ID)),
KitapAdi = (SELECT Kitaplar.KitapAdi FROM Kitaplar WHERE Kitaplar.KitapID = (SELECT Kisi_Kitap.KitapID FROM Kisi_Kitap WHERE Kisi_Kitap.ID = @ID))
WHERE GelenID = @sayac
SET @sayac += 1
END
SELECT * FROM #table", con);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                tbl.Load(sr);
                tbl.Columns.Remove(tbl.Columns[0]);
            }
            catch (Exception)
            {

                throw;
            }
            con.Close();
            return tbl;
        }

        public List<string> KisiAd_Soyad()
        {
            List<string> list = new List<string>();
            SqlCommand cmd = new SqlCommand("SELECT Kisiler.KisiAd_Soyad FROM Kisiler", con);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    list.Add(sr[0].ToString());
                }
            }
            catch (Exception)
            {
            }
            con.Close();
            return list;
        }
        public List<string> KitapAdlari()
        {
            List<string> list = new List<string>();
            SqlCommand cmd = new SqlCommand("SELECT Kitaplar.KitapAdi FROM Kitaplar", con);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    list.Add(sr[0].ToString());
                }
            }
            catch (Exception)
            {
            }
            con.Close();
            return list;
        }
        public DataTable EmanetGecenleri()
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand(@"CREATE TABLE #tablo
(
GelenID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
ID int NULL,
KisiAd_Soyad varchar(150) NULL,
KitapAdi varchar(100) NULL,
TeslimTarihi varchar(50) NULL
)
DECLARE @Tarih varchar(50) = @BugununTarihi
INSERT INTO #tablo(ID,TeslimTarihi) SELECT Kisi_Kitap.ID,Kisi_Kitap.TeslimTarihi FROM Kisi_Kitap
DECLARE @uzunluk int = 0,@sayac int = 1;

SELECT @uzunluk = COUNT(#tablo.GelenID) FROM #tablo
DECLARE @a int = 0, @b int = 0,@ID int
WHILE @uzunluk >= @sayac
BEGIN
SELECT @a = CONVERT(int,SUBSTRING(#tablo.TeslimTarihi,1,2)) FROM #tablo WHERE #tablo.GelenID = @sayac
SET @b = CONVERT(int,SUBSTRING(@Tarih,1,2))
IF @a >= @b
BEGIN
SELECT @ID = #tablo.ID FROM #tablo WHERE #tablo.GelenID = @sayac
UPDATE #tablo SET 
KisiAd_Soyad = (SELECT Kisiler.KisiAd_Soyad FROM Kisiler WHERE Kisiler.KisiID = (SELECT Kisi_Kitap.KisiID FROM Kisi_Kitap WHERE Kisi_Kitap.ID = @ID)),
KitapAdi = (SELECT Kitaplar.KitapAdi FROM Kitaplar WHERE Kitaplar.KitapID = (SELECT Kisi_Kitap.KitapID FROM Kisi_Kitap WHERE Kisi_Kitap.ID = @ID))
END
ELSE
BEGIN
DELETE FROM #tablo WHERE #tablo.GelenID = @sayac
END
SET @sayac += 1
END
SELECT * FROM #tablo", con);
            cmd.Parameters.AddWithValue("@BugununTarihi",DateTime.Now.ToShortDateString());
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                tbl.Load(sr);
                tbl.Columns.Remove(tbl.Columns[0]);
                tbl.Columns.Remove(tbl.Columns[0]);
                tbl.Columns.Remove(tbl.Columns[2]);
            }
            catch (Exception)
            {
            }
            con.Close();
            return tbl;
        }
        #endregion
    }
}