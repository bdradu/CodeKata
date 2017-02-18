using System.Collections.Generic;
using System.Linq;
using BankOCR.Models;

namespace BankOCR
{
    public class DigitFactory
    {
        private readonly IEnumerable<Digit> _digits = new Digit[]
        {
            new Zero(), new One(), new Two(), new Three(), new Four(), new Five(), new Six(), new Seven(), new Eight(),
            new Nine()
        };

        public Digit CreateDigit(string[] lines)
        {
            return _digits.FirstOrDefault(d => d.Lines.Zip(lines, (l, r) => l == r).All(g => g)) ?? new UnknownDigit();
        }
    }
}
