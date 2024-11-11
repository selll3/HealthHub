namespace HealthHub.Database.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOKTORLAR")]
    public partial class DOKTORLAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOKTORLAR()
        {
            MUAYENELER = new HashSet<MUAYENELER>();
        }

        [Key]
        public int DOKTORID { get; set; }

        [StringLength(50)]
        public string Ad { get; set; }

        [StringLength(50)]
        public string Soyad { get; set; }

        [StringLength(50)]
        public string Brans { get; set; }

        public int? PERSONELID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUAYENELER> MUAYENELER { get; set; }

        public virtual PERSONELLER PERSONELLER { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public DOKTORLAR()
        //{
        //    MUAYENELER = new HashSet<MUAYENELER>();
        //}

        //[Key]
        //public int DOKTORID { get; set; }

        //[StringLength(50)]
        //public string Ad { get; set; }

        //[StringLength(50)]
        //public string Soyad { get; set; }

        //[StringLength(50)]
        //public string Brans { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<MUAYENELER> MUAYENELER { get; set; }
    }
}
