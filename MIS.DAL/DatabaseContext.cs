using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MIS.Model.Entities;

namespace MIS.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            :base("name=DbContext")
        {
            Configuration.AutoDetectChangesEnabled = false;
        }

        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Schools> Schools { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WareHouse> WareHouse { get; set; }
        public virtual DbSet<Zone> Zone { get; set; }
    }
}
