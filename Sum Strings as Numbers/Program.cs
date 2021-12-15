using System;
using System.Numerics;
public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        if (a == string.Empty)
        {
            return BigInteger.Parse(b).ToString();
        }
        if (b == string.Empty)
        {
            return BigInteger.Parse(a).ToString();
        }
        return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();

    }
}