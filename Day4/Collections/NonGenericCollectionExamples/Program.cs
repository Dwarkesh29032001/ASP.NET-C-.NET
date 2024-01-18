using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollectionExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList numbers= new ArrayList();
            numbers.Add(100);//Boxing
            numbers.Add(200);
            numbers.Add(300); 
            numbers.Add(400);
            int firstNo = Convert.ToInt32(numbers[0]); //Unboxing
            Console.WriteLine(firstNo);
            foreach (object number in numbers)
            {
                Console.WriteLine(number); ;
            }
            */
            /*Stack books= new Stack();
            books.Push("C# Vol-1");
            books.Push("C# Vol-2");
            books.Push("C# Vol-3");
            books.Push("C# Vol-4");
            Console.WriteLine(books.Peek());
            Console.WriteLine("");
            foreach (object book in books)
            {
                Console.WriteLine(book);
            }
            */
            /*Queue tickets= new Queue();
            tickets.Enqueue(100);
            tickets.Enqueue(200);
            tickets.Enqueue(300);
            tickets.Enqueue(400);
            tickets.Enqueue(500);
            int firstTicketNo=Convert.ToInt32(tickets.Peek());
            Console.WriteLine("");
            foreach (object ticket in tickets)
            {
                Console.WriteLine(ticket);
            }
            */
            Hashtable employees= new Hashtable();
            employees.Add(1000, "Employee-1");
            employees.Add(1001, "Employee-2");
            employees.Add(1002, "Employee-3");
            employees.Add(1003, "Employee-4");
            employees.Add(1004, "Employee-5");
            foreach (object employeeId in employees.Keys)
            {
                
                Console.WriteLine($"Employee Id {employeeId} with the name {employees[employeeId]}");
            }
        }
    }
}
