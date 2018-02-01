using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Model.Entities
{
    [Table("Zone")]
    public class Zone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdZona { get; set; }

        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual Users Users { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
    }
}
