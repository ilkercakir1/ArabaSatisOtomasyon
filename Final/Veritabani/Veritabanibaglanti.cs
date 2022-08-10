using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Veritabani
{
    public static class Veritabanibaglanti
    {

        static MySqlConnection baglanti = new MySqlConnection(
             new MySqlConnectionStringBuilder()
             {
                 Server = "localhost:3306",
                 Database = "gorselfinalodev",
                 UserID = "root",
                 Password = "",
             }.ConnectionString
             );
        public static int MusteriEkle(Musteri musteri)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand cmd = new MySqlCommand("MusteriEkle", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", musteri.ID);
                cmd.Parameters.AddWithValue("@Adi", musteri.Adi);
                cmd.Parameters.AddWithValue("@Soyadi", musteri.Soyadi);
                cmd.Parameters.AddWithValue("@Telefon", musteri.Telefon);
                cmd.Parameters.AddWithValue("@Mail", musteri.Mail);
                cmd.Parameters.AddWithValue("@Adres", musteri.Adres);

                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;

            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }





        }

        internal static int MusteriSil(string id)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("MusteriSil", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;
            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();

            }
        }

        internal static DataSet SatisDetay()
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("SatisDetay",baglanti);
                cmd.CommandType =System.Data.CommandType.StoredProcedure;
                       
                
                 DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds);

                return ds;

            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }

        }

        internal static int SatisGuncelle(Satis satis)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("SatisGuncelle", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", satis.ID);
                cmd.Parameters.AddWithValue("@Musteri_ID", satis.MusteriID);
                cmd.Parameters.AddWithValue("@Araba_ID", satis.ArabaID);
                cmd.Parameters.AddWithValue("@tarih", satis.Tarih);
                cmd.Parameters.AddWithValue("@fiyat", satis.Fiyat);            

                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;
            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();

            }
        }

        internal static int SatisEkle(Satis satis)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand cmd = new MySqlCommand("SatisEkle", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@satisid", satis.ID);
                cmd.Parameters.AddWithValue("@musteriad", satis.MusteriID);
                cmd.Parameters.AddWithValue("@arabaid", satis.ArabaID);
                cmd.Parameters.AddWithValue("@tarih", satis.Tarih);
                cmd.Parameters.AddWithValue("@mail", satis.Fiyat);
                

                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;

            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }


        }

        internal static int ArabaSil(string ıD)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("Araba Sil", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ıD);
                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;
            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();

            }
        }

        internal static DataSet OdemeDetay()
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("Galeri_OdemeDetay", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds);

                return ds;

            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        internal static int OdemeSil(string ıD)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("galeri_OdemeSil", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ıD);
            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();

            }
        }

        internal static int OdemeGuncelle(Odeme odeme)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand cmd = new MySqlCommand("OdemeGuncelle", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@satisid", odeme.ID);
                cmd.Parameters.AddWithValue("@musteriad", odeme.MusteriID);
                cmd.Parameters.AddWithValue("@tarih", odeme.Tarih);
                cmd.Parameters.AddWithValue("@fiyat", odeme.Fiyat);
                cmd.Parameters.AddWithValue("@tur", odeme.OdemeTuru);
                cmd.Parameters.AddWithValue("@aciklama", odeme.Aciklama);


                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;

            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        internal static int OdemeEkle(Odeme odeme)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand cmd = new MySqlCommand("OdemeEkle", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@satisid", odeme.ID);
                cmd.Parameters.AddWithValue("@musteriad", odeme.MusteriID);
                cmd.Parameters.AddWithValue("@tarih", odeme.Tarih);
                cmd.Parameters.AddWithValue("@fiyat", odeme.Fiyat);
                cmd.Parameters.AddWithValue("@tur", odeme.OdemeTuru);
                cmd.Parameters.AddWithValue("@aciklama", odeme.Aciklama);


                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;

            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        internal static int ArabaEkle(Arabalar arabalar)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand cmd = new MySqlCommand("ArabaEkle", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", arabalar.ID);
                cmd.Parameters.AddWithValue("@marka", arabalar.Marka);
                cmd.Parameters.AddWithValue("@model", arabalar.Model);
                cmd.Parameters.AddWithValue("@fiyat", arabalar.Fiyat);
                cmd.Parameters.AddWithValue("@yil", arabalar.Yil);
                cmd.Parameters.AddWithValue("@sehir", arabalar.Sehir);
                cmd.Parameters.AddWithValue("@aciklama", arabalar.Aciklama);

                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;

            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        internal static int SatisSil(string ıD)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("SatisSil", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ıD);
                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;
            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();

            }
        }

        internal static int ArabaGuncelle(Arabalar arabalar)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("ArabaGuncelle", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", arabalar.ID);
                cmd.Parameters.AddWithValue("@Marka", arabalar.Marka);
                cmd.Parameters.AddWithValue("@Model", arabalar.Model);
                cmd.Parameters.AddWithValue("@Fiyat", arabalar.Fiyat);
                cmd.Parameters.AddWithValue("@Yil", arabalar.Yil);
                cmd.Parameters.AddWithValue("@Sehir", arabalar.Sehir);
                cmd.Parameters.AddWithValue("@aciklama", arabalar.Aciklama);

                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;
            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();

            }

        }

        internal static int MusteriGuncelle(Musteri musteri)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("MusteriGuncelle", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", musteri.ID);
                cmd.Parameters.AddWithValue("@ad", musteri.Adi);
                cmd.Parameters.AddWithValue("@soyadi", musteri.Soyadi);
                cmd.Parameters.AddWithValue("@telefon", musteri.Telefon);
                cmd.Parameters.AddWithValue("@mail", musteri.Mail);
                cmd.Parameters.AddWithValue("@adres", musteri.Adres);

                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;
            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();

            }



        }

        public static DataSet MusteriGetir(string filtre)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd;
                if (string.IsNullOrEmpty(filtre))
                {
                    cmd = new MySqlCommand("ButunMusterileriGetir", baglanti);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    cmd = new MySqlCommand("ArananMusteriyiGetir", baglanti);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds);

                return ds;

            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }


        }
        internal static DataSet ArabaGetir(string v)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd;
                if (string.IsNullOrEmpty(v))
                {
                    cmd = new MySqlCommand("ButunArabalar", baglanti);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    cmd = new MySqlCommand("ArabaBul", baglanti);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@v", v);
                }
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds);

                return ds;

            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }


        }
    }
}


    

