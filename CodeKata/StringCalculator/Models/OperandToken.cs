namespace StringCalculator.Models
{
    public class OperandToken : IToken
    {
        public IToken Left { get; set; }
        public IToken Right { get; set; }
        public int Value { get; set; }

        public OperandToken(string value)
        {
            Value = int.Parse(value);
        }

        public OperandToken(int value)
        {
            Value = value;
        }
    }
}
