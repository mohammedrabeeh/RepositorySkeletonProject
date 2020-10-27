using DB.Core.Models;
using ServiceLayer.Service;
using ServiceLayer.UnitOfWork;

namespace ServiceLayer
{
    public class EmployeeService : Service<Employee>, IEmployeeService
    {
        private readonly IUnitOfWorkService _uow;
        public EmployeeService(IUnitOfWorkService uow) : base(uow)
        {
             _uow = uow;
        }



        //public List<DB.Core.Models.Employee> GrandpasEmployees()
        //{
        //    IQueryable<DB.Core.Models.Employee> Employees=_uow.EmployeeRepo.GetAll(Where owner is Grandpa !!! );
        //    return Employees.ToList();
        //}

    }
}
