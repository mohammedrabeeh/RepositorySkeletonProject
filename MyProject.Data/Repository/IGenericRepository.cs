using System;
using System.Linq;

namespace DataLayer.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        T GetById(string id);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(string[] Includes);
        void Edit(T entity);
        void Insert(T entity);
        void Delete(T entity);
        bool ExecuteSQL(FormattableString query);
    }
}
