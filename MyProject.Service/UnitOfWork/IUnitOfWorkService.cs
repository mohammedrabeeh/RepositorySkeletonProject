using DataLayer.Repository;

namespace ServiceLayer.UnitOfWork
{
    public interface IUnitOfWorkService
    {
        //T GetRepository<T>() where T : class;
        IGenericRepository<T> GetRepository<T>() where T : class;
        //IEmployeeRepo EmployeeRepo { get; }

        int Commit();
    }
}
