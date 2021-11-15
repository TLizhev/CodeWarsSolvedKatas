using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{
    public static int IsInteresting(int number, List<int> awesomePhrases)
    {
        if (number == 98 || number == 99)
        {
            return 1;
        }
        if (number < 100)
        {
            return 0;
        }
        if (TrailingZeroes(number).Equals(2) || SameDigits(number).Equals(2) ||
            IsPalindrome(number).Equals(2) || IsContained(number, awesomePhrases).Equals(2) ||
            Ascending(number).Equals(2) || Descending(number).Equals(2))
        {
            return 2;
        }
        if (TrailingZeroes(number + 1).Equals(2) || SameDigits(number + 1).Equals(2) ||
            IsPalindrome(number + 1).Equals(2) || IsContained(number + 1, awesomePhrases).Equals(2) ||
            Ascending(number + 1).Equals(2) || Descending(number + 1).Equals(2))
        {
            return 1;
        }
        if (TrailingZeroes(number + 2).Equals(2) || SameDigits(number + 2).Equals(2) ||
            IsPalindrome(number + 2).Equals(2) || IsContained(number + 2, awesomePhrases).Equals(2) ||
            Ascending(number + 2).Equals(2) || Descending(number + 2).Equals(2))
        {
            return 1;
        }
        return 0;
    }
    private static int TrailingZeroes(int number)
    {
        var arr = number.ToString().ToCharArray();


        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != '0')
            {
                return 0;
            }
        }
        return 2;
    }

    private static int SameDigits(int number)
    {
        var arr = number.ToString().ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[0] != arr[i])
            {
                return 0;
            }
        }
        return 2;
    }

    private static int IsPalindrome(int number)
    {
        var arr = number.ToString().ToCharArray();
        var reverse = arr.Reverse();

        if (arr.SequenceEqual(reverse))
        {
            return 2;
        }
        return 0;
    }

    private static int IsContained(int number, List<int> list)
    {
        if (list.Contains(number))
        {
            return 2;
        }
        return 0;
    }

    private static int Ascending(int number)
    {
        var arr = number.ToString().ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < arr.Length - 1)
            {

                if ((int)arr[i] + 1 != arr[i + 1])
                {
                    if (arr[i] == '9' && arr[i + 1] == '0')
                    {
                        continue;
                    }
                    return 0;
                }
            }
        }
        return 2;
    }

    private static int Descending(int number)
    {
        var arr = number.ToString().ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < arr.Length - 1)
            {

                if ((int)arr[i] - 1 != arr[i + 1])
                {
                    if (arr[i] == '1' && arr[i + 1] == '0')
                    {
                        continue;
                    }
                    if (arr[i] == '0' && arr[i + 1] == '9')
                    {
                        return 0;
                    }
                    return 0;
                }
            }
        }
        return 2;
    }
}