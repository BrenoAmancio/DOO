namespace BehavioralPatterns.Interpreter
{

    // Expressão para adição
    public class AddExpression : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        public AddExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret()
        {
            return _left.Interpret() + _right.Interpret();
        }
    }
}