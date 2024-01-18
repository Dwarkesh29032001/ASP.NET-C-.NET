using System;
using System.Threading;

namespace ThreadingExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started!");
            Console.WriteLine($"Main Method is running on Thread Id {Thread.CurrentThread.ManagedThreadId} !");
            Thread t1 = new Thread(new ThreadStart(Job1));
            Thread t2 = new Thread(new ThreadStart(Job2));
            t1.Priority= ThreadPriority.Highest;
            t2.Priority= ThreadPriority.Lowest;
            t2.Start();
            t1.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("Main Method Ended!");
            Console.ReadKey();
        }
        private static void Job1() 
        {
            Console.WriteLine($"Job-1 is running on Thread Id {Thread.CurrentThread.ManagedThreadId} !");
            for (int i = 0; i < 8; i++) 
            {
                Console.WriteLine($"Job-1 Step - {i}");
                if(i==5) Thread.Sleep(1000);
            }
        }
        private static void Job2()
        {
            Console.WriteLine($"Job-2 is running on Thread Id {Thread.CurrentThread.ManagedThreadId} !");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Job-2 Step - {i}");
                if (i == 5) Thread.Sleep(1000);
            }
        }
    }
}
