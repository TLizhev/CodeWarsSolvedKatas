using System;
using System.Numerics;
public static class Kata
{
    public static string sumStrings(string a, string b)
    {
        return a == string.Empty ? BigInteger.Parse(b).ToString() :
            b == string.Empty ? BigInteger.Parse(a).ToString() : (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
    }
}