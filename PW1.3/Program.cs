class Program
{
    static void Main(string[] args)
    {
        Func<int, int, int, double> arithmeticMean = delegate (int a, int b, int c)
        {
            return (a + b + c) / 3.0;
        };

        int arg1 = 10;
        int arg2 = 20;
        int arg3 = 30;
        double result = arithmeticMean(arg1, arg2, arg3);
        Console.WriteLine("The arithmetic mean of {0}, {1}, and {2} is {3}.", arg1, arg2, arg3, result);
        Console.ReadKey();
    }
}