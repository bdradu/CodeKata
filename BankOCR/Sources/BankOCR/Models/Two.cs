namespace BankOCR.Models
{
    public class Two : Digit
    {
        public override int Value { get; } = 2;
        public override string[] Lines { get; } = {" _ ", " _|", "|_ "};
    }
}