using System;
using System.Collections.Generic;

namespace prime
{
    public class GFG
    {
        public static IEnumerable<int> SieveOfEratosthenes(int n)
        {
            List<int> list = new List<int>();

            bool[] prime = new bool[n + 1];

            for (int i = 0; i <= n; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {

                if (prime[p] == true)
                {
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (prime[i] == true)
                    list.Add(i);
            }

            return list;
        }

        public static void Main()
        {
            int n = 10000;

            var result = SieveOfEratosthenes(n);
        }
    }
}