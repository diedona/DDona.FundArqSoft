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
        private IList<string> _Errors;

        public IReadOnlyList<string> Errors => new List<string>(_Errors).AsReadOnly();

        public CustomerRepository()
        {
            _Customers = new List<Customer>();
            _Errors = new List<string>();
        }

        public bool SaveCustomer(Customer customer)
        {
            ClearErrors();

            if (!Validate(customer))
            {
                AddError("Invalid customer");
                return false;
            }

            _Customers.Add(customer);
            return true;
        }

        public bool Validate(Customer customer)
        {
            if (customer.Email.Contains("@"))
            {
                return true;
            }
            else
            {
                AddError($"{customer.Email} não contêm @");
                return false;
            }
        }

        public IList<Customer> GetCustomers()
        {
            return new List<Customer>(_Customers);
        }

        private void ClearErrors()
        {
            _Errors.Clear();
        }

        private void AddError(string error)
        {
            _Errors.Add(error);
        }
    }
}
