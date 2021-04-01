using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using ServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public object MernisServiceReference { get; private set; }

        public bool CheckIfRealPerson(Customer customer)
        {

            return true;

        }
    }
}
