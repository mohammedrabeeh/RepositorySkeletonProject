using DataLayer.Repository;
using DB.Core.Models;
using System;

namespace ServiceLayer.UnitOfWork
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        //private IEmployeeRepo employeeRepo { get; set; }
       


        public MVCEFCoreContext _dbContext;
        public UnitOfWorkService(MVCEFCoreContext context)
        {
            _dbContext = context;
        }
        //public IEmployeeRepo EmployeeRepo => employeeRepo == null ? new EmployeeRepo(_dbContext) : employeeRepo;

        public IGenericRepository<T> GetRepository<T>() where T : class
        {
            //var result = (T)Activator.CreateInstance(typeof(T), _dbContext);
            var result = (GenericRepository<T>)Activator.CreateInstance(typeof(GenericRepository<T>), _dbContext);
            if (result != null)
            {
                return result;
            }
            return null;
        }

        public int Commit()
        {
            try
            {
                return _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                return 1; ///TODO manage  the exception here
            }
        }
    }
}
