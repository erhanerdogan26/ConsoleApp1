using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal ,float,enum ,boolean value types

            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("sayı 1 :" + sayi1);

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine(sayilar1[0]);

            //arrays, class,interface... referance types

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Erhan";
            person2 = person1;
            person1.FirstName = "Ece";


            Customer customer = new Customer();
            customer.FirstName = "Eroo";
            Employee employee = new Employee();

            Person person3 = new Person();
            person3 = customer;
            Console.WriteLine(person3);

            Console.WriteLine(((Customer)person3).CreditCardNumber);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }

    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

}
