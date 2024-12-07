using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;


namespace HealthHub.Database.Entity
{
    public partial class HealthHubDb : DbContext
    {
        public HealthHubDb()
            : base("name=HealthHubDb")
        {
        }

        public virtual DbSet<DOKTORLAR> DOKTORLAR { get; set; }
        public virtual DbSet<FORMLAR> FORMLAR { get; set; }
        public virtual DbSet<HASTALAR> HASTALAR { get; set; }
        public virtual DbSet<KULLANICILAR> KULLANICILAR { get; set; }
        public virtual DbSet<MUAYENELER> MUAYENELER { get; set; }
        public virtual DbSet<PERSONELFORMYETKILERI> PERSONELFORMYETKILERI { get; set; }
        public virtual DbSet<PERSONELLER> PERSONELLER { get; set; }
        public virtual DbSet<TAHLIL> TAHLIL { get; set; }

        public virtual DbSet<TAHLILDEGERLERI> TAHLILDEGERLERI {  get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
