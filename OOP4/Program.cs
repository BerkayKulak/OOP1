using System;

namespace OOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.ID = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer
            {
                ID = 2,
                City = "İstanbul",
                FirstName = "Derin",
                LastName = "Demiroğ"

            };

            Console.WriteLine(customer2.FirstName);
            
        }
    }

    
    
}