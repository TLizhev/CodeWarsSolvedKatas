using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static int Score(int[] dice)
    {
        Dictionary<int, int> dick = new Dictionary<int, int>();

        for (int i = 0; i < dice.Length; i++)
        {
            Console.Write(dice[i]);
            if (!dick.ContainsKey(dice[i]))
            {
                dick.Add(dice[i], 1);
            }
            else
            {
                var val = dick.Where(x => x.Key == dice[i]).Select(v => v.Value).FirstOrDefault() + 1;
                dick.Remove(dice[i]);
                dick.Add(dice[i], val);
            }
        }

        var points = 0;

        foreach (var item in dick)
        {
            switch (item.Key)
            {
                case 1:
                    if (item.Value < 3)
                    {
                        points += 100 * item.Value;

                    }
                    else if (item.Value == 3)
                    {
                        points += 1000;
                    }
                    else
                    {
                        points += 1000 + (item.Value - 3) * 100;
                    }
                    break;
                case 2:
                    if (item.Value >= 3)
                    {
                        points += 200;
                    }
                    break;
                case 3:
                    if (item.Value >= 3)
                    {
                        points += 300;
                    }
                    break;
                case 4:
                    if (item.Value >= 3)
                    {
                        points += 400;
                    }
                    break;
                case 5:
                    if (item.Value < 3)
                    {
                        points += 50 * item.Value;

                    }
                    else if (item.Value == 3)
                    {
                        points += 500;
                    }
                    else
                    {
                        points += 500 + (item.Value - 3) * 50;
                    }
                    break;
                case 6:
                    if (item.Value >= 3)
                    {
                        points += 600;
                    }
                    break;
                default:
                    break;
            }
        }
        return points; ;
    }
}