using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarBucksCustomer(new MernisServideAdapter());
            customerManager.Save(new Entities.Customer { DateOfBirth = new System.DateTime(1985, 1, 6),
                FirstName = "Berkay",LastName = "Kulak",NationalityId = "37682268800" });
           
        }
    }
}
