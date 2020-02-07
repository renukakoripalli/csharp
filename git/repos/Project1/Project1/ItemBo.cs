using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class ItemBO
    {
        static List<Item> litem = new List<Item>();
        static List<SubCategory> lsc = new List<SubCategory>();


        public void AddItem(int ino, int cid, int scid, string name, string cname, string scname, int noi, int price, string desc, string cdesc, string scdesc)
        {

            SubCategory cat = new SubCategory(cid, scid, cname, scname, cdesc, scdesc);
            Item item = new Item(ino, scid, name, noi, price, desc);
            lsc.Add(cat);
            litem.Add(item);
            Console.WriteLine(name + " is add to the list ");
        }
        public void DisplayProducts()
        {
            foreach (Category i in lsc)
            {
                Console.WriteLine("Category Id  Category Name   Category Desc");
                Console.WriteLine(i.cid + "\t" + i.cname + "\t" + i.cdesc);
            }
            Console.WriteLine("Enter Cid for which you want to go to Subcategory");
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine("SubCategory Id  SubCategory Name   SubCategory Desc");
            foreach (SubCategory i in lsc)
            {
                if (i.cid == ch)
                {

                    Console.WriteLine(i.scid + "\t" + i.scname + "\t" + i.scdesc);
                }
            }
            Console.WriteLine("Enter scid for which you want to go to Items");
            int ch1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Item Id  Item Name  Item Quantity  Item Price  Item Description");
            foreach (Item i in litem)
            {
                if (i.scid == ch1)
                {

                    Console.WriteLine(i.ino + " " + i.name + " " + i.noi + " " + i.price + " " + i.desc);
                }
            }
        }
        public void Search()
        {
            Console.WriteLine("1.Search By Item Number");
            Console.WriteLine("2.Search By Item Name");
            Console.WriteLine("Enter Your Choice");
            int ch = int.Parse(Console.ReadLine());
            int f = 0;
            if (ch == 1)
            {
                Console.WriteLine("Enter Item NO that you want to search");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Item Id  Item Name  Item Quantity  Item Price  Item Description");
                foreach (Item i in litem)
                {
                    if (i.ino == n)
                    {

                        Console.WriteLine(i.ino + " " + i.name + " " + i.noi + " " + i.price + " " + i.desc);
                    }
                    else
                        f = 1;
                }
            }
            else
            {
                Console.WriteLine("Enter Item Name that you want to search");
                String name = Console.ReadLine();
                Console.WriteLine("Item Id  Item Name  Item Quantity  Item Price  Item Description");
                foreach (Item i in litem)
                {
                    if (i.name == name)
                    {

                        Console.WriteLine(i.ino + " " + i.name + " " + i.noi + " " + i.price + " " + i.desc);
                    }
                    else
                        f = 1;
                }
            }
            if (f == 1)
                Console.WriteLine("Item Not Found");
        }
    }
}