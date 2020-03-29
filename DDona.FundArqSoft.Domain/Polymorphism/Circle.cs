using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.FundArqSoft.Domain.Polymorphism
{
    public class Circle : Drawing
    {
        private readonly double _Radius;

        public Circle(double radius)
        {
            _Radius = radius;
        }

        public override double Area()
        {
            return (Math.PI * Math.Pow(_Radius, 2));
        }

        public override string ExplainArea()
        {
            return $"(circle) {base.ExplainArea()}";
        }
    }
}
