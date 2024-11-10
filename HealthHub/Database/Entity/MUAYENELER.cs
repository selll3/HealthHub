namespace HealthHub.Database.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MUAYENELER")]
    public partial class MUAYENELER
    {
        [Key]
        public int MUAYENEID { get; set; }

        public DateTime? TarihSaat { get; set; }

        public int? DOKTORID { get; set; }

        public int? HASTAID { get; set; }

        public virtual DOKTORLAR DOKTORLAR { get; set; }

        public virtual HASTALAR HASTALAR { get; set; }
    }
}
