using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10Lambda
{
    class Program
    {
        delegate void MyDelegate(string s);
        public static void Hello(string s)
        {
            Console.WriteLine("Hello " + s);
        }
        public static void GoodBye(string s)
        {
            Console.WriteLine("GoodBye " + s);
        }

        static void Main(string[] args)
        {
            MyDelegate d = (String s) => Console.WriteLine(s);
            d("hello");
        }
    }
}
