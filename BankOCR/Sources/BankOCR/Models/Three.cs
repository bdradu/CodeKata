namespace BankOCR.Models
{
    public class Three : Digit
    {
        public override int Value { get; } = 3;
        public override string[] Lines { get; } = {" _ ", " _|", " _|"};
    }
}