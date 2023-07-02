using System.Linq;
using System;

public class Kata
{
    public static int FindEvenIndex(int[] arr)
    {
        if (arr.Length == 0)
            return 0;
        for (int i = 0; i < arr.Length; i++)
        {
            var left = arr.Take(i).Sum(x => x);
            var right = arr.TakeLast(arr.Length - i).Sum(x => x) - arr[i];
            if (left == right)
            {
                return i;
            }
            left = right = 0;
        }

        return -1;
    }
}