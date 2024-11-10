using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthHub.Database.Entity;

namespace HealthHub.Database.Model
{
    public static class Hastalar
    {
        public static HealthHubDb dbh = new HealthHubDb();
        public static List<dynamic> HastalariGetir()
        {


            var hastalar = dbh.HASTALAR
                .Select(h => new
                {
                    h.HASTAID,               // Hasta ID
                    h.Ad,              // Hasta Adı
                    h.Soyad,           // Hasta Soyadı
                    h.Tc,
                    h.Parola// Doğum Tarihi (Eğer varsa)
                })
                .ToList<dynamic>();          // Dinamik olarak listeye dönüştür

            return hastalar;

        }


        public static bool HastaEkle(HASTALAR Hasta)
        {
            try
            {

                dbh.HASTALAR.Add(Hasta);
                dbh.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }

        }
        public static bool HastaGuncelle(HASTALAR Hasta)
        {
            try
            {

                dbh.HASTALAR.AddOrUpdate(Hasta);
                dbh.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }

        public static bool HastalariSil(int selectedHastaId)
        {
            try
            {

                var Hasta = dbh.HASTALAR.Where(x => x.HASTAID == selectedHastaId).FirstOrDefault();
                dbh.HASTALAR.Remove(Hasta);
                dbh.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }
    }
}
