using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int , decimal , float , enum , boolean  : == value types ==
            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number2 = 100; 
           // Console.WriteLine("number1 = " + number1);  //??

            //arrays , class , interface   : == reference types ==
            int[] numbers1 = new int[] { 1, 2, 3 };
            int[] numbers2 = new int[] { 10, 20, 30 };
            numbers1 = numbers2; 
            numbers1[0] = 1000;
          //  Console.WriteLine("numbers1[0] =" + numbers1[0]);


            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "ibrahim";
            person2 = person1;
            person1.FirstName = "Nermin";
           // Console.WriteLine(person2.FirstName);//??


            Customer customer = new Customer();
            customer.FirstName = "abdullah";
            customer.CreditCardNumber = "1234567890";



            Employee employee = new Employee();
            employee.FirstName = "mceit";
            Person person3 = customer;
            customer.FirstName = "bashir";
            //Console.WriteLine(person3.FirstName);
            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(person1);  //Add(Person person )
            personManager.Add(customer); //Add(Person customer )
            personManager.Add(employee); //Add(Person employee )

        }
    }
}
