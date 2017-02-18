namespace BankOCR.Models
{
    public class Eight : Digit
    {
        public override int Value { get; } = 8;
        public override string[] Lines { get; } = { " _ ", "|_|", "|_|" };
    }
}