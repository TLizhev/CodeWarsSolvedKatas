using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
public class Kata
{
    public static string Factorial(int n)
    {

        if (n < 0)
        {
            Console.WriteLine(0); ;
        }

        List<int> list = new List<int> { 1 };

        int carry = 0;
        int prod = 0;
        int digit = 0;
        for (var x = 2; x <= n; x++)
        {
            // multiply each digit
            carry = 0;
            for (var i = 0; i < list.Count; i++)
            {
                prod = list[i] * x + carry;
                digit = prod % 10;
                carry = prod / 10;
                list[i] = digit;
                if (i == list.Count - 1)
                {
                    while (carry > 0)
                    {
                        digit = carry % 10;
                        carry = carry / 10;
                        list.Add(digit);
                    }
                    break;
                }
            }

        }
        StringBuilder sb = new StringBuilder();
        list.Reverse();
        foreach (var item in list)
        {
            sb.Append(item);
        }
        return sb.ToString();
    }
}