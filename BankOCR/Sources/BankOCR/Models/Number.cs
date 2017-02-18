using System.Collections.Generic;
using System.Linq;

namespace BankOCR.Models
{
    public class Number
    {
        public IEnumerable<Digit> Digits { get; }

        public bool IsValid => Digits.All(x => x.Value != -1);

        public Number(IEnumerable<Digit> digits)
        {
            Digits = digits;
        }

        public string Print() => string.Join("", Digits.Select(d => d.Print()));

        public int CalculateChecksum()
        {
            return Digits.Reverse().Select((d, i) => d.Value * (i + 1)).Sum() % 11;
        }
    }
}
