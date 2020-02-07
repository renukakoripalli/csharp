using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Model
{
    public class Seller
    {
        //int sid, sno;
        //string sname, spswd, compname, gstin, det, sadd, cweb, smail;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Phno { get; set; }
        public string Cname { get; set; }
        public string Gstin { get; set; }
        public string Email { get; set; }
        public string compname { get; set; }
        public string Pswd { get; set; }
        public string Cabout { get; set; }
        public string Cadress { get; set; }
        public string Cweb { get; set; }

        //public Seller() { }

        public Seller(int id, int mbl, string name, string email, string pswd, string compname, string gstin, string cabout, string cadress, string cweb)
        {
            this.Id = id;
            this.Name = name;
            this.Phno = mbl;
            this.Email = email;
            this.Pswd = pswd;
            this.compname = compname;
            this.Gstin = gstin;
            this.Cabout = cabout;
            this.Cadress = cadress;
            this.Cweb = cweb;
        }


    }
}