using System;
using System.Numerics;

public class Kata
{
    public static string Add(string a, string b)
    {
        var num1 = BigInteger.Parse(a);
        var num2 = BigInteger.Parse(b);
        var result = num1 + num2;
        return result.ToString();
    }
}