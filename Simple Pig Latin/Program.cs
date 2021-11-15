using System;
using System.Text;
using System.Linq;

public class Kata
{
    public static string PigIt(string str)
    {
        StringBuilder sb = new StringBuilder();
        string[] input = str.Split();
        char[] signs = { '!', '.', '?' };
        for (int i = 0; i < input.Length; i++)
        {
            if (!signs.Contains(input[i].First()))
            {
                var result = string.Join("", input[i], $"{input[i][0]}ay").Remove(0, 1);

                sb.Append(result + " ");
            }
            else
            {
                sb.Append(input[i]);
            }

        }
        return sb.ToString().Trim();
    }
}