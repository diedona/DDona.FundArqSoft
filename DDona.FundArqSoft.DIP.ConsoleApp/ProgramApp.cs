using DDona.FundArqSoft.DIP.Domain.Entities;
using DDona.FundArqSoft.DIP.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.FundArqSoft.DIP.ConsoleApp
{
    public class ProgramApp
    {
        private readonly ICustomerRepository _customerRepository;

        public ProgramApp(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Run()
        {
            Console.WriteLine("Hello there, i'm App.cs");

            Customer newCust = new Customer("Diego", "diedona@gmail.com", null);
            _customerRepository.SaveCustomer(newCust);

            Customer newCust2 = new Customer("Joseph", "joseph.gmail.com", null);
            _customerRepository.SaveCustomer(newCust2);

            var customersAdded = _customerRepository.GetCustomers();
            var errors = _customerRepository.Errors;

            Console.WriteLine();
            Console.WriteLine("--- Customers: ---");
            foreach (var customer in customersAdded)
            {
                Console.WriteLine($"{customer.Name} - {customer.Email}");
            }

            Console.WriteLine();
            Console.WriteLine("--- Errors: ---");
            foreach (var err in errors)
            {
                Console.WriteLine(err);
            }

            Console.WriteLine();
            Console.WriteLine("End..");
        }
    }
}
