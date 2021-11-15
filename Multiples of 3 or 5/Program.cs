public static class Kata
{
    public static int Solution(int value)
    {
        int sum = 0;
        for (int i = 0; i < value; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                sum += i;
                continue;
            }
            else if (i % 3 == 0)
            {
                sum += i;
            }
            else if (i % 5 == 0)
            {
                sum += i;
            }
        }
        return sum;
    }
}