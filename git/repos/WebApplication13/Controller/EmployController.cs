

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using EmployeeManage.Model;
namespace EmployeeManage.Controllers
{
    public class EmployeeController : Controller
    {
        //  IEmployeeRepository employeeRepository = new EmployeeRepository();
        private readonly IEmployeeRepository employeeRepository;
        public EmployeeController(IEmployeeRepository emrepository)//dependency injected object
        {
            employeeRepository = emrepository;
        }
        public ContentResult Search(int? id)
        {
            int Id = (int)((id == null) ? 1 : id);

            Employ emp = employeeRepository.GetEmployee(Id);
            if (emp != null)
            {
                return Content(emp.Id + "\n" + emp.Name + "\n" + emp.Email + "\n " + emp.Dept);
            }
            else
                return Content("Employee does not exist");
        }
        public IActionResult Index()
        {
            List<Employ> elist = employeeRepository.DisplayDetails();
            return View(elist);
        }
        //public ViewResult
        public ViewResult AboutEmployee()
        {
            Employ emp = employeeRepository.GetEmployee(2);
            //ViewBag.projectName = "BlackPanter";
            EmployprojectviewModel ep = new EmployprojectviewModel();
            ep.employee = emp;
            ep.projectname = "BlackPanter";
            return View(ep);
        }
        public IActionResult GetAllEmployees()
        {
            List<Employ> elist = employeeRepository.DisplayDetails().Where(e => e.Dept == "cse").ToList();
            //absolute path to refer a view
            return View("Index", elist);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Employ emp = employeeRepository.GetEmployee(2);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Create(int id)
        {
            return View("success");
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Employ> elist = employeeRepository.DisplayDetails();
            return View(elist);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Employ employee)

        {
            bool res = employeeRepository.AddEmployee(employee);
            return RedirectToAction("Index");
        }

    }
}