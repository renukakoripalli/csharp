using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using ProjectDemo.Properties.Model;

namespace ProjectDemo.Properties.Controllers
{
    public class selCon : Controller
    {
        Iseller Is = new sellerbo();
        public string Search()
        {
            seller s = Is.GetSeller("007");
            return s.Name1 + "\n" + s.Id1 + "\n" + s.Address1 + "\n" + s.Moblie1 + "\n" + s.Company1;
        }

    }
}