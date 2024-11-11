﻿using HealthHub.Database.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HealthHub.Database.Model
{
    public static class Yetkiler
    {
        public static HealthHubDb dby = new HealthHubDb();
        public static bool YetkiEkleVeyaGuncelle(PERSONELFORMYETKILERI PFY)
        {
            try
            {
                var mevcutYetki = dby.PERSONELFORMYETKILERI.SingleOrDefault(p => p.KULLANICIID == PFY.KULLANICIID && p.FormID == PFY.FormID);

                if (mevcutYetki != null)
                {
                    // Eğer kayıt varsa güncelle
                    mevcutYetki.Yetki = PFY.Yetki;
                }
                else
                {
                    // Kayıt yoksa yeni bir kayıt ekle
                    dby.PERSONELFORMYETKILERI.Add(PFY);
                }

                dby.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}