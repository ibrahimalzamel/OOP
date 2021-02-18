using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class CustomerManager
    {
        public CustomerManager()
        {
            customers = new List<Customer>()
            {
                new Customer{Id = 1 ,FirstName = "maya",LastName="teen", City = "mersin"},
                new Customer{Id = 2 ,FirstName = "majd",LastName="shrabati", City = "konya"},
                new Customer{Id = 3 ,FirstName = "abdulla",LastName="alikaj", City = "isparta"},
                new Customer{Id = 4 ,FirstName = "bashir",LastName="manafihi", City = "mersin"},
                new Customer{Id = 5 ,FirstName = "ibrahim",LastName="alzamel", City = "istanbul"},
            };
        }

        List<Customer> customers;

        public List<Customer> GetAll()
        {

            // veriTabanına bağlan
            return customers; 
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }
        public void Update(Customer customer)
        {
            //update işlemleri 
        }
        public void Delet(Customer customer)
        {
            customers.Remove(customer);
        }




    }
}
