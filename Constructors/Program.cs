using System;

namespace Constructors //yapıcı blok
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1,FirstName="Esma",LastName="Ekim",City="Mersin"};
            Customer customer2 = new Customer(2,"Kayra","Ekim","Mersin");
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Zehra";
            customer3.LastName = "Yılmaz";
            customer3.City = "Mersin";

            Console.WriteLine("customer1s firstname: "+customer1.FirstName);
        }
        
    }
    class Customer
    {
        //default constructor
        public Customer()
        {

        }
        public Customer(int id,string firstname, string lastname, string city)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
