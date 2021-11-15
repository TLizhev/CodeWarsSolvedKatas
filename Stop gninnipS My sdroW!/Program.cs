using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

public class Kata
{
    public static string SpinWords(string sentence)
    {
        StringBuilder sb = new StringBuilder();
        string word = sentence;
        string[] arr = word.Split();
        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i].Length > 4)
            {

                foreach (var item in arr[i].Reverse())
                {
                    sb.Append(item);
                }
                sb.Append(" ");
            }
            else
            {

                sb.Append(arr[i]).Append(" ");
            }
        }
        return sb.ToString().TrimEnd();
    }
}