using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Seller
    {
        int id;
        string name, phno, GSTIN, email, cpname;
        public Seller(int id, string name, string phno, string GSTIN, string cpname)
        {
            this.id = id;
            this.name = name;
            this.phno = phno;
            this.GSTIN = GSTIN;
            this.cpname = cpname;
        }
        public void details()
        {
            Console.WriteLine("---My Profile--");
            Console.WriteLine("Seller id: " + id);
            Console.WriteLine("seller name: " + name);
            Console.WriteLine("seller phone number: " + phno);
            Console.WriteLine("GSTIN number: " + GSTIN);
            Console.WriteLine("company name: " + cpname);
        }
    }

    class SellerBO : Seller
    {
        int cid;
        List<Category> l1 = new List<Category>();
        List<SubCategory> l2 = new List<SubCategory>();
        List<Item> l3 = new List<Item>();
        public void additems()
        {
            Console.WriteLine("enter number of categories to add");
            int cat = int.Parse(Console.ReadLine());
            Console.WriteLine("enter categories names");
            for (int i = 0; i < cat; i++)
            {

                Console.WriteLine("enter category name");
                string catname = Console.ReadLine();
                Console.WriteLine("enter category id");
                cid = int.Parse(Console.ReadLine());
                l1.Add(new Category(cid, catname));
            }
            Console.WriteLine("enter no of subcategories to add");
            int subcat = int.Parse(Console.ReadLine());
            Console.WriteLine("enter sub categories names");
            for (int i = 0; i < subcat; i++)
            {
                Console.WriteLine("enter sub category name");
                string sub_name = Console.ReadLine();
                Console.WriteLine("enter sub category id");
                int sub_id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter detaisl");
                string sub_det = Console.ReadLine();
                l2.Add(new SubCategory(cid, sub_id, sub_name, sub_det));
            }
            Console.WriteLine("enter no of items to be added");
            int item_n = int.Parse(Console.ReadLine());
            for (int i = 0; i < item_n; i++)
            {
                Console.WriteLine("enter items to be added");
                string item_name = Console.ReadLine();
                Console.WriteLine("enter item id");
                int item_id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter details of item");
                string item_det = Console.ReadLine();
                Console.WriteLine("enter price of item");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("enter ");
            }
        }
    }
}