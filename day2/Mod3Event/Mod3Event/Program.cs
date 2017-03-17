using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Event
{
    
    class MyButton
    {
        //EventHandler와 같음
        public delegate void MyEventHandler(object sender, EventArgs e);
        public event MyEventHandler MyClick;
        public void RaiseEvent()
        {
            if (MyClick != null)
            {
                MyClick(this, new EventArgs());
            }
        }
    }
    class MyForm
    {
        public void ButtionClick1(object source, EventArgs e)
        {
            Console.WriteLine("ButtonClick1");

        }
        public void ButtionClick2(object source, EventArgs e)
        {
            Console.WriteLine("ButtonClick2");

        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyForm f = new MyForm();
            MyButton b = new MyButton();
            b.MyClick += f.ButtionClick1;
            b.MyClick += f.ButtionClick2;
            b.MyClick += delegate(object sender, EventArgs e)
            {
                Console.WriteLine("ButtonClick3");
            };
            b.RaiseEvent();
        }
    }
}
