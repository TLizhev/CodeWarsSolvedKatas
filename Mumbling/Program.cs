using System;
using System.Text;
using System.Globalization;

public class Accumul
{
    public static String Accum(string s)
    {
        StringBuilder sb = new StringBuilder();
        string loweredInput = s.ToLower();
        char[] arr = loweredInput.ToCharArray();
        for (int i = 0; i < loweredInput.Length; i++)
        {
            sb.Append(arr[i], i + 1);
            sb.Append("-");
        }
        var output = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(sb.ToString());
        return output.TrimEnd('-');
    }
}