using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Indexer
{
    class StringList
    {
        public string[] list;
        public string this[int i]
        {
            set
            {
                list[i] = value;
            }
            get
            {
                return list[i];
            }
        }
        public StringList(int size)
        {
            list = new string[size];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StringList list = new StringList(5);
            list[0] = "string";
            Console.WriteLine(list[0]);
        }
    }
}
