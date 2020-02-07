using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineApplication
{
    class subcatergory:category
    {
       
        public subcatergory(int subid, string subname,string sudesc,int  Cid,string Cname)
        {
            this.subid = subid;
            this.subname = subname;
            this.Cid = this.Cid;
            this.Cname = this.Cname;
            
        }

        public int Subid { get => subid; set => subid = value; }
        public string Subname { get => subname; set => subname = value; }
    }
    
}