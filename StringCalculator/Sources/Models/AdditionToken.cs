namespace StringCalculator.Models
{
    public class AdditionToken : IToken
    {
        public IToken Left { get; set; }
        public IToken Right { get; set; }

        public int Value => Left.Value + Right.Value;
    }
}
