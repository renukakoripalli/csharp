using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DemoFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"e:\Users\Sumsung\mydir2");
            if(di.Exists==false)di.Create();
            di.CreateSubdirectory("mydir1");
            DirectoryInfo[] d = di.GetDirectories();
            foreach(DirectoryInfo x in d)
            {
                Console.WriteLine(x.Name + "" +x.FullName + "" + x.CreationTime);
            }
            /* FileInfo[] fi = di.GetFiles();
             Console.WriteLine("**************************************************");
             foreach (FileInfo x in fi)
             {
                 Console.WriteLine(x.Name + "" + x.FullName + "" + x.CreationTime);
             }
             FileStream fs = new FileStream(@"e:\Users\Sumsung\mydir2\a.txt", FileMode.OpenOrCreate, FileAccess.Write);

             StreamWriter sw = new StreamWriter(fs);

             sw.WriteLine("welcome");
             for(int i=0;i<4;i++)
             {
                 string s = Console.ReadLine();
                 sw.WriteLine(s);


             }
             sw.Close();
             fs.Close();*/
            /*FileStream fs1 = new FileStream(@"e:\Users\Sumsung\mydir2\a.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs1);
            string s;
            while((s=sr.ReadLine())!=null)
            {
                Console.WriteLine(s);
            }
            sr.Close();
            fs1.Close();*/
            FileStream fs = new FileStream(@"e:\Users\Sumsung\mydir2\b.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            int i = 10;
            char ch = 'd';
            string f = "hello";
            bw.Write(i);
            bw.Write(ch);
            bw.Write(f);
            bw.Close();
            fs.Close();
            FileStream fs1 = new FileStream(@"e:\Users\Sumsung\mydir2\b.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader bw1 = new BinaryReader(fs1);
            int j = bw1.ReadInt32();
            char y = bw1.ReadChar();
            string z = bw1.ReadString();
            bw1.Close();
            fs1.Close();
            Console.WriteLine(j + " " + y + " " + z);
            Console.ReadLine();
        }
    }
}
