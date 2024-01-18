using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace LINQ_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Generating Xml using XLinq!");
            var xmlDoc = new XElement("Customers", new XElement("Customer", new XAttribute("CustomerId", 1200), new XAttribute("ContactName", "Pravinkumar R. D."), new XAttribute("City", "Pune"), new XElement("Orders", new XElement("Order", new XAttribute("OrderId", 123), new XAttribute("qty", 12)))));
            Console.WriteLine(xmlDoc);
            xmlDoc.Save(@"D:\INFOWAY\ASP.NET\Day-6\LINQ_Example\LINQ_Example\customers1.xml");*/
            List<Result> finalResult = new List<Result>();
            foreach (Customer customer in GetCustomers())
            {
                Result result = finalResult.Find(delegate (Result r)
                {
                    return customer.City == r.City;
                   
                });
                if (result != null)
                {
                    Console.WriteLine($"Customer Contact name is {customer.ContactName} who lives in city {customer.City}!");
                    result.Count++;
                }
                else
                {
                    result = new Result();
                    result.City = customer.City;
                    result.Count = 1;
                    finalResult.Add(result);

                }
            }


            //GroupBy Query
            /*  var finalResult1 = from customer in GetCustomers()
                                 group customer by customer.City into result
                                 select new Result { City = result.Key, Count = result.Count() };
              foreach (Result res in finalResult1)
              {
                  Console.WriteLine($"In city {res.City}, there is/are {res.Count} number of customers!");
              }*/
            //Select * from Customers
          /*  var customers = from customer in GetCustomers()
                            where customer.City == "Pune"
                            orderby customer.City, customer.ContactName descending
                            select customer;
            foreach (Customer cust in customers)
            {
                Console.WriteLine($"Customer Contact name is {cust.ContactName} who lives in city {cust.City}!");
            }*/
            Console.ReadKey();

        }
        private static List<Customer> GetCustomers()

            {
            return new List<Customer>() {
                new Customer() {CustomerId = 1 , ContactName = "Dwarkesh" , City="Pune"} ,
                new Customer() {CustomerId = 2 , ContactName = "Amey" , City="Warud"} ,
                new Customer() {CustomerId = 3 , ContactName = "Yash" , City="PCMC"} ,
                new Customer() {CustomerId = 4 , ContactName = "Piyush" , City="Akot"},
                new Customer() {CustomerId = 4 , ContactName = "Omkar" , City="Pune"}


            };

            }

        }

    }

        
  