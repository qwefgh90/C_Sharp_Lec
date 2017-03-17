using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Mod8HttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest request = WebRequest.Create("http://www.naver.com") as HttpWebRequest;
            //Get
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            //Response
            /*
            System.IO.Stream s = new System.IO.FileStream(@"c:\hello.txt", System.IO.FileMode.Open);//response.GetResponseStream();
           
            byte[] b = new byte[1024];
            int n = s.Read(b, 0, 1024);
            string str = "";
            while( n > 0){
                str += Encoding.UTF8.GetString(b);
                n = s.Read(b, 0, 1024);
            }
            Console.WriteLine(str);
            s.Close();
            */

            using (System.IO.Stream s = new System.IO.FileStream(@"c:\hello.txt", System.IO.FileMode.Open))//response.GetResponseStream())
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(s, Encoding.UTF8);
                while (!reader.EndOfStream)
                    Console.WriteLine(reader.ReadLine());
            }
            
        }
    }
}
