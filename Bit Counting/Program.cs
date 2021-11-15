using System;

public class Kata
{
    public static int CountBits(int n)
    {
        var counter = 0;
        string binary = Convert.ToString(n, 2);
        foreach (var item in binary)
        {
            if (item == '1')
            {
                counter++;
            }
        }
        return counter;
    }
}