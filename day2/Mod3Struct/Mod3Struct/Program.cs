using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Struct
{
    struct Coffee
    {
        private string bean;
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Bean
        {
            get
            {
                return bean;
            }
            set
            {
                bean = value;
            }
        }

        public Coffee(string bean, string country)
        {
            this.bean = bean;
            this.country = country;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Coffee c = new Coffee("bean", "country");
            c.Bean = "Arbica";
            Console.WriteLine(c.Bean);
        }
    }
}
