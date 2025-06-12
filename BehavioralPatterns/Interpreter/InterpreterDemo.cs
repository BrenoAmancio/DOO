namespace BehavioralPatterns.Interpreter
{

    // Classe para demonstrar o uso
    public class InterpreterDemo
    {
        public static void Execute()
        {
            Console.WriteLine("\n=== INTERPRETER PATTERN ===");
            
            // Expressão: 5 + (10 - 3) = 12
            var expression = new AddExpression(
                new NumberExpression(5),
                new SubtractExpression(new NumberExpression(10), new NumberExpression(3))
            );

            Console.WriteLine($"Result: {expression.Interpret()}");
        }
    }

}
