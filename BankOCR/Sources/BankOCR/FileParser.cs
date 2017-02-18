using System.Collections.Generic;
using System.IO;
using BankOCR.Models;

namespace BankOCR
{
    public class FileParser
    {
        public IEnumerable<Number> Parse(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            var digitFactory = new DigitFactory();

            for (var row = 0; row < lines.Length; row += 4)
            {
                var digits = new List<Digit>();

                for (var col = 0; col < 27; col += 3)
                {
                    var digitLines = new[]
                    {
                        lines[row].Substring(col, 3),
                        lines[row + 1].Substring(col, 3),
                        lines[row + 2].Substring(col, 3)
                    };

                    digits.Add(digitFactory.CreateDigit(digitLines));
                }

                yield return new Number(digits);
            }
        }
    }
}
