﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DemoCookies.Models;
namespace DemoCookies.Controllers
{
    public class CookieSessionController : Controller
    {
        // GET: CookieSession
        public readonly UserAccountContext _context;

        public CookieSessionController(UserAccountContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(UserAccount uc)
        {
            try
            {
                _context.Add(uc);
                _context.SaveChanges();
                ViewBag.message = uc.Username + "has got successfully registered";
                return RedirectToAction("Login");
            }
            catch (Exception e)
            {
                ViewBag.message = uc.Username + "registered failed";
            }

            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserAccount uc)
        {
            var loguser = _context.UserAccounts.Where(e => (e.Username == uc.Username && e.Password == e.Password));
            if (loguser == null)
            {
                ViewBag.message = "not valid user";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("Uname", uc.Username);
                HttpContext.Session.SetString("lastLogin", DateTime.Now.ToString());
                return RedirectToAction("CreateDashBoard");
            }



        }
        public ActionResult CreateDashBoard()
        {
            if (HttpContext.Session.GetString("UName") != null)
                ViewBag.uname = HttpContext.Session.GetString("UName").ToString();
            ViewBag.lldt = HttpContext.Session.GetString("lastLogin").ToString();
            return View();
        }

        // GET: CookieSession/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CookieSession/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CookieSession/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookieSession/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CookieSession/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookieSession/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CookieSession/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}