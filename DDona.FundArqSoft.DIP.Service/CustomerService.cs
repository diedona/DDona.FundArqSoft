using DDona.FundArqSoft.DIP.Domain.Entities;
using DDona.FundArqSoft.DIP.Domain.Repositories;
using DDona.FundArqSoft.DIP.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.FundArqSoft.DIP.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _CustomerRepository;
        private IList<string> _Errors;

        public IReadOnlyList<string> Errors => new List<string>(_Errors).AsReadOnly();

        public CustomerService(ICustomerRepository customerRepository)
        {
            _CustomerRepository = customerRepository;
            _Errors = new List<string>();
        }

        public bool Save(Customer customer)
        {
            if (!Validate(customer))
            {
                return false;
            }

            return _CustomerRepository.SaveCustomer(customer);
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

        public IList<Customer> GetAll()
        {
            return _CustomerRepository.GetAll();
        }

        private void AddError(string error)
        {
            _Errors.Add(error);
        }
    }
}
