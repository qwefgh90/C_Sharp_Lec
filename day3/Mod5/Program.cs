using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5
{
    abstract class Beverage
    {
        //data
        protected int temperature;
        private bool isFairTrade;
        //method
        public abstract int GetTemperature();
        public Beverage()
        {

        }
        public Beverage(int t, bool b)
        {
            this.temperature = t;
            this.isFairTrade = b;
        }
    }
    class Coffee : Beverage
    {
        private string bean;
        public Coffee()
        {
            
        }
        public Coffee(int temp, bool isFairTrade, string bean) : base(temp,isFairTrade)
        {
            this.bean = bean;
        }
        public override int GetTemperature()
        {
            return temperature + 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Coffee c = new Coffee(29, false, "hello");
            int i = c.GetTemperature();
            Console.WriteLine(i);
        }
    }
}
