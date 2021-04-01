using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using ServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Adapters
{
    class MernisServideAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.Nationa)

            
        }
    }
}
