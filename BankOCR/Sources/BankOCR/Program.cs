using System;
using System.IO;

namespace BankOCR
{
    internal class Program
    {
        private static void Main()
        {
            var fileParser = new FileParser();
            var numbers = fileParser.Parse(Path.Combine(Directory.GetCurrentDirectory(), @"Data\OCR.txt"));

            foreach (var number in numbers)
            {
                var value = number.Print();
                var checksum = number.IsValid
                    ? number.CalculateChecksum() == 0 ? string.Empty : "ERR"
                    : "ILL";

                Console.WriteLine($"{value} {checksum}");
            }
        }
    }
}
