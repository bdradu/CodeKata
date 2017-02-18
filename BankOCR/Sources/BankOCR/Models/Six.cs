namespace BankOCR.Models
{
    public class Six : Digit
    {
        public override int Value { get; } = 6;
        public override string[] Lines { get; } = {" _ ", "|_ ", "|_|"};
    }
}