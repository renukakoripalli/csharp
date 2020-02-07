using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Item
    {
        public int ino { get; set; }
        public int noi, price, scid;
        public string desc, name;

        public Item(int ino, int scid, string name, int noi, int price, string desc)
        {
            this.ino = ino;
            this.name = name;
            this.noi = noi;
            this.price = price;
            this.desc = desc;
            this.scid = scid;


        }


    }
}