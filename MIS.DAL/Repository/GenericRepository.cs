using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS.DAL.Repository
{
    public class GenericRepository<T> where T : class
    {
        protected DatabaseContext Context;
        protected IDbSet<T> Set;

        public GenericRepository()
        {
            Context = new DatabaseContext();
            Set = Context.Set<T>();
        }

        public virtual IQueryable<T> All()
        {
            return Set.AsNoTracking();
        }

        public virtual async Task<T> Find(params object[] p)
        {
            return await Set.FirstAsync();
        }
    }
}
