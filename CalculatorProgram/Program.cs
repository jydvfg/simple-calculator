namespace CalculatorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1;
                double num2;
                double result = 0;

                Console.WriteLine("##################");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("##################");

                Console.Write("Enter first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operator ( + | - | * | / ): ");
                char option = Convert.ToChar(Console.ReadLine());
                switch (option)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                }
                Console.WriteLine("Result: " + Convert.ToString(result));


                Console.WriteLine("Would you like to continue: (Y/N)");
            } while (Convert.ToChar(Console.ReadLine().ToUpper()) == 'Y');
            Console.WriteLine("Bye");
            Console.ReadKey();
        }

    }
}
