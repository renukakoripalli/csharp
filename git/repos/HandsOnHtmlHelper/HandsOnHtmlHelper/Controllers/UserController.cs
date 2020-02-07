using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnHtmlHelper.Repositories;
using HandsOnHtmlHelper.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsOnHtmlHelper.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Country = new SelectList(new string[] { " ","India", "china", "Us", "uk" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(User item)
        {
            UserRepository repository = new UserRepository();
            repository.Add(item);
            return RedirectToAction("Login");
        }
       [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string uname,string pwd)
        {
            UserRepository repository = new UserRepository();
            User user = repository.Validate(uname, pwd);
            if(user!=null)
            {
                return RedirectToAction("Details",user);
            }
            else
            {
                ViewData["err"] = "Invalid Credentials";
                return View();
            }
        }
       /* public IActionResult Details([Bind(include:"Name")]User item)
        {
            return View();//used to hide password
        }*/

        public IActionResult Details(User item)
        {
            return View(item);
        }
        public IActionResult Greet(int id)
        {
            return View();
        }

    }
    

}