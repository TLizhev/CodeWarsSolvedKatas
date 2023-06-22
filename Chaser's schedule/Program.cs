using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int Solve(string s)
    {
        var max = 0;
        var sum = 0;
        var value = 0;
        var list = new List<char>() { 'a', 'e', 'o', 'u', 'i' };
        var subStrings = s.Split(new char[] { 'a', 'e', 'o', 'u', 'i' }).ToList();

        foreach (var sub in subStrings)
        {
            for (int i = 0; i < sub.Length; i++)
            {
                value = sub[i] - 96;
                sum += value;
            }

            if (max < sum)
            {
                max = sum;
            }

            sum = 0;
        }

        return max;
    }
}