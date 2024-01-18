using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List<int> numbers= new List<int>();
             numbers.Add(100);
             numbers.Add(200);
             numbers.Add(300);
             numbers.Add(400);
             int firstNo = numbers[0];
             foreach (int no in numbers)
             {
                 Console.WriteLine(no);
             }*/
            /*Stack<string> books = new Stack<string>();
             books.Push("C# Vol-1");
             books.Push("C# Vol-2");
             books.Push("C# Vol-3");
             books.Push("C# Vol-4");
             Console.WriteLine(books.Pop());
             Console.WriteLine("");
             foreach (object book in books)
             {
                 Console.WriteLine(book);
             }*/
            /*Queue<int> tickets = new Queue<int>();
            tickets.Enqueue(100);
            tickets.Enqueue(200);
            tickets.Enqueue(300);
            tickets.Enqueue(400);
            tickets.Enqueue(500);
            int firstTicketNo = Convert.ToInt32(tickets.Dequeue());
            Console.WriteLine("");
            foreach (object ticket in tickets)
            {
                Console.WriteLine(ticket);
            }*/
            Dictionary<int,string> employees = new Dictionary<int,string>();
            employees.Add(1000, "Employee-1");
            employees.Add(1001, "Employee-2");
            employees.Add(1002, "Employee-3");
            employees.Add(1003, "Employee-4");
            employees.Add(1004, "Employee-5");
            foreach (int employeeId in employees.Keys)
            {
                Console.WriteLine($"Employee Id {employeeId} with the name {employees[employeeId]}");
            }
        }
    }
}
