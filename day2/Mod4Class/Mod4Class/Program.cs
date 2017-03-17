using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Class
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine dm = new DrinksMachine();
            dm.Age = 2;
            dm.MakeCoffee();


            DrinksMachine dm2 = new DrinksMachine(5);
            dm2.MakeCoffee();

            DrinksMachine dm3 = new DrinksMachine(5, "Model");
            
        }
    }
}
