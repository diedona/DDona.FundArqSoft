using DDona.FundArqSoft.Domain.Polymorphism;
using System;

namespace DDona.FundArqSoft.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Drawing circle = new Circle(5);
            Drawing square = new Square(6);
            Drawing rectangle = new Rectangle(2, 6);

            Drawing[] drawings = new Drawing[] { circle, square, rectangle };
            foreach (Drawing drawing in drawings)
            {
                Console.WriteLine(drawing.ExplainArea());
            }
        }
    }
}
