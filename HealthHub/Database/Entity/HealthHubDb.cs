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
        public virtual DbSet<DOKTOR_SAATLERI> DOKTOR_SAATLERI { get; set; }
        public virtual DbSet<FORMLAR> FORMLAR { get; set; }
        public virtual DbSet<HASTALAR> HASTALAR { get; set; }
        public virtual DbSet<KULLANICILAR> KULLANICILAR { get; set; }
        public virtual DbSet<MUAYENELER> MUAYENELER { get; set; }
        public virtual DbSet<PERSONELFORMYETKILERI> PERSONELFORMYETKILERI { get; set; }
        public virtual DbSet<PERSONELLER> PERSONELLER { get; set; }
        public virtual DbSet<TAHLIL> TAHLIL { get; set; }

        public virtual DbSet<SEKRETERLER> SEKRETERLER { get; set; }
        public virtual DbSet<LABORANTLAR> LABORANTLAR { get; set; }

        public virtual DbSet<TAHLILDEGERLERI> TAHLILDEGERLERI {  get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DOKTOR_SAATLERI>()
          .Property(e => e.SAAT)
          .IsUnicode(false);

            modelBuilder.Entity<TAHLILDEGERLERI>()
        .Property(e => e.Deger)
        .HasPrecision(10, 2);
        }
    }
}
