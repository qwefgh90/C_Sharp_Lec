using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1String
{
    class Program
    {
        static void Main(string[] args)
        {
            const int aa = 3;
            const string ss = "hello";
            string s = "hello";//heap
            s = s + "world";//operator overloading
            Console.WriteLine(s);
            s = s.Remove(2,3);
            Console.WriteLine(s);
            
            StringBuilder sb = new StringBuilder("hello");
            sb.Append("world");
            sb.Remove(2, 3);
            Console.Write(sb);
        }
    }
}
