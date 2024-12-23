using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthHub.Database.Entity
{
    [Table("LABORANTLAR")]
    public partial class LABORANTLAR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LABORANTID { get; set; }

        public int? PERSONELID { get; set; }

        [StringLength(100)]
        public string LaboratuvarUzmanligi { get; set; }

        public virtual PERSONELLER PERSONELLER { get; set; }
    }
}
