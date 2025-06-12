namespace BehavioralPatterns.Interpreter
{
    // Expressão para subtração
    public class SubtractExpression : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        public SubtractExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret()
        {
            return _left.Interpret() - _right.Interpret();
        }
    }

}