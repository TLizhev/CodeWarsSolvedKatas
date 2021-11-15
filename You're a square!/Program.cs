using System;

public class Kata
{
    public static bool IsSquare(int n)
    {
        if (n < 0)
        {
            return false;
        }
        int num = (int)Math.Sqrt(n);
        if (Math.Sqrt(n) % num == 0 || n == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}