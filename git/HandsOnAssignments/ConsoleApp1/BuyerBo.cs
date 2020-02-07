using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_consoleApplication
{
    class buyerBo
    {
        // int bid;
        // string bname;
        // string Pasword;
        // double mobile;
        // string Email;
        // DateTime CreatedDate;
        static List<buyer> blist = new List<buyer>();
        //// buyerBo bb0 = new buyerBo();
        public void InitializeBuyersList(int bid, string bname, string Password, double mobile, string Email, DateTime CreatedDate)
        {
            List<buyer> b = new List<buyer>();
            b.Add(new buyer(bid, bname, Password, mobile, Email, CreatedDate));


        }
        public bool checkbuyer(int bid, string Password)
        {

            buyer bo = blist.Find(e => e.bid == bid && e.Password == Password);
            if (bo != null)
            {
                Console.WriteLine("Enter correct credentials...!!!");
                // bb.InitializeBuyersList(bid, bname, Password, mobile, Email, CreatedDate);
                return true;
            }
            else
            {
                Console.WriteLine("SignIn");
                return false;
            }
        }
    }
}