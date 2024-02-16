
using System.Data.Common;
using crudMVCwebApp.Data;
using crudMVCwebApp.Models;
using crudMVCwebApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace crudMVCwebApp.Controllers
{
 
    public class EmployeesController : Controller
    {
        private readonly ApplicationDBContext context;
        private readonly ILogger<EmployeesController> _logger;


        public EmployeesController(ILogger<EmployeesController> logger, ApplicationDBContext dBContext)
        {
            _logger = logger;
            this.context= dBContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddEmployeeViewModel viewModel)
        {
            var newEmployee= new Employee
            {
                Id=Guid.NewGuid(),
                Name= viewModel.Name,
                Email= viewModel.Email,
                DateOfBirth= viewModel.DateOfBirth

            };

            this.context.Employees.Add(newEmployee);
            this.context.SaveChanges();
            
            return RedirectToAction("Add");
        } 

        [HttpGet]
        public IActionResult Index()
        {
            var employees= this.context.Employees.ToList();
            return View (employees);
        }

        [HttpGet]
        public IActionResult View (Guid Id)
        {
            var employee= this.context.Employees.FirstOrDefault(p=>p.Id==Id);
            return View("View", employee);
        }

        [HttpPost]
        public IActionResult View(Employee updateEmployee)
        {
            var existedEmployee = this.context.Employees.FirstOrDefault(p => p.Id == updateEmployee.Id);

            if (existedEmployee is not null)
            {
                existedEmployee.Name = updateEmployee.Name;
                existedEmployee.Email = updateEmployee.Email;
                existedEmployee.DateOfBirth = updateEmployee.DateOfBirth;
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete (Employee model)
        {
            var existingEMployee= context.Employees.FirstOrDefault(p=>p.Id==model.Id);
            if (existingEMployee !=null )
            {
                context.Remove(existingEMployee);
                context.SaveChanges();
                
            }
            return RedirectToAction ("Index");
        }

    }
}