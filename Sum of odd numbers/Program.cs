using System;
public static class Kata
{
    public static long rowSumOddNumbers(long n)
    {
        var sum = 1;
        var rowSum = 0;
        for (var i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (n == i)
                {
                    rowSum += sum;
                }
                sum += 2;
            }
        }
        return rowSum;
    }
}