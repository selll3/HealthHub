using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthHub.Database.Entity
{
    public partial class DOKTOR_SAATLERI
    {
        public int ID { get; set; }

        public int DOKTORID { get; set; }

        [Column(TypeName = "date")]
        public DateTime TARIH { get; set; }

        [Required]
        [StringLength(5)]
        public string SAAT { get; set; }

        public bool? AKTIF { get; set; }

        public virtual DOKTORLAR DOKTORLAR { get; set; }
    }
}
