using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using WebApplication7.Model;

namespace WebApplication7.Controllers
{
    public class Sellercontroller : Controller
    {
        //Sinterface ser = new Sellerr();
        private readonly Sinterface ser;
        public Sellercontroller(Sinterface ser1)
        {
            ser = ser1;
        }
        public ActionResult Search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);
            Seller s = ser.Get(ID);
            //return s.Cabout + "\n" + s.Cadress + "\n" + s.Cadress + "\n" + s.compname + "\n" + s.Cweb + "\n" + s.Email + "\n" + s.Gstin + "\n" + s.Id + "\n" + s.Name + "\n" + s.Phno + "\n";
            return View(s);
        }
        public IActionResult Index()
        {
            List<Seller> slist = ser.DisplayDetails();
            return View(slist);
        }

        //Seller se1 = ser.Get(1);
        //return se1.Sid + "\n" + se1.Sname + "\n" + se1.Spswd + "\n" + se1.Compname + "\n" + se1.Gstin + "\n" + se1.Details + "\n" + se1.Cweb + "\n" + se1.Smail + "\n" + se1.Sno;
        public ViewResult About()
        {
            Seller s = ser.Get(2);
            ViewBag.projectName = "emart";
            return View(s);
        }
        public IActionResult Getall()
        {
            List<Seller> slist = ser.DisplayDetails();
            return View(slist);
        }
    }

}
