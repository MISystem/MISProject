using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Model.Entities
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOrder { get; set; }

        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual Users Users { get; set; }

        public int IdSchool { get; set; }
        [ForeignKey("IdSchool")]
        public virtual Schools Schools { get; set; }

        [StringLength(255)]
        public string Student { get; set; }

        public DateTime Date { get; set; }
    }
}
