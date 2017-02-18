namespace BankOCR.Models
{
    public class Five : Digit
    {
        public override int Value { get; } = 5;
        public override string[] Lines { get; } = {" _ ", "|_ ", " _|"};
    }
}