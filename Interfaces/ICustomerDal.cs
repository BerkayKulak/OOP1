﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }
    }

    class OracleCustorerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Delete");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Update");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
