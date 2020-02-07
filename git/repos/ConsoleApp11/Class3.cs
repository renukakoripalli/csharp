using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Class3
    {
        static void Main(string[] args)
        {
            ICICI chn = new ICICI("icici 001", "chennai", "Arun");
            SBI hyd = new SBI("sbi003", "hyderabad", "renu");
            chn.displaydetails();
            chn.getIntrest();
            chn.displayDemat();
            hyd.displaydetails();
            hyd.getIntrest();
            Console.ReadKey();

        }
    }
}
