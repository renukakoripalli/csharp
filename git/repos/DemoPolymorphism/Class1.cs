using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    class Class1
    {
        static void Main(string[] args)
        {
            Shape picture = new Shape();
            picture.draw();
            picture.draw(10);
            picture.draw(12, 4);
            picture.draw(1, 2, 3, "cube");
            Console.ReadLine();
        }
    }
}
