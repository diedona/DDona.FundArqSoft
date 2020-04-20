using DDona.FundArqSoft.DIP.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.FundArqSoft.DIP.ConsoleApp
{
    public class ShowScope
    {
        private readonly ScopedService _Scoped1;
        private readonly ScopedService _Scoped2;

        public ShowScope(ScopedService scoped1, ScopedService scoped2)
        {
            _Scoped1 = scoped1;
            _Scoped2 = scoped2;
        }

        public void ShowScopeConsole()
        {
            Console.WriteLine(_Scoped1);
            Console.WriteLine("--");
            Console.WriteLine(_Scoped2);
        }
    }
}
