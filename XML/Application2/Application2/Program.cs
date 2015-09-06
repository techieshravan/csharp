using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Application2
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = CreateCustomerList();

            var customerXml = new XDocument();
            var rootElement = new XElement("Customers");
            customerXml.Add(rootElement);

            foreach (var customer in customers)
            {
                var customerElement = new XElement("Customer");

                var firstNameElement = new XElement("FirstName", customer.FirstName);
                customerElement.Add(firstNameElement);

                var lastNameElement = new XElement("LastName", customer.LastName);
                customerElement.Add(lastNameElement);

                var emailAddressElement = new XElement("EmailAddress", customer.EmailAddress);
                customerElement.Add(emailAddressElement);

                rootElement.Add(customerElement);
            }

            Console.WriteLine(customerXml.ToString());
            Console.ReadKey();
        }

        private static IEnumerable<Customer> CreateCustomerList()
        {
            var customers = new List<Customer>
            {
                new Customer { FirstName = "PersonFN1", LastName = "PersonLN1", EmailAddress = "person1@abc.com"},
                new Customer { FirstName = "PersonFN2",LastName = "PersonLN2",EmailAddress = "person2@abc.com" },
                new Customer { FirstName = "PersonFN3",LastName = "PersonLN3",EmailAddress = "person3@abc.com" },
                new Customer { FirstName = "PersonFN4",LastName = "PersonLN4",EmailAddress = "person4@abc.com" }
            };
            return customers;
        }
    }
}
