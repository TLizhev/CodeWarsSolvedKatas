using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roman_Numerals_Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInteger("MMMDCCCXXXVIII"));
        }
        public static string ToRoman(int n)
        {

            int number = n;

            string year = number.ToString();

            List<string> reversedYear = new List<string>();

            for (int i = year.Length - 1; i >= 0; i--)
            {
                reversedYear.Add(year[i].ToString());
            }

            StringBuilder sb = new StringBuilder();


            string[] thousands = { "0", "M", "MM", "MMM" };
            string[] hundreds = { "0", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "0", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "0", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            if (reversedYear.Count == 1)
            {
                var one = ones.GetValue(int.Parse(reversedYear[0]));

                sb.Append(one);
            }

            if (reversedYear.Count == 2)
            {
                var one = ones.GetValue(int.Parse(reversedYear[0]));
                var ten = tens.GetValue(int.Parse(reversedYear[1]));

                sb.Append(ten).Append(one);
            }

            if (reversedYear.Count == 3)
            {
                var one = ones.GetValue(int.Parse(reversedYear[0]));
                var ten = tens.GetValue(int.Parse(reversedYear[1]));
                var hundred = hundreds.GetValue(int.Parse(reversedYear[2]));

                sb.Append(hundred).Append(ten).Append(one);
            }

            if (reversedYear.Count == 4)
            {

                var one = ones.GetValue(int.Parse(reversedYear[0]));
                var ten = tens.GetValue(int.Parse(reversedYear[1]));
                var hundred = hundreds.GetValue(int.Parse(reversedYear[2]));
                var thousand = thousands.GetValue(int.Parse(reversedYear[3]));

                sb.Append(thousand).Append(hundred).Append(ten).Append(one);

            }




            if (sb.ToString().Any(x => x == '0'))
            {
                var result = sb.Replace('0', ' ').ToString();
                var end = result.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (end.Length==1)
                {
                    return end[0];
                }
                string endResult = end[0] + end[1];
                return endResult;
            }




            return sb.ToString();
        }

        public static int ToNumber(string year)
        {
            string input = year;

            List<string> thousands =new List<string>  { "0", "M", "MM", "MMM" };
            List<string> hundreds = new List<string> { "0", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            List<string> tens =new List<string>{ "0", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            List<string> ones =new List<string>{ "0", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            StringBuilder sb = new StringBuilder();

            for (int l = 0; l < ones.Count; l++)
            {
                if (ones[l].Equals(input))
                {
                    return l;
                }

                if (input.Length > 1)
                {

                    StringBuilder something = new StringBuilder();
                    foreach (var item in ones)
                    {
                        something.Append(item);
                    }
                   var part = something.ToString().Substring(0,l);

                   if (ones[l].Contains(part))
                   {
                       sb.Append(part);
                   }
                }

            }

            for (int k = 0; k < tens.Count; k++)
            {
                if (tens[k].Equals(input))
                {
                    return k;
                }
                if (tens[k].Equals(input[3].ToString() + input[4].ToString()))
                {
                    sb.Append(k);
                }
            }

            for (int j = 0; j < hundreds.Count; j++)
            {
                if (hundreds[j].Equals(input))
                {
                    return j;
                }
                if (hundreds[j].Equals(input[1].ToString() + input[2].ToString()))
                {
                    sb.Append(j);
                }
            }

            for (int i = 0; i < thousands.Count; i++)
            {
                if (thousands[i].Equals(input))
                {
                    return i;
                }

                if (thousands[i].Equals(input[0].ToString()))
                {
                    sb.Append(i);
                }

            }

            return int.Parse(sb.ToString());
        }

        private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public static int RomanToInteger(string romanNumeral)
        {
            int number = 0;
            for (int i = 0; i < romanNumeral.Length; i++)
            {
                if (i + 1 < romanNumeral.Length && RomanMap[romanNumeral[i]] < RomanMap[romanNumeral[i + 1]])
                {
                    number -= RomanMap[romanNumeral[i]];
                }
                else
                {
                    number += RomanMap[romanNumeral[i]];
                }
            }
            return number;
        }
    }
}
