using System.Collections.Generic;
using System.Linq;

namespace Greatest_Position_Distance_Between_Matching_Array_Values
{
    public class GreatestDistance
    {
        public static int Exec(List<int> data)
        {
            var list = new List<int>();
            var max = 0;
            var duplicates = data.GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .Select(y => new { Item = y.Key, Count = y.Count() })
                .ToList();

            if (duplicates.Count == 0)
            {
                return 0;
            }

            foreach (var duplicate in duplicates)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] == duplicate.Item)
                    {
                        list.Add(i);
                    }
                }
                var current = list.Last() - list.First();
                if (current > max)
                {
                    max = current;
                }
                list = new List<int>();
            }

            return max;
        }
    }
}
