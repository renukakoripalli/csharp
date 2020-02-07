using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCnt
{
    class ObjectDemo
    {
        static void Main()
        {
            int i = 10;
            //char ch = 'a';
            object ob = 12;
            int k = (int)ob;
            object ob1 = 12.3;
            double d1 = (double)ob1;
            object ob2 = 'a';
            char ch1 = (char)ob2;
            object ob3 = "abc";
            string s = ob3.ToString();
            s = i.ToString();
            s = d1.ToString();
        }
    }
}
