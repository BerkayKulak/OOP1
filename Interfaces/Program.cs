using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();

            //NewMethod1();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustorerDal()
            };

            foreach (var item in customerDals)
            {
                item.Add();
            }


        }

        private static void NewMethod1()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustorerDal());
        }

        private static void NewMethod()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                firstName = "Derin",
                lastName = "Demiroğ",
                Address = "Ankara"
            };
            personManager.Add(customer);

            Student student = new Student
            {
                Id = 1,
                firstName = "Engin",
                lastName = "Demirop",
                Departmant = "Customer"
            };
            personManager.Add(student);
        }


    }

    interface IPerson
    {
        int Id { get; set; }
        string firstName { get; set; }
        string lastName  { get; set; }
        
    }

    class Customer : IPerson
    {
        public int Id { get ; set; }
        public string firstName { get ; set; }
        public string lastName { get; set ; }
        public string Address { get; set; }

    }

    class Student : IPerson
    {
        public int Id { get ; set ; }
        public string firstName { get ; set ; }
        public string lastName { get ; set ; }
        public string Departmant { get; set; }
    }

    class Workers : IPerson
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("added " + person.firstName);
        }
    }
}
