using System;

public class FibonacciCalculator
{
    public int[] CalculateFibonacciSeries(int depth)
    {
        if (depth <= 0)
        {
            throw new ArgumentException("Depth must be a positive integer.");
        }

        int[] series = new int[depth];
        if (depth > 0)
        {
            series[0] = 0;
        }
        if (depth > 1)
        {
            series[1] = 1;
        }
        for (int i = 2; i < depth; i++)
        {
            series[i] = series[i - 1] + series[i - 2];
        }
        return series;
    }
}
