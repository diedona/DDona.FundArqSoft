using DDona.FundArqSoft.DIP.Domain.Repositories;
using DDona.FundArqSoft.DIP.Infra;
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
        }
    }
}
