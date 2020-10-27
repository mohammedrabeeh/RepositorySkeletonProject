using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Service;

namespace MyProject.WebUI.Controllers
{
    public class EmployeeController : BaseController
    {
        IEmployeeService employeeService;
        public EmployeeController(IHttpContextAccessor _httpContextAccessor, IEmployeeService _employeeService) : base(_httpContextAccessor)
        {
            this.employeeService = _employeeService;
        }

        // GET: EmployeeController
        public ActionResult Index()
        {
            return View(employeeService.ListAll());
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View(new Employee());
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmpCode,EmpName,Id")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeService.CreateEntity(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var employee = employeeService.GetById(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("EmpCode,EmpName,Id")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeeService.UpdateEntity(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = employeeService.GetById(id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var employee = employeeService.GetById(id);
            employeeService.DeleteEntity(employee);
            return RedirectToAction(nameof(Index));
        }
    }
}
