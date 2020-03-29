using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.FundArqSoft.Domain.Polymorphism
{
    public abstract class Drawing
    {
        public abstract double Area();

        public virtual string ExplainArea()
        {
            return $"Drawing area is {this.Area()}";
        }
    }
}
