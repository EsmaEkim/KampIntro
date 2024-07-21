using System;

namespace ReferanceType
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,deciaml,float,boolean => value types
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("sayı birin değeri: "+sayi1);


            //array,class,interface.. =>referance types
            int[] sayilar1 = new int[] {1,2,3 };
            int[] sayilar2 = new int[] {10,20,30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("sayılar1'in birinci değeri: "+sayilar1[0]);

            Console.WriteLine("----------------------------------------------------");

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Esma";
            person2.FirstName = "Eylül";
            person1 = person2;
            person2.FirstName = "Sonbahar";
            person1.FirstName = "Aşure";
            person2 = person1;
            Console.WriteLine("person1s firstname: "+person1.FirstName);

            Console.WriteLine("----------------------------------------------------");




            Customer customer = new Customer();
            customer.FirstName = "Kayra";
            customer.CreditCardNumber = "123456678901";
            Person person3 = customer;
            Console.WriteLine("person3s firstname: " + person3.FirstName);
            Console.WriteLine("person3s creditcardnummer: "+((Customer)person3).CreditCardNumber);



            Console.WriteLine("----------------------------------------------------");


            Employee employee = new Employee();
            employee.FirstName = "Zehra";
            Person person4 = employee;
            Console.WriteLine("person4s firstname: "+person4.FirstName);


            Console.WriteLine("----------------------------------------------------");

            PersonManager personManager = new PersonManager();
            personManager.Add(person1);
            personManager.Add(customer);
            personManager.Add(employee);


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
        public int EmplopyeeId { get; set; }

    }
    class PersonManager
    {
        public void Add(Person person) //base classes
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
