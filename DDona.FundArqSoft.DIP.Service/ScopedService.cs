using DDona.FundArqSoft.DIP.Domain.Entities;
using DDona.FundArqSoft.DIP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.FundArqSoft.DIP.Service
{
    public class ScopedService
    {
        public ITransientScope Transient { get; }
        public IScopedScope Scoped { get; }
        public ISingletonScope Singleton { get; }
        public ISingletonInstanceScope SingletonInstance { get; }

        public ScopedService(ITransientScope transient, IScopedScope scoped, ISingletonScope singleton, ISingletonInstanceScope singletonInstance)
        {
            Transient = transient;
            Scoped = scoped;
            Singleton = singleton;
            SingletonInstance = singletonInstance;
        }

        public override string ToString()
        {
            return $"Transient: {Transient.Id}\nScoped: {Scoped.Id}\nSingleton: {Singleton.Id}\nSingleton Instance: {SingletonInstance.Id}";
        }
    }
}
