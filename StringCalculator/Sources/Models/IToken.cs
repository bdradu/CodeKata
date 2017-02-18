namespace StringCalculator.Models
{
    public interface IToken
    {
        IToken Left { get; set; }
        IToken Right { get; set; }
        int Value { get; }
    }
}
