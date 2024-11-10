using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthHub.Database.Entity;

namespace HealthHub.Database.Model
{
     public static class Personeller
    {
        public static HealthHubDb dp = new HealthHubDb();
        public static string PersonelMiDoktorMu(int selectedPersonelId)
        {

            // DbContext sınıfınızı kullanıyoruz

            // Sadece personelin görevini almak için LINQ sorgusuyla doğrudan sorguluyoruz
            var gorev = dp.PERSONELLER
                              .Where(p => p.PERSONELID == selectedPersonelId)
                              .Select(p => p.PersonelGörevi)
                              .FirstOrDefault();

            return gorev; // Görevi döndürüyoruz, personel bulunmazsa null döner



        }

        public static List<dynamic> PersoneliGetir()
        {


            var personeligetir = dp.PERSONELLER
                .Select(p => new
                {
                    p.PERSONELID,               // Hasta ID
                    p.Ad,              // Hasta Adı
                    p.Soyad,           // Hasta Soyadı
                    p.PersonelGörevi

                    // Doğum Tarihi (Eğer varsa)
                })
                .ToList<dynamic>();          // Dinamik olarak listeye dönüştür

            return personeligetir;

        }
        public static bool PersonelEkle(PERSONELLER Personel)
        {
            try
            {

                dp.PERSONELLER.Add(Personel);
                dp.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
        public static bool PersonelGuncelle(PERSONELLER Personel)
        {
            try
            {

                dp.Entry(Personel).State = EntityState.Modified; // Güncelleme durumunu belirt
                dp.SaveChanges(); // Değişiklikleri kaydet
                return true; // Güncelleme başarılı

            }
            //try
            //{

            //    dp.PERSONEL.AddOrUpdate(Personel);
            //    dp.SaveChanges();
            //    return true;
            //}
            catch
            {
                return false;

            }

        }
        public static bool PersonelSil(int selectedPersonelId)
        {
            try
            {

                var personel = dp.PERSONELLER.Where(x => x.PERSONELID == selectedPersonelId).FirstOrDefault();
                dp.PERSONELLER.Remove(personel);
                dp.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false; // Hata durum

            }
        }
    }
}
