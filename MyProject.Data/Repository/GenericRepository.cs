
using DB.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repository
{
   public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public MVCEFCoreContext context;
        public DbSet<T> dbset;
        public GenericRepository(MVCEFCoreContext context)
        {
            this.context = context;
            dbset = context.Set<T>();
        }

        public T GetById(int id)
        {
            return dbset.Find(id);
        }

        public T GetById(string id)
        {
            return dbset.Find(id);
        }
        public IQueryable<T> GetAll()
        {
            return dbset.AsQueryable();
        }
        public IQueryable<T> GetAll(string[] Includes)
        {
            var query = dbset.AsQueryable();
            foreach (var include in Includes)
                query = query.Include(include);
            return query;
        }

        public void Insert(T entity)
        {
            dbset.Add(entity);
        }


        public void Edit(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }


        public void Delete(T entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
        }
        public bool ExecuteSQL(FormattableString query)
        {
            return context.Database.ExecuteSqlInterpolated(query) > 0;
        }
    }
}
