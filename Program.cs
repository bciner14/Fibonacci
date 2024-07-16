using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Lütfen Fibonacci serisinin derinliğini giriniz: ");
        int depth;
        while (!int.TryParse(Console.ReadLine(), out depth) || depth <= 0)
        {
            Console.Write("Geçerli bir pozitif tamsayı giriniz: ");
        }

        FibonacciCalculator fibonacciCalculator = new FibonacciCalculator();
        int[] series = fibonacciCalculator.CalculateFibonacciSeries(depth);

        FibonacciAverageCalculator averageCalculator = new FibonacciAverageCalculator();
        double average = averageCalculator.CalculateAverage(series);

        Console.WriteLine("Fibonacci serisi: ");
        foreach (int num in series)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine($"\nFibonacci serisinin ortalaması: {average}");
    }
}
