using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Application4
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerXml = CreateCustomerListXml();
            Console.WriteLine(customerXml.ToString());

            Console.WriteLine("======================================");
            Console.WriteLine("Searching for single element...");
            Console.WriteLine("======================================");

            var result = from customer in customerXml.Element("Customers").Elements("Customer")
                         where customer.Attribute("CustomerId").Value == "CUST0002"
                         select customer;

            XElement oneCustomerElement = result.SingleOrDefault();

            if (oneCustomerElement != null)
            {
                Console.WriteLine(oneCustomerElement);
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.WriteLine("======================================");
            Console.WriteLine("Searching using descendant axis... ");
            Console.WriteLine("======================================");

            result = from customer in customerXml.Descendants("Customer")
                     where customer.Attribute("CustomerId").Value == "CUST0001"
                     select customer;

            oneCustomerElement = result.SingleOrDefault();

            if (oneCustomerElement != null)
            {
                Console.WriteLine(oneCustomerElement);
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.WriteLine("======================================");
            Console.WriteLine("Searching using element values... ");
            Console.WriteLine("======================================");

            result = from emailAddress in customerXml.Descendants("EmailAddress")
                     where emailAddress.Value == "person3@abc.com"
                     select emailAddress;

            XElement oneEmail = result.SingleOrDefault();

            if (oneEmail != null)
            {
                Console.WriteLine(oneEmail);
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.WriteLine("======================================");
            Console.WriteLine("Searching using child element values... ");
            Console.WriteLine("======================================");

            result = from customer in customerXml.Descendants("Customer")
                     where customer.Element("EmailAddress").Value == "person1@abc.com"
                     select customer;

            oneCustomerElement = result.SingleOrDefault();

            if (oneCustomerElement != null)
            {
                Console.WriteLine(oneCustomerElement);
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.ReadKey();
        }

        private static IEnumerable<Customer> CreateCustomerList()
        {
            var customers = new List<Customer>
            {
                new Customer { FirstName = "PersonFN1", LastName = "PersonLN1", EmailAddress = "person1@abc.com", CustomerId="CUST0001", Phone="(503) 555-6871"},
                new Customer { FirstName = "PersonFN2",LastName = "PersonLN2",EmailAddress = "person2@abc.com", CustomerId="CUST0002", Phone="(503) 555-6872" },
                new Customer { FirstName = "PersonFN3",LastName = "PersonLN3",EmailAddress = "person3@abc.com", CustomerId="CUST0003", Phone="(503) 555-6873" },
                new Customer { FirstName = "PersonFN4",LastName = "PersonLN4",EmailAddress = "person4@abc.com", CustomerId="CUST0004", Phone="(503) 555-6874" }
            };
            return customers;
        }

        private static XDocument CreateCustomerListXml()
        {
            var customers = CreateCustomerList();

            var customerXml = new XDocument(new XElement("Customers",
                from customer in customers
                select new XElement("Customer",
                    new XAttribute("CustomerId", customer.CustomerId),
                    new XAttribute("Phone", customer.Phone),
                    new XElement("FirstName", customer.FirstName),
                    new XElement("LastName", customer.LastName),
                    new XElement("EmailAddress", customer.EmailAddress)
            )));
            return customerXml;
        }
    }
}
