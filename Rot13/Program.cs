using System;
using System.Linq;
public class Kata
{
    public static string Rot13(string message)
    {
        return !string.IsNullOrEmpty(message) ?
            new string(message
            .ToCharArray()
            .Select(s => { return (char)((s >= 97 && s <= 122) ? 
                ((s + 13 > 122) ? s - 13 : s + 13) : 
                (s >= 65 && s <= 90 ? (s + 13 > 90 ? s - 13 : s + 13) : s)); })
            .ToArray()) : message;
    }
}