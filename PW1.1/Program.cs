class Program
{
    delegate double ArithmeticOperation(double a, double b);

    static void Main(string[] args)
    {
        ArithmeticOperation add = (a, b) => a + b;
        ArithmeticOperation subtract = (a, b) => a - b;
        ArithmeticOperation multiply = (a, b) => a * b;
        ArithmeticOperation divide = (a, b) => {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        };

        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter the arithmetic operation to perform (+, -, *, /): ");
        string operation = Console.ReadLine() ?? "";

        try
        {
            double result;
            switch (operation)
            {
                case "+":
                    result = add(num1, num2);
                    break;
                case "-":
                    result = subtract(num1, num2);
                    break;
                case "*":
                    result = multiply(num1, num2);
                    break;
                case "/":
                    result = divide(num1, num2);
                    break;
                default:
                    throw new ArgumentException("Invalid operation.");
            }
            Console.WriteLine("Result: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.ReadLine();
    }
}