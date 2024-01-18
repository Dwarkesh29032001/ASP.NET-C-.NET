using System;
using System.Threading;

namespace ThreadSynchronization
{
    internal class Program
    {
        static int TicketNumber = 1;
        static object o = new object();
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started!");
            Console.WriteLine($"Main Method is running on Thread Id {Thread.CurrentThread.ManagedThreadId} !");
            Thread t1 = new Thread(new ThreadStart(Job1));
            Thread t2 = new Thread(new ThreadStart(Job2));
            //t1.Priority = ThreadPriority.Highest;
            //t2.Priority = ThreadPriority.Lowest;
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
            // lock (o)
            //{
            Monitor.Enter(o);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Job-1 Ticket Number is {TicketNumber} !");
                TicketNumber++;

            }
            Monitor.Exit(o);
            // }
        }
        private static void Job2()
        {
            Console.WriteLine($"Job-2 is running on Thread Id {Thread.CurrentThread.ManagedThreadId} !");
            //lock (o)
            //{
            Monitor.Enter(o);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Job-2 Ticket Number is {TicketNumber} !");
                TicketNumber++;
                if (i == 2) Thread.Sleep(3000);
            }
            Monitor.Exit(o);
            //}
        }
    }
}
