using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Model.Entities
{
    [Table("OrderItems")]
    public class OrderItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOrderItems { get; set; }

        public int IdOrder { get; set; }
        [ForeignKey("IdOrder")]
        public virtual Orders Orders { get; set; }

        public int IdMaterial { get; set; }
        [ForeignKey("IdMaterial")]
        public virtual Material Material { get; set; }

        public int Qty { get; set; }
    }
}
