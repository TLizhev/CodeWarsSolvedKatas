using System.Collections.Generic;
public static class Kata
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        SortedSet<int> set = new SortedSet<int>();

        foreach (var item in numbers)
        {
            set.Add(item);
        }
        set.CopyTo(numbers);
        return numbers[0] + numbers[1];
    }
}