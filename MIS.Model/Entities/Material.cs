using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MIS.Model.Entities
{
    [Table("Material")]
    public class Material
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMaterial { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}
