using System;
public class Sum
{
    public int GetSum(int a, int b)
    {
        if (a == b)
        {
            return a;
        }
        int sum = 0;
        for (var i = Math.Min(a, b); i <= Math.Max(a, b); i++)
        {
            sum += i;
        }
        return sum;
    }
}