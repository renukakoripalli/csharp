using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArray
{
    class String
    {
        static void Main()
        {
            string[] names = new string[5]
            {
                "renu",
                "vinee",
                "harika",
                "rani",
                "jyo",
            };
            int flag = 0;
            Console.WriteLine("enter the name:");
            string name=Console.ReadLine();
            foreach (string n in names) 
            {
                if(n==name)
                {
                    flag = 1;
                    //Console.WriteLine("found");
                    break;
                }
                if (flag == 0)




                    Console.WriteLine("not found");
                else
                    Console.WriteLine("name exits");
            }

                

        }
    }
}
