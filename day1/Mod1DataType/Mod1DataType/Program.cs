using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1DataType
{
    class Program
    {
        static void Main(string[] args)
        {

            long a = 1;
            int b = 2;
            b = (int)a;

            Console.WriteLine("hosrt max={0} min={1}", short.MaxValue, short.MinValue);
            Console.WriteLine("hosrt max={0} min={1}", ushort.MaxValue, ushort.MinValue);

            Console.WriteLine("나이입력?");
            string temp = Console.ReadLine();
            //int age = int.Parse(temp);
            int age;
            if(!int.TryParse(temp, out age))
            {
                Console.Write("변환 오류\n");
            }
                
                //age = Convert.ToInt32(temp);
            
            age--;
            Console.WriteLine("입력하신 만 나이는 {0}입니다.", age);
        }
    }
}
