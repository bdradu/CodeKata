namespace BankOCR.Models
{
    public class UnknownDigit : Digit
    {
        public override int Value { get; } = -1;
        public override string[] Lines { get; } = {};
        public override string Print() => "?";
    }
}