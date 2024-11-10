using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthHub.Database.Entity;


namespace HealthHub.Database.Model
{
    public static class Kullanicilar
    {
        public static HealthHubDb dbk = new HealthHubDb();
        public static List<dynamic> KullanicilariGetir()
        {


            var kullanicilarigetir = dbk.KULLANICILAR
                .Select(k => new
                {
                    k.KULLANICIID,
                    k.KullaniciAdi,
                    k.Parola
                })
                .ToList<dynamic>();          // Dinamik olarak listeye dönüştür

            return kullanicilarigetir;

        }
        public static bool KullaniciEkle(KULLANICILAR kullanici)
        {
            try
            {

                dbk.KULLANICILAR.Add(kullanici);
                dbk.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
        public static bool KullaniciGuncelle(KULLANICILAR kullanici)
        {
            try
            {

                dbk.KULLANICILAR.AddOrUpdate(kullanici);
                dbk.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }

        }
        public static bool KullaniciSil(int selectedKullaniciId)
        {
            try
            {
                // DbContext sınıfınızı burada belirtin

                // İşlem için bir transaction başlatıyoruz
                using (var transaction = dbk.Database.BeginTransaction())
                {
                    // İlk olarak PERSONELFORMYETKILERI tablosundan ilgili kullanıcıyı sil
                    var userPermissions = dbk.PERSONELFORMYETKILERI
                        .Where(p => p.KULLANICIID == selectedKullaniciId);
                    dbk.PERSONELFORMYETKILERI.RemoveRange(userPermissions);
                    dbk.SaveChanges(); // Değişiklikleri kaydediyoruz

                    // Ardından GIRIS tablosundan kullanıcıyı sil
                    var user = dbk.KULLANICILAR.Find(selectedKullaniciId);
                    if (user != null)
                    {
                        dbk.KULLANICILAR.Remove(user);
                        dbk.SaveChanges(); // Değişiklikleri kaydediyoruz
                    }

                    // İşlemi başarılı bir şekilde tamamladıysak commit ediyoruz
                    transaction.Commit();
                    return true; // Silme başarılı
                }

            }
            catch (Exception ex)
            {
                return false;

            }

        }
    }
}
