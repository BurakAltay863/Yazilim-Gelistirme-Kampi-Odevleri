using System;

namespace DersTekrarı
{
    class Customer
    {
        public Customer(int id, string firstName, string lastName)
        {
            Id = id;
            FirstNme = firstName;
            LastName = lastName;
        }

        public Customer()
        {

        }
        public int Id { get; set; }

        public string FirstNme { get; set; }

        public string LastName { get; set; }
    }
}
