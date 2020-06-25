using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Task.Company.Entities;

namespace Task.Company.Reposatory
{
    public class Generic<T> where T : BaseModel
    { 
        private DbSet<T> dbSet;
        public EntitiesContext Context;

        public Generic(EntitiesContext context)
        {
            Context = context;
            dbSet = Context.Set<T>();
        }

        public T Add(T T)
        {
            return dbSet.Add(T);
        }
        public T Remove(T T)
        {
            return dbSet.Remove(T);
        }

        public T Update(T T)
        {
            if (!dbSet.Local.Any(i => i.ID == T.ID))
                dbSet.Attach(T);
            Context.Entry(T).State = EntityState.Modified;
            return T;
        }

        public T GetByID(int ID)
        {
            return dbSet.Where(i => i.ID == ID).FirstOrDefault();
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> filter)
        {
            return dbSet.Where(filter);
        }

    }
}
