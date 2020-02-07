using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.Properties.Model
{
    public class sellerbo : Iseller
    {
        private List<seller> se;
        public sellerbo()
        {
            se = new List<seller>() { new seller("gany", "007", "cts", "001111", "eluru") };

        }
        public seller GetSeller(string id)
        {
            seller s = se.FirstOrDefault(s => s.Id1 == id);
            return s;

        }

    }
}