using DDona.FundArqSoft.DIP.Domain.Repositories;
using DDona.FundArqSoft.DIP.Infra;
using DDona.FundArqSoft.DIP.Service;
using DDona.FundArqSoft.DIP.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.FundArqSoft.DIP.ConsoleApp.Middleware
{
    public static class MiddlewareRegistration
    {
        public static void MiddlewareRegister(this IServiceCollection services)
        {
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<ICustomerService, CustomerService>();
        }
    }
}
