public class FibonacciAverageCalculator
{
    public double CalculateAverage(int[] series)
    {
        if (series.Length == 0)
        {
            return 0;
        }
        int sum = 0;
        for (int i = 0; i < series.Length; i++)
        {
            sum += series[i];
        }
        return (double)sum / series.Length;
    }
}
