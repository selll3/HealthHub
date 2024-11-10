namespace HealthHub.Database.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HASTALAR")]
    public partial class HASTALAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HASTALAR()
        {
            MUAYENELER = new HashSet<MUAYENELER>();
            TAHLIL = new HashSet<TAHLIL>();
        }

        [Key]
        public int HASTAID { get; set; }

        [StringLength(11)]
        public string Tc { get; set; }

        [StringLength(50)]
        public string Parola { get; set; }

        [StringLength(50)]
        public string Ad { get; set; }

        [StringLength(50)]
        public string Soyad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUAYENELER> MUAYENELER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAHLIL> TAHLIL { get; set; }
    }
}
