using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Delegate
{
    delegate void MyDelegate(string s);

    class Program
    {
        public static void Hello(string s)
        {
            Console.WriteLine("Hello," + s);
        }
        public static void Goodbye(string s)
        {
            Console.WriteLine("Goodbye," + s);
        }
        static void Main(string[] args)
        {
            MyDelegate d = new MyDelegate(Hello);
            d = (string s) => Console.WriteLine("Goodbye," + s);

            MyDelegate d2 = new MyDelegate(Hello);
            d2 += (string s) => Console.WriteLine("Hi, " + s);
            d2 += (string s) => Console.WriteLine("Hi, " + s);
            d2 += new MyDelegate(Hello);

            d("chang");
            d2("multicast");

            Button button1 = new Button();
            button1.Click += Hello;
        }
    }
    class Button
    {
        public event MyDelegate Click;
        public void raise()
        {
            Click("hello");
        }
    }
}
