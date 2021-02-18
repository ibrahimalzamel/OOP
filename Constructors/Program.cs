using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 6 , FirstName = "ibrahim", LastName= "alzamel",City = "konya" };
            Customer customer2 = new Customer(7, "nermin", "isrep", "konya");

            Console.WriteLine(customer2.FirstName);
        }
    }
}
