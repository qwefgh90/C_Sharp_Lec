using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Enum
{
    enum Color
    {
        Red = 5, Green, Blue, Black
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            DayOfWeek today = DayOfWeek.Tuesday;
            Color my = Color.Black;
            Console.WriteLine((int)my);
            
        }
    }
}
