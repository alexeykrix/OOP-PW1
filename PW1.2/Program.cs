class Program
{
    delegate int RandomNumberDelegate();

    static void Main(string[] args)
    {
        RandomNumberDelegate[] randomDelegates = new RandomNumberDelegate[5];
        Random random = new Random();
        for (int i = 0; i < randomDelegates.Length; i++)
        {
            randomDelegates[i] = () => random.Next(1, 101);
        }

        double average = CalculateAverage(randomDelegates);

        Console.WriteLine($"The average of the random numbers is {average}");
        Console.ReadLine();
    }

    static double CalculateAverage(RandomNumberDelegate[] delegates)
    {
        int sum = 0;
        foreach (RandomNumberDelegate del in delegates)
        {
            sum += del();
        }

        return (double)sum / delegates.Length;
    }
}
