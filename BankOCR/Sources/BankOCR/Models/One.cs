namespace BankOCR.Models
{
    public class One : Digit
    {
        public override int Value { get; } = 1;
        public override string[] Lines { get; } = { "   ", "  |", "  |" };
    }
}