using System;
using System.Linq;
public class Kata
{
    public static int FindShort(string s)
    {
        var min = int.MaxValue;
        foreach (var item in s.Split().ToArray())
        {
            if (item.Length < min)
            {
                min = item.Length;
            }
        }
        return min;
    }
}