using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Id= " + customer.id + ": Name= " + customer.name + " Added!" );
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Id= " + customer.id + ": Name= " + customer.name + " Deleted!");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Id= " + customer.id + ": Name= " + customer.name + " Updated!");
        }
    }
}
