using System;
using System.Collections.Generic;
using System.Diagnostics;//EventLog
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력:");
            int n = int.Parse(Console.ReadLine());
            Debug.Assert(n <= 100);  // 실행 :매개변수값이 false일때, Assert대화상자 보여주기

            Debug.WriteLine("Debug:{0}", n);  // 디버깅 Debug
            Trace.WriteLine("Trace:" + n); // 디버깅,Debug & Release

            ////2-18 p

            ////이벤트 뷰어 - Windows로그 - 응용 프로그램
            string eventLog = "Application";
            string eventSource = "Logging Demo";//ProgramName
            string eventMessage = "Hello from...";
            if (!EventLog.SourceExists(eventSource))
                EventLog.CreateEventSource(eventSource, eventLog);
            EventLog.WriteEntry(eventSource, eventMessage);


            // Programmatically Creating Performance Counter Categories and Performance Counters 
            if (!PerformanceCounterCategory.Exists("FourthCoffeeOrders"))
            {
                CounterCreationDataCollection counters = new CounterCreationDataCollection();
                CounterCreationData totalOrders = new CounterCreationData();
                totalOrders.CounterName = "# Orders";
                totalOrders.CounterHelp = "Total number of orders placed";
                totalOrders.CounterType = PerformanceCounterType.NumberOfItems32;
                counters.Add(totalOrders);
                CounterCreationData ordersPerSecond = new CounterCreationData();
                ordersPerSecond.CounterName = "# Orders/Sec";
                ordersPerSecond.CounterHelp = "Number of orders placed per second";
                ordersPerSecond.CounterType = PerformanceCounterType.RateOfCountsPerSecond32;
                counters.Add(ordersPerSecond);
                PerformanceCounterCategory.Create("FourthCoffeeOrders", "A custom category for demonstration",
                PerformanceCounterCategoryType.SingleInstance, counters);

                

            }

            
            Util obj = new Util();

            for (int i = 0; i < 10; i++)
            {
                obj.OrderCoffee();
                System.Threading.Thread.Sleep(1000);
            }

            Console.WriteLine("Press Enter to finish");
            Console.ReadLine();
            
            //EventLog.WriteEntry(eventSource, "프로그램 종료");
        }



    }
    class Util
    {
        // Get a reference to the custom performance counters. 
        PerformanceCounter counterOrders = new PerformanceCounter("FourthCoffeeOrders", "# Orders",
            false);
        PerformanceCounter counterOrdersPerSec = new PerformanceCounter("FourthCoffeeOrders",
            "# Orders/Sec", false);
        // Update the performance counter values at appropriate points in your code.

        public void OrderCoffee()
        {
            counterOrders.Increment();
            counterOrdersPerSec.Increment();
        }
    }
}
