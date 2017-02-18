namespace BankOCR.Models
{
    public abstract class Digit
    {
        public abstract int Value { get; }
        public abstract string[] Lines { get; }
        public virtual string Print() => Value.ToString();
    }
}
