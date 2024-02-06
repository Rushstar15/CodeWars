using System;
namespace SumofthefirstnthtermofSeries
{
    public static string seriesSum(int n)
    {
        if (n == 0)
        {
            return "0.00";
        }

        double sum = 0.0;

        for (int i = 0; i < n; i++)
        {
            sum += 1 / (1.0 + 3 * i);
        }

        return sum.ToString("0.00");
    }
}
