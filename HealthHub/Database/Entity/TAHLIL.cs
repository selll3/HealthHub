namespace HealthHub.Database.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAHLIL")]
    public partial class TAHLIL
    {
        public int TahlilID { get; set; }

        [StringLength(50)]
        public string TahlilIsmi { get; set; }

        [StringLength(50)]
        public string TahlilDegeri { get; set; }

        public int? HASTAID { get; set; }

        public virtual HASTALAR HASTALAR { get; set; }
    }
}
