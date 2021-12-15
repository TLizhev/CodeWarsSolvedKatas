using System;
using System.Linq;

public class Runes
{
    public static int solveExpression(string expression)
    {
        Console.WriteLine(expression);
        if (expression.Contains("+"))
        {
            for (int i = 0; i < 10; i++)
            {
                var nums = expression.Replace("?", i.ToString()).Split("+");
                var num1 = nums[0];
                var num2 = nums[1].Split('=').First();
                var result = nums[1].Split('=').Last();

                if (result == "00")
                {
                    continue;
                }

                if (int.Parse(num1) + int.Parse(num2) == int.Parse(result))
                {
                    return i;
                }
            }
        }

        if (expression.Contains("/"))
        {
            for (int i = 0; i < 10; i++)
            {
                var nums = expression.Replace("?", i.ToString()).Split("/");
                var num1 = nums[0];
                var num2 = nums[1].Split('=').First();
                var result = nums[1].Split('=').Last();

                if (result == "00")
                {
                    continue;
                }

                if (int.Parse(num1) / int.Parse(num2) == int.Parse(result))
                {
                    return i;
                }
            }
        }
        if (expression.Contains("*"))
        {
            for (int i = 0; i < 10; i++)
            {
                if (expression.Contains(i.ToString()))
                {
                    continue;
                }

                var nums = expression.Replace("?", i.ToString()).Split("*");
                var num1 = nums[0];
                var num2 = nums[1].Split('=').First();
                var result = nums[1].Split('=').Last();

                if (result == "00")
                {
                    continue;
                }

                if (int.Parse(num1) * int.Parse(num2) == int.Parse(result))
                {
                    return i;
                }

            }
        }
        if (expression.Contains("-"))
        {
            for (int i = 0; i < 10; i++)
            {
                if (expression.Contains(i.ToString()))
                {
                    continue;

                }
                var nums = expression.Replace("?", i.ToString()).Split(new[] { '-' }, 2).ToList();
                var num1 = 0;
                if (expression.First() != '-')
                {
                    num1 = int.Parse(nums[0]);
                }
                else
                {
                    nums = expression.Substring(1).Replace("?", i.ToString()).Split(new[] { '-' }, 2).ToList();
                    if (nums[0].First() == '0')
                    {
                        continue;
                    }
                    num1 = int.Parse(nums[0]);
                    num1 = num1 - num1 * 2;
                }



                var num2 = int.Parse(nums[1].Split('=').First());
                var result = int.Parse(nums.Last().Split('=').Last());

                if (result.ToString() == "00")
                {
                    continue;
                }

                if (num1 - num2 == result)
                {
                    return i;
                }
            }
        }


        return -1;
    }
}