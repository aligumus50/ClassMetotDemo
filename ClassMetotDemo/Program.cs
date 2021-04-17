using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                id = 1,
                name = "mehmet",
                surname = "ay",
                age = 35,
                country = "Turkey"
                
            };

            Customer customer2 = new Customer
            {
                id = 2,
                name = "ahmet",
                surname = "aya",
                age = 27,
                country = "Turkey"

            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Update(customer1);
            customerManager.Delete(customer1);

            Console.WriteLine("******************************************");

            customerManager.Add(customer2);
            customerManager.Update(customer2);
            customerManager.Delete(customer2);

            Console.ReadLine();
        }
    }
}
