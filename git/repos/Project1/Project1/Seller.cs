﻿using System;
using System.Collections.Generic;

namespace Project1
{
    class Seller
    {
        int id;
        string name, phno, cname, gstin, email;
        public Seller(int id, string name, string phno, string email, string cname, string gstin)
        {
            this.id = id;
            this.name = name;
            this.phno = phno;
            this.cname = cname;
            this.gstin = gstin;
            this.email = email;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phno { get => phno; set => phno = value; }
        public string Cname { get => cname; set => cname = value; }
        public string Gstin { get => gstin; set => gstin = value; }
        public string Email { get => email; set => email = value; }



        public void AddItems()
        {
            Console.WriteLine("How many items Do you want Add");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Item No. : ");
                int ino = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter category Id:");
                int cid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Category Name : ");
                string cname = Console.ReadLine();
                Console.WriteLine("Enter Category Description : ");
                string cdesc = Console.ReadLine();
                Console.WriteLine("Enter SubCategory Id:");
                int scid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter SubCategory Name : ");
                string scname = Console.ReadLine();
                Console.WriteLine("Enter SubCategory Description : ");
                string scdesc = Console.ReadLine();
                Console.WriteLine("Enter name of item: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Quantity of item:");
                int noi = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Price of Item:");
                int price = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Description for item");
                string desc = Console.ReadLine();
                ItemBO ibo = new ItemBO();
                ibo.AddItem(ino, cid, scid, name, cname, scname, noi, price, desc, cdesc, scdesc);

            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Details...............");
            Console.WriteLine("Id : " + Id);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Phone Number : " + Phno);
            Console.WriteLine("Company Name : " + Cname);
            Console.WriteLine("GSTIN : " + Gstin);
            Console.WriteLine("Email : " + Email);
        }

    }
}