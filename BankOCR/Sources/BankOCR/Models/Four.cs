namespace BankOCR.Models
{
    public class Four : Digit
    {
        public override int Value { get; } = 4;
        public override string[] Lines { get; } = {"   ", "|_|", "  |"};
    }
}