using System;
using System.Globalization;
using System.Text;
using System.Threading;

public class StatisticsTest
{
    public static void PrintStatistics(double[] arr)
    {
        double min = GetMinValueOfArray(arr);
        Console.WriteLine("Min value={0,5}", min);

        double max = GetMaxElementOfArray(arr);
        Console.WriteLine("Max value={0,5}", max);

        double average = GetAverageValueOfArray(arr);
        Console.WriteLine("Average ={0,6}", average);
    }

    public static double GetMinValueOfArray(double[] arr)
    {
        int count = arr.Length;
        double min = double.MaxValue;

        for (int i = 0; i < count; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        return min;
    }

    public static double GetMaxElementOfArray(double[] arr)
    {
        int count = arr.Length;
        double max = double.MinValue;

        for (int i = 0; i < count; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }

    public static double GetAverageValueOfArray(double[] arr)
    {
        int count = arr.Length;
        double sum = 0;

        for (int i = 0; i < count; i++)
        {
            sum += arr[i];
        }

        double average = sum / count;

        return average;
    }

    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double[] arr = new double[] { 1, 2, 3, 4, 5, 6 };
        PrintStatistics(arr);
    }
}