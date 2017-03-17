using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2Method
{
    class Util
    {
        public static int MaxNum(int a, int b)
        {
            return a > b ? a : b;
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Divide(int a, int b,out int q, out int r)
        {
            q = a / b;//몫
            r = a % b;//나머지
        }
    }
    class Program
    {
        static void Test()
        {

        }

        static void Main(string[] args)
        {
            Test();
            int x = 2;
            int y = 5;
            Util u = new Util();
            int m = Util.MaxNum(x, y);
            Console.WriteLine("{0}과 {1}중에 큰수는 {2}입니다.", x, y, m);
            Util.Swap(ref x, ref y);
            Console.WriteLine("{0}과 {1}중에 큰수는 {2}입니다.", x, y, m);
            int q;
            int r;
            Util.Divide(x, y, out q, out r);
            Console.WriteLine("{0} / {1} = 몫 : {2}, 나머지 : {3}", x, y, q, r);
        }
    }
}
