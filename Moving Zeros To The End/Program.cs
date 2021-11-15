using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item);
        }
        List<int> list = arr.ToList();
        var counter = 0;

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == 0)
            {
                list.Remove(list[i]);
                counter++;
                i--;
            }

        }
        for (int i = 0; i < counter; i++)
        {

            list.Add(0);
        }
        return list.ToArray();
    }
}