namespace BankOCR.Models
{
    public class Nine : Digit
    {
        public override int Value { get; } = 9;
        public override string[] Lines { get; } = { " _ ", "|_|", " _|" };
    }
}