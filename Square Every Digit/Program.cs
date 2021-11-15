using System;
using System.Text;

public class Kata
{
    public static int SquareDigits(int n)
    {
        StringBuilder sb = new StringBuilder();

        string nums = n.ToString();
        foreach (var item in nums)
        {
            sb.Append(Math.Pow(int.Parse(item.ToString()), 2));
        }
        return int.Parse(sb.ToString());
    }
}