using DDona.FundArqSoft.DIP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.FundArqSoft.DIP.Domain.Entities
{
    public class Scope : IScopedScope, ISingletonInstanceScope, ISingletonScope, ITransientScope
    {
        public Guid Id { get; private set; }

        public Scope() : this(Guid.NewGuid())
        {
            
        }

        public Scope(Guid id)
        {
            Id = id;
        }
    }
}
