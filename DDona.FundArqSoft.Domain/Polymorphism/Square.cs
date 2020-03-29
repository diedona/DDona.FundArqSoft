using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.FundArqSoft.Domain.Polymorphism
{
    public class Square : Drawing
    {
        private readonly double _Length;

        public Square(double length)
        {
            _Length = length;
        }

        public override double Area()
        {
            return Math.Pow(_Length, 2);
        }

        public override string ExplainArea()
        {
            return $"(square) {base.ExplainArea()}";
        }
    }
}
