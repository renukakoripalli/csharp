using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPro
{
    class itembo
    {
        static List<items> ilist = new List<items>();
        static List<SubCategory> clist = new List<SubCategory>();
        public void additems(int Ino, int price,string itname, string desit, int soc, string re, string Cna, int Cid, string Subnmae,string des, int sid,string sellerid) { 
            SubCategory sub_cat = new SubCategory(Cid, Subnmae, des,Cna,sid);
            items item=new items(Ino, price, itname,desit, soc, re,sellerid,sub_cat);
            clist.Add(sub_cat);
            ilist.Add(item);
        }
        public void Display()
        {
            Console.WriteLine("Item no:" +" " +
                " ");
        }
    }
}
