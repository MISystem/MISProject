using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Model.Entities
{
    [Table("Schools")]
    public class Schools
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSchool { get; set; }

        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual Users Users { get; set; }

        public int IdZona { get; set; }
        [ForeignKey("IdZona")]
        public virtual Zone Zone { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}
