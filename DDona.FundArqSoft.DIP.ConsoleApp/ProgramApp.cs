using DDona.FundArqSoft.DIP.Domain.Entities;
using DDona.FundArqSoft.DIP.Domain.Repositories;
using DDona.FundArqSoft.DIP.Service;
using DDona.FundArqSoft.DIP.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.FundArqSoft.DIP.ConsoleApp
{
    public class ProgramApp
    {
        private readonly ICustomerService _CustomerService;
        private readonly ShowScope _ShowScope;

        public ProgramApp(ICustomerService customerService, ShowScope showScope)
        {
            _CustomerService = customerService;
            _ShowScope = showScope;
        }

        public void Run()
        {
            _ShowScope.ShowScopeConsole();

            Console.WriteLine("Hello there, i'm App.cs");
            Dictionary<Customer, bool> customerStatus = new Dictionary<Customer, bool>();

            Customer newCust1 = new Customer("Diego", "diedona@gmail.com", null);
            customerStatus.Add(newCust1, _CustomerService.Save(newCust1));

            Customer newCust2 = new Customer("Renato", "renato@google.com", null);
            customerStatus.Add(newCust2, _CustomerService.Save(newCust2));

            Customer newCust3 = new Customer("Joseph", "joseph.gmail.com", null);
            customerStatus.Add(newCust3, _CustomerService.Save(newCust3));

            var allCustomers = new List<Customer>() { newCust1, newCust2, newCust3 };
            var errors = _CustomerService.Errors;

            Console.WriteLine();
            Console.WriteLine("--- Customers in memory: ---");
            foreach (var customer in allCustomers)
            {
                Console.WriteLine($"{IsCustomerOk(customer, customerStatus)} {customer.Name} - {customer.Email}");
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

        private string IsCustomerOk(Customer customer, Dictionary<Customer, bool> customerStatus)
        {
            if (customerStatus.ContainsKey(customer))
            {
                return customerStatus[customer] ? "OK" : "FAILED";
            }
            else
            {
                return "~MISSING?~";
            }
        }
    }
}
