using DDona.FundArqSoft.DIP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.FundArqSoft.DIP.Domain.Repositories
{
    public interface ICustomerRepository
    {
        bool SaveCustomer(Customer customer);
        IList<Customer> GetAll();
    }
}
