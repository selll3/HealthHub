namespace HealthHub.Database.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KULLANICILAR")]
    public partial class KULLANICILAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KULLANICILAR()
        {
            PERSONELFORMYETKILERI = new HashSet<PERSONELFORMYETKILERI>();
            PERSONELLER = new HashSet<PERSONELLER>();
        }

        [Key]
        public int KULLANICIID { get; set; }

        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [StringLength(50)]
        public string Parola { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONELFORMYETKILERI> PERSONELFORMYETKILERI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONELLER> PERSONELLER { get; set; }
    }
}
