using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace LINQExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating Xml using XLinq!");
            var xmlDoc = new XElement("Customers",new XElement("Customer",new XAttribute("CustomerId",1200),new XAttribute("ContactName","Pravinkumar R. D."),new XAttribute("City","Pune"),new XElement("Orders",new XElement("Order",new XAttribute("OrderId",123),new XAttribute("qty",12)))));
            Console.WriteLine(xmlDoc);
            xmlDoc.Save(@"C:\DotNet-Dec-2023\customers.xml");
            //List<Result> finalResult=new List<Result>();
            //foreach (Customer customer in GetCustomers())
            //{
            //    Result result = finalResult.Find(delegate (Result r)
            //    {
            //        return customer.City == r.City;
            //    });
            //    if (result!=null)
            //    {
            //        result.Count++;
            //    }
            //    else
            //    {
            //        result=new Result();
            //        result.City = customer.City;
            //        result.Count = 1;
            //        finalResult.Add(result);
            //    }
            //}
            //GroupBy Query
            /*var finalResult = from customer in GetCustomers()
                              group customer by customer.City into result
                              select new Result { City = result.Key, Count = result.Count() };
            foreach (Result res in finalResult)
            {
                Console.WriteLine($"In city {res.City}, there is/are {res.Count} number of customers!");
            }
            //Select * from Customers
            var customers = from customer in GetCustomers()
                            //where customer.City == "Mumbai"
                            orderby customer.City, customer.ContactName descending
                            select customer;
            foreach (Customer cust in customers)
            {
                Console.WriteLine($"Customer Contact name is {cust.ContactName} who lives in city {cust.City}!");
            }*/
        }
        private static List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer() { CustomerId = 1, ContactName = "Alisha C.", City = "Mumbai" },
                new Customer() { CustomerId = 2, ContactName = "Manish Kaushik", City = "Mumbai" },
                new Customer() { CustomerId = 3, ContactName = "Maria Andrus", City = "Berlin" },
                new Customer() { CustomerId = 4, ContactName = "John Mark", City = "Berlin" },
            };
        }
    }
}