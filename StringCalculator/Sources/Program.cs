using System;

namespace StringCalculator
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("1 = " + new Calculator("1").Value);
            Console.WriteLine("1 + 3 * 5 - 7 / 2 = " + new Calculator("1 + 3 * 5 - 7 / 2").Value);
            Console.WriteLine("1 + 3 * 5 * 2 - 7 / 2 / 2 = " + new Calculator("1 + 3 * 5 * 2 - 7 / 2 / 2").Value);
        }
    }
}
