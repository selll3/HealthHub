namespace HealthHub.Database.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PERSONELLER")]
    public partial class PERSONELLER
    {
        [Key]
        public int PERSONELID { get; set; }

        [StringLength(50)]
        public string Ad { get; set; }

        [StringLength(50)]
        public string Soyad { get; set; }

        [StringLength(50)]
        public string PersonelGörevi { get; set; }

        public int? KULLANICIID { get; set; }

        public virtual KULLANICILAR KULLANICILAR { get; set; }
    }
}
