namespace EvaluatePostfix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter an infix expression: ");
            string infix = Console.ReadLine();

 
            InfixToPostfix infixToPostfix = new InfixToPostfix();
            string postfix = infixToPostfix.Infix_To_Postfix(ref infix);
            Console.WriteLine("Infix: {0}", infix);
            Console.WriteLine("Postfix: {0}", postfix);

            EvalPostfix evalPostfix = new EvalPostfix();
            int result = evalPostfix.evaluate(postfix);
            Console.WriteLine("Evaluation Result: {0}", result);
            
            Console.WriteLine();
        }
        
    }

}
