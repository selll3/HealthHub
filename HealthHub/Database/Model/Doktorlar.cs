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
                using (var db = new HealthHubDb())
                {
                    // Doktorlar ve saatleri JOIN kullanarak alıyoruz
                    var doktorlarSaatler = (from d in db.DOKTORLAR
                                            join ds in db.DOKTOR_SAATLERI on d.DOKTORID equals ds.DOKTORID
                                            select new
                                            {
                                                DoktorAdSoyad = d.Ad + " " + d.Soyad,  // Doktor adı soyadı
                                                Saat = ds.SAAT // TimeSpan'ı saat:dakika formatına dönüştürme
     // Saat formatında döndür
                                            }).ToList();

                    // Saatleri gruplayıp, her doktor için saatleri birleştiriyoruz
                    var doktorlarGruplanmisSaatler = doktorlarSaatler
                        .GroupBy(d => d.DoktorAdSoyad)
                        .Select(g => new
                        {
                            DoktorAdSoyad = g.Key,
                            Saatler = string.Join(", ", g.Select(s => s.Saat))  // Saatleri virgülle ayırarak birleştir
                        })
                        .ToList<dynamic>();

                    return doktorlarGruplanmisSaatler;
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda boş bir liste döner
                Console.WriteLine("Hata: " + ex.Message);
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
