using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static List<string> Anagrams(string word, List<string> words)
    {

        Console.WriteLine();
        foreach (var item in words)
        {
            Console.WriteLine(item);
        }
        var anagrams = new List<string>();
        foreach (var item in words)
        {
            if (word.Length == item.Length)
            {

                var arr1 = item.ToCharArray();
                var arr2 = word.ToCharArray();
                Array.Sort(arr1);
                Array.Sort(arr2);

                if (arr1.SequenceEqual(arr2))
                {
                    anagrams.Add(item);
                }

            }
        }
        return anagrams.ToList();
    }
}