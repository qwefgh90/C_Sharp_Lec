using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1Overload
{
    class Util
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            r = Util.Add(10, 20);
            r = Util.Add(10, 20, 30);
            
            double dr;
            dr = Util.Add(10.5, 8.8);

        }
    }
}
