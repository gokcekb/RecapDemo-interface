using System;

namespace AlıştırmaClasses
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
            customer.Id = 1;
            customer.FirstName = "GÖKÇE";
            customer.LastName = "KÜÇÜKBAYRAM";

            Customer customer2 = new Customer
            {
                Id = 2,City="Samsun",FirstName="METE",LastName="DEMİR"

            };
            Console.WriteLine(customer2.FirstName);

              


        }
    }

    }
