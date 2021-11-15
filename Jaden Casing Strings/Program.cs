using System;
using System.Text;
public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        string[] sentence = phrase.Split();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < sentence.Length; i++)
        {
            char[] arr = sentence[i].ToCharArray();
            sb.Append(arr[0].ToString().ToUpper());
            for (int j = 1; j < arr.Length; j++)
            {
                sb.Append(arr[j]);
            }
            sb.Append(" ");
        }
        return (sb.ToString().TrimEnd());

    }
}