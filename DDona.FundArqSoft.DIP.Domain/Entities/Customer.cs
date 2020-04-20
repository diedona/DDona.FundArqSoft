using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.FundArqSoft.DIP.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int? Trust { get; set; }

        public Customer()
        {
            Id = Guid.NewGuid();
        }

        public Customer(string name, string email, int? trust) : this()
        {
            Name = name;
            Email = email;
            Trust = trust;
        }
    }
}
