using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod4Class
{
    class DrinksMachine
    {
        //field-data
        private int age;

        public string Model
        {
            get;
            set;
        }

        //property
        public int Age
        {
            get { return age; }
            set {
                if (value > 0) 
                age = value; 
            }
        }
        
        //constructor
        public DrinksMachine(int a=0)
        {
            age = a;
            Model = "UNKNOWN";
        }
        public DrinksMachine(int a, string model)
        {
            age = a;
            Model = model;
        }
        //method
        public void MakeCoffee()
        {
            Console.WriteLine("MakeCoffee" + Age);
        }
    }
}
