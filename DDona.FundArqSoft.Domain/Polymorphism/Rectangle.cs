using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.FundArqSoft.Domain.Polymorphism
{
    public class Rectangle : Drawing
    {
        private readonly double _Height;
        private readonly double _Width;

        public Rectangle(double height, double width)
        {
            _Height = height;
            _Width = width;
        }

        public override double Area()
        {
            return (_Width * _Height);
        }

        public override string ExplainArea()
        {
            return $"(rectangle) {base.ExplainArea()}";
        }
    }
}
