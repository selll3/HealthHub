using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthHub.Database.Entity;

namespace HealthHub.Database.Model
{
    public static class Muayeneler
    {
        public static HealthHubDb dbm = new HealthHubDb();
        public static bool MuayeneEkle(MUAYENELER muayene)
        {
            try
            {

                dbm.MUAYENELER.Add(muayene);
                dbm.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }

        }
        public static bool MuayeneGuncelle(MUAYENELER muayene)
        {
            try
            {
                dbm.MUAYENELER.AddOrUpdate(muayene); // Güncelleme ya da ekleme
                dbm.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Loglama yapılabilir
                return false;
            }
        }

        // Muayene sil
        public static bool MuayeneSil(int muayeneID)
        {
            try
            {
                var muayene = dbm.MUAYENELER.FirstOrDefault(m => m.MUAYENEID == muayeneID);
                if (muayene != null)
                {
                    dbm.MUAYENELER.Remove(muayene);
                    dbm.SaveChanges();
                    return true;
                }
                return false; // Muayene bulunamadıysa
            }
            catch (Exception ex)
            {
                // Loglama yapılabilir
                return false;
            }
        }
        public static List<MUAYENELER> GetTumMuayeneler()
        {

            try
            {
                return dbm.MUAYENELER.ToList();
            }
            catch (Exception ex)
            {
                // Loglama yapılabilir
                return new List<MUAYENELER>();
            }
        }
        public static List<object> GetDoktorlarVeSaatleri()
        {
            try
            {
                // Doktorları ve onların saatlerini dahil ederek çekiyoruz
                return dbm.DOKTORLAR
                    .Include("DOKTOR_SAATLERI") // Saat bilgilerini dahil et
                    .Select(d => new
                    {
                        DoktorAdSoyad = d.Ad + " " + d.Soyad, // Doktorun Adı Soyadı
                        Saatler = d.DOKTOR_SAATLERI.Select(s => new
                        {
                            Tarih = s.TARIH,
                            Saat = s.SAAT
                        }).ToList() // Saat listesini oluştur
                    })
                    .ToList<object>(); // Object türüne çeviriyoruz
            }
            catch (Exception ex)
            {
                // Hata durumunda boş bir liste döner
                return new List<object>();
            }
        }


        public static List<MUAYENELER> GetMuayenelerByDoktorID(int doktorID)
        {
            return dbm.MUAYENELER
                .Where(m => m.DOKTORID == doktorID && m.TarihSaat >= DateTime.Now)
                .ToList();
        }



       







    }
}
