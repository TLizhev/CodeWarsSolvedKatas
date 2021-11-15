using System;
public class DigPow
{
    public static long digPow(int n, int p)
    {

        Console.WriteLine(n);
        Console.WriteLine(p);

        int sum = 0;
        var inputString = n.ToString().ToCharArray();
        for (int i = 0; i < inputString.Length; i++, p++)
        {
            var digit = (int)Math.Pow(int.Parse(inputString[i].ToString()), p);
            sum += digit;
        }


        if (sum % n == 0)
        {

            int result = sum / n;

            return result;
        }
        else
        {
            return -1;
        }
    }
}