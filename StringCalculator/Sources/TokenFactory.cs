using StringCalculator.Models;

namespace StringCalculator
{
    public class TokenFactory
    {
        public IToken Create(string expression)
        {
            switch (expression)
            {
                case "+": return new AdditionToken();
                case "-": return new SubtractionToken();
                case "*": return new MultiplicationToken();
                case "/": return new DivisionToken();
                default: return new OperandToken(expression);
            }
        }

        public IToken Create(int expression)
        {
            return new OperandToken(expression);
        }
    }
}
