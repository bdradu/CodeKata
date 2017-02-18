namespace BankOCR.Models
{
    public class Zero : Digit
    {
        public override int Value { get; } = 0;
        public override string[] Lines { get; } = {" _ ", "| |", "|_|"};
    }
}