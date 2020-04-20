using DDona.FundArqSoft.DIP.Domain.Entities;
using System.Collections.Generic;

namespace DDona.FundArqSoft.DIP.Service.Interfaces
{
    public interface ICustomerService
    {
        IReadOnlyList<string> Errors { get; }

        bool Save(Customer customer);
        bool Validate(Customer customer);
        IList<Customer> GetAll();
    }
}