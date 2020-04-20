using Microsoft.Extensions.DependencyInjection;
using System;

namespace DDona.FundArqSoft.DIP.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = Services.ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetService<ProgramApp>().Run();
        }
    }
}
