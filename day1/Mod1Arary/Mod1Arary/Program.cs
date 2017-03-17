using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1Arary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            a[0] = 1;
            int[] a2 = new int[] { 1, 2, 3, 4, 5 };
            int[,] b = new int[2, 3];
            int[,] b1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            foreach (int i in a)
                Console.WriteLine(i);

            string[] sa = { "ap", "ba", "ca" };
            foreach (string s in sa)
                Console.WriteLine(s);

            Array.Sort(a);
            Array.Reverse(a);
            Array.IndexOf(a, 0);
            a.Clone();
        }
    }
}
