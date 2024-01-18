using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security;
using System.Runtime.ExceptionServices;


namespace Threading_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started !");
            Console.WriteLine($"Main Method is running on Thread ID {Thread.CurrentThread.ManagedThreadId} !");
            

            Thread t1 = new Thread(new ThreadStart(Job1));
            Thread t2 = new Thread(new ThreadStart(Job2));


            /*t1.Priority= ThreadPriority.Highest;
            t2.Priority= ThreadPriority.Lowest;  */
            

            t1.Start();  // threads are not syncronized so they are running randomly which is decided by CLR 
            t2.Start();  // 

            t1.Join();  // for orderly exxecution of String we use Join() 
            t2.Join();

            Console.WriteLine("Main Method is Ended !");
            Console.ReadKey();  
        }

        private static void Job1()
        {
            Console.WriteLine($"Job1 is running on thread ID {Thread.CurrentThread.ManagedThreadId} !");
            for(int i=0 ; i < 8; i++) {
                Console.WriteLine($"Job1 step - {i}");
                if (i == 5)
                {
                    Thread.Sleep(2000);
                }
                
            }

        }

        private static void Job2()
        {
            Console.WriteLine($"Job2 is running on thread ID {Thread.CurrentThread.ManagedThreadId} !");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Job2 step - {i}");
                if (i == 5)
                {
                    Thread.Sleep(1000);
                }

            }
        }
    }
}
