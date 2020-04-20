using DDona.FundArqSoft.DIP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.FundArqSoft.DIP.Domain.Repositories
{
    public interface ICustomerRepository
    {
        IReadOnlyList<string> Errors { get; }

        bool SaveCustomer(Customer customer);
        bool Validate(Customer customer);
        IList<Customer> GetCustomers();
    }
}
