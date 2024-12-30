using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthHub.Database.Entity;

namespace HealthHub.Database.Model
{
    public static class Doktorlar
    {
        public static HealthHubDb dbd = new HealthHubDb();
        
        /// <summary>
        /// Database'den tüm doktorları çağırır
        /// </summary>
        /// <returns></returns>
        /// 
        public static List<dynamic> DoktorlariGetir()
        {


            var doktorlarigetir = dbd.DOKTORLAR
                .Select(d => new
                {

                    d.DOKTORID,
                    d.Ad,
                    d.Soyad,
                    d.Brans,
                   
                    d.PERSONELID
                })
                .ToList<dynamic>();          // Dinamik olarak listeye dönüştür

            return doktorlarigetir;

        }

        public static List<dynamic> GetDoktorlarVeSaatleri()
        {
            try
            {
                // Doktorları ve onların saatlerini dahil ederek çekiyoruz
                return dbd.DOKTORLAR
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
                    .ToList<dynamic>(); // Dynamic türüne çeviriyoruz
            }
            catch (Exception ex)
            {
                // Hata durumunda boş bir liste döner
                return new List<dynamic>();
            }
        }


        public static bool DoktorEkle(DOKTORLAR doktor)
        {
            try
            {

                dbd.DOKTORLAR.Add(doktor);
                dbd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }

        }
        public static bool DoktorGuncelle(DOKTORLAR doktor)
        {
            try
            {

                dbd.DOKTORLAR.AddOrUpdate(doktor);
                dbd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }

        }
     




        public static bool DoktorlariSil(int selectedrowId)
        {
            try
            {

                var doktor = dbd.DOKTORLAR.Where(x => x.DOKTORID == selectedrowId).FirstOrDefault();
                dbd.DOKTORLAR.Remove(doktor);
                dbd.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }
    }
}
