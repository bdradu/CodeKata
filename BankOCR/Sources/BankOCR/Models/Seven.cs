namespace BankOCR.Models
{
    public class Seven : Digit
    {
        public override int Value { get; } = 7;
        public override string[] Lines { get; } = { " _ ", "  |", "  |" };
    }
}