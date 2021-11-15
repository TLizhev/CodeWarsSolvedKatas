using System;
using System.Linq;
public class DirReduction
{

    public static string[] dirReduc(String[] arr)
    {
        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
        var list = arr.ToList();
        for (int i = 0; i < arr.Length; i++)
        {
            if (list.Count < 2)
            {
                break;
            }
            if (i == list.Count - 1)
            {
                break;
            }
            if (AreOpposite(list[i], list[i + 1]))
            {
                list.RemoveRange(i, 2);
                i = -1;
            }
        }
        return list.ToArray();
        bool AreOpposite(string firstDirection, string secondDirection)
        {
            if (firstDirection == "NORTH" && secondDirection == "SOUTH")
            {
                return true;
            }
            else if (firstDirection == "EAST" && secondDirection == "WEST")
            {
                return true;
            }
            else if (firstDirection == "SOUTH" && secondDirection == "NORTH")
            {
                return true;
            }
            else if (firstDirection == "WEST" && secondDirection == "EAST")
            {
                return true;
            }
            return false;
        }
    }
}
