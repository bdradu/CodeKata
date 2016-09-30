using System;
using System.Linq;
using StringCalculator.Extensions;
using StringCalculator.Models;

namespace StringCalculator
{
    public class Calculator
    {
        public int Value { get; }

        public Calculator(string expression)
        {
            Value = Convert(expression);
        }

        private static int Convert(string expression)
        {
            var tokenFactory = new TokenFactory();
            return Normalize(expression).Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(tokenFactory.Create)
                .ToList()
                .Reduce(x => x is MultiplicationToken || x is DivisionToken)
                .Reduce(x => x is AdditionToken || x is SubtractionToken)
                .First()
                .Value;
        }

        private static string Normalize(string expression)
        {
            return "0 + " + expression;
        }
    }
}
