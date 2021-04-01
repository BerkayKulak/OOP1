using System;

namespace Inheritances
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Customer customer = new Customer();
            customer.FirstName = "Berkay";
            customer.ID = 5;
            customer.LastName = "Kulak";
            customer.City = "Burdur";

            Student student = new Student();
            student.FirstName = "Berkay";
            student.ID = 5;
            student.LastName = "Kulak";
            student.Departmant = "PC";*/

            Person[] persons = new Person[3]
            {
                new Customer{ FirstName = "Engin"},new Student{FirstName = "Derin"},new Person{FirstName = "Ali"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }


        }
    }

    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }      
    }

    class Customer : Person
    {
        public string City { get; set; }

    }

    class Student : Person
    {
        public string Departmant { get; set; }

    }
}
