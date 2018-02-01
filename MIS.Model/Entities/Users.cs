using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.Model.Entities
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUser { get; set; }

        public int IdRole { get; set; }
        [ForeignKey("IdRole")]
        public virtual Roles Roles { get; set; }

        [StringLength(255)]
        public string Pwd { get; set; }

        public DateTime Date { get; set; }
    }
}
