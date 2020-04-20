using DDona.FundArqSoft.DIP.Domain.Entities;
using DDona.FundArqSoft.DIP.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.FundArqSoft.DIP.Infra
{
    public class CustomerRepository : ICustomerRepository
    {
        private IList<Customer> _Customers;

        public CustomerRepository()
        {
            _Customers = new List<Customer>();
        }

        public bool SaveCustomer(Customer customer)
        {
            _Customers.Add(customer);
            return true;
        }

        public IList<Customer> GetAll()
        {
            return new List<Customer>(_Customers);
        }
    }
}
