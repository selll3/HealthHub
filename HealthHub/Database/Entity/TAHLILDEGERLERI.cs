

namespace HealthHub.Database.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAHLILDEGERLERI")]
    public partial class TAHLILDEGERLERI
    {
        [Key]
        public int TahlilDID { get; set; }

        public int? TahlilID { get; set; }

        [StringLength(100)]
        public string ParametreAdi { get; set; }

        public decimal? Deger { get; set; }

        public virtual TAHLIL TAHLIL { get; set; }

    }
}
