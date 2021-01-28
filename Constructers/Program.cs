using System;

namespace Constructers
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "erhan", LastName = "erdogan", City = "Eskişehir" };
            Customer customer2 = new Customer(2, "erhan", "erdogan", "esk");
            Console.WriteLine(customer2.FirstName);
            
             Method(1,"asfas","fasasf");

        }

        
        static void Method(int id, string firstName, string city)
        {

        }
    }

    class Customer
    {
        //default constructor
        public Customer()
        {

        }

        //method parametreleri camelCase yazılır
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
