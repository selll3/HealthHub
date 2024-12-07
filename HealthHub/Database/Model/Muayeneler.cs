using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public static List<MUAYENELER> GetMuayenelerByDoktorID(int doktorID)
        {
            return dbm.MUAYENELER
                .Where(m => m.DOKTORID == doktorID && m.TarihSaat >= DateTime.Now)
                .ToList();
        }





    }
}
