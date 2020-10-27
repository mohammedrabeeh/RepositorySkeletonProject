using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer.Service
{
    public interface IService<T> where T : class
    {
        bool CreateEntity(T entity);
        bool UpdateEntity(T entity);
        bool DeleteEntity(T entity);
        IQueryable<T> ListAll();
        
        IQueryable<T> ListAll(string[] Includes);
        T GetById(int id);
        T GetById(string id);
    }

}
