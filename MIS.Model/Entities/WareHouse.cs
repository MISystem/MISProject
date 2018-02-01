using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Model.Entities
{
    [Table("WareHouse")]
    public class WareHouse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdWareHouse { get; set; }

        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual Users Users { get; set; }

        public int IdMaterial { get; set; }
        [ForeignKey("IdMaterial")]
        public virtual Material Material { get; set; }

        public int Qty { get; set; }
    }
}
