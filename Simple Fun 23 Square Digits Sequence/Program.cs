using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Fun_23_Square_Digits_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.SquareDigitsSequence(1));
        }
    }

    public class Kata
    {
        public static int SquareDigitsSequence(int a0)
        {
            var collection = new List<int> { a0, Sequence(a0) };
            if (collection.First() == collection.Last())
            {
                return collection.Count;
            }

            while (true)
            {
                var item = Sequence(collection.Last());

                if (collection.Contains(item))
                {
                    return collection.Count + 1;
                }
                collection.Add(item);
            }
        }

        public static int Sequence(int number)
        {
            return (int)number.ToString()
                 .Select(char.GetNumericValue)
                 .Select(x => Math.Pow(x, 2))
                 .Sum();
        }
    }
}
