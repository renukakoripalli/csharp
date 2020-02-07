using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Mvc;
using HandsOnEmployeeProject.Repositories;
using HandsOnEmployeeProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsOnEmployeeProject.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Designation = new SelectList(new string[] { "AssociateTrainee", "AssociateJunior", "SeniorAssociate" });
            ViewBag.Projectname = new SelectList(new string[] { "Medical", "Banking", "Estates" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee item)
        {
            EmployeeRepository repository = new EmployeeRepository();
            repository.Add(item);
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string eid, string pwd)
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee employee = repository.Validate(eid, pwd);
            if (employee != null)
            {
                return RedirectToAction("Details", employee);
            }
            else
            {
                ViewData["err"] = "Invalid Credentials";
                return View();
            }
        }

        public IActionResult Details(Employee item)
        {
            return View(item);
        }
        public IActionResult Greet(int id)
        {
            return View();
        }

    }


}