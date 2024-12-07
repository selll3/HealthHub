using HealthHub.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using HealthHub.Database.Model;
using System.Data.Entity.Migrations;

namespace HealthHub.Database.Model
{
    public static class Tahliller
    {
        public static HealthHubDb dbt = new HealthHubDb();

        // Tahlilleri getir
        public static List<dynamic> TahlilleriGetir(int hastaID)
        {
            try
            {
                var tahliller = dbt.TAHLIL
                    .Where(t => t.HASTAID == hastaID) // Seçilen hastaya ait tahlilleri filtrele
                    .Select(t => new
                    {
                        t.TahlilID,          // Tahlil ID
                        t.TahlilIsmi,        // Tahlil Türü
                        Degerler = dbt.TAHLILDEGERLERI
                            .Where(td => td.TahlilDID == t.TahlilID)
                            .Select(td => new
                            {
                                td.ParametreAdi, // Test Parametresi
                                td.Deger     // Test Değeri
                                     // Test Birimi
                            }).ToList()
                    })
                    .ToList<dynamic>(); // Dinamik listeye dönüştür

                return tahliller;
            }
            catch (Exception ex)
            {
                return null; // Hata durumunda null döndür
            }
        }

        // Tahlil ekle
        public static bool TahlilEkle(TAHLIL tahlil, List<TAHLILDEGERLERI> tahlilDegerleri)
        {
            try
            {
                dbt.TAHLIL.Add(tahlil); // Tahlil kaydını ekle
                dbt.SaveChanges();

                // Tahlil değerlerini ekle
                foreach (var deger in tahlilDegerleri)
                {
                    deger.TahlilID = tahlil.TahlilID; // Yeni eklenen tahlilin ID'sini ata
                    dbt.TAHLILDEGERLERI.Add(deger);
                }

                dbt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Tahlil güncelle
        public static bool TahlilGuncelle(TAHLIL tahlil, List<TAHLILDEGERLERI> tahlilDegerleri)
        {
            try
            {
                dbt.TAHLIL.AddOrUpdate(tahlil); // Tahlil kaydını güncelle veya ekle

                // Mevcut tahlil değerlerini sil
                var mevcutDegerler = dbt.TAHLILDEGERLERI
                    .Where(td => td.TahlilID == tahlil.TahlilID)
                    .ToList();
                dbt.TAHLILDEGERLERI.RemoveRange(mevcutDegerler);

                // Yeni tahlil değerlerini ekle
                foreach (var deger in tahlilDegerleri)
                {
                    deger.TahlilID = tahlil.TahlilID;
                    dbt.TAHLILDEGERLERI.Add(deger);
                }

                dbt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Tahlil sil
        public static bool TahlilSil(int tahlilID)
        {
            try
            {
                // Tahlil ve tahlil değerlerini getir
                var tahlil = dbt.TAHLIL.FirstOrDefault(t => t.TahlilID == tahlilID);
                var tahlilDegerleri = dbt.TAHLILDEGERLERI
                    .Where(td => td.TahlilID == tahlilID)
                    .ToList();

                // Verileri sil
                dbt.TAHLILDEGERLERI.RemoveRange(tahlilDegerleri);
                dbt.TAHLIL.Remove(tahlil);

                dbt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
