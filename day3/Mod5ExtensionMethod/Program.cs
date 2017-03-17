using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mod5ExtensionMethod
{
    static class A
    {
        public static Boolean ContainsNumber(this string s)
        {
            return Regex.IsMatch(s, @"\d");
        }

        public static int ToInt32(this string s)
        {
            return int.Parse(s);
        }

        public static int Power(this int k, int m)
        {
            return (int)Math.Pow(k, m);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string h = "123";
            int a = 3;
            Console.WriteLine(h.ToInt32());
            Console.WriteLine(a.Power(3));
        }
    }
}
