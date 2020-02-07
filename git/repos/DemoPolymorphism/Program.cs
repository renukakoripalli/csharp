using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    class Shape
    {
        int length;
        int width;
        int breadth;
        public void draw()
        {
            Console.WriteLine("A shape can be drawn");
        }
        public void draw(int l)
        {
            this.length = l;
            Console.WriteLine("a square can be drawn");
        }
        public void draw(int l,int w)
        {
            this.length = l;
            this.width = w;
            Console.WriteLine("a rectangle  can be drawn");
        }
        public void draw(int l, int w,int b)
        {
            this.length = l;
            this.width = w;
            this.breadth = w;
            Console.WriteLine("a box  can be drawn");
        }
        public void draw(int l, int w, int b,string name)
        {
            Console.WriteLine(name+ " can be drawn");
        }
    }
}
