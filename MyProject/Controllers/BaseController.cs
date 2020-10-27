using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Service;

namespace MyProject.WebUI.Controllers
{
    public abstract class BaseController : Controller
    {
        IHttpContextAccessor httpContextAccessor;
        IEmployeeService employeeService;
        private const string SessionKeyUserName = "Authenticated_Employee_UserName";
        private const string SessionKeyName = "Authenticated_Employee_Name";
        private const string SessionKeyEmail = "Authenticated_Employee_Email";

        public BaseController(IHttpContextAccessor _httpContextAccessor)
        {
            this.httpContextAccessor = _httpContextAccessor;
            this.employeeService = _httpContextAccessor.HttpContext.RequestServices.GetRequiredService<IEmployeeService>();
        }

        public override void OnActionExecuted(ActionExecutedContext requestContext)
        {

        }

    }
}
