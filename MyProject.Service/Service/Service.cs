using DataLayer.Repository;
using ServiceLayer.UnitOfWork;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLayer.Service
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IUnitOfWorkService _uow;
        public Service(IUnitOfWorkService uow)
        {
            _uow = uow;
        }
        public bool CreateEntity(T entity)
        {
           IGenericRepository<T> repository= (IGenericRepository<T>)_uow.GetRepository<T>();
           repository.Insert(entity);
           _uow.Commit();
           return true;
        }

        public bool DeleteEntity(T entity)
        {
            IGenericRepository<T> repository = (IGenericRepository<T>)_uow.GetRepository<T>();
            repository.Delete(entity);
            _uow.Commit();
            return true;
        }

        public T GetById(int id)
        {
            IGenericRepository<T> repository = (IGenericRepository<T>)_uow.GetRepository<T>();
            var entity = repository.GetById(id);
            return entity;
        }

        public T GetById(string id)
        {
            IGenericRepository<T> repository = (IGenericRepository<T>)_uow.GetRepository<T>();
            var entity = repository.GetById(id);
            return entity;
        }

        public IQueryable<T> ListAll()
        {
            IGenericRepository<T> repository = (IGenericRepository<T>)_uow.GetRepository<T>();
            IQueryable<T> allEntities = repository.GetAll();
            return allEntities;
        }


        public virtual IQueryable<T> ListAll(string[] Includes)
        {
            IGenericRepository<T> repository = (IGenericRepository<T>)_uow.GetRepository<T>();
            IQueryable<T> allEntities = repository.GetAll(Includes);
            return allEntities;
        }
        public bool UpdateEntity(T entity)
        {
            IGenericRepository<T> repository = (IGenericRepository<T>)_uow.GetRepository<T>();
            repository.Edit(entity);
            _uow.Commit();
            return true;
        }
    }

}
