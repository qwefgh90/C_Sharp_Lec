using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Interface
{
    interface IBeverage
    {
        int GetTemperature();
        void Paint();
    }
    interface ITest
    {
        void Paint();
    }
    class Coffee : IBeverage, ITest
    {
        private string bean;

        int IBeverage.GetTemperature()
        {
            return 0;
        }
        void IBeverage.Paint()
        {

        }
        void ITest.Paint()
        {
            ((IBeverage)this).Paint();
            //this.Paint();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Coffee c = new Coffee();
            IBeverage i = c;
            i.GetTemperature();
        }
    }
}
