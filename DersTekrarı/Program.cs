using DersTekrarı;
using System;
using System.Collections.Generic;
using System.Text;

namespace Construcutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstNme = "Burak", LastName = "altay" };

            Customer customer2 = new Customer(2, "ali", "sevim");

            Customer customer3 = new Customer();

            customer3.Id = 3;
            customer3.FirstNme = "Hande";
            customer3.LastName = "hayran";




        }
    }
}
