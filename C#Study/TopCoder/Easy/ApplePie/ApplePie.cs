public class ApplePie
{
    public int GetApples(int[] x, int[] y, int[] day, int howMany)
    {
        int sum = 0;
        for (int i = 0; i < x.Length; i++)
        {
            if (0 <= x[i] && x[i] <= 100 && 0 <= y[i] && y[i] <= 100)
            {
                sum++;
            }
            if (sum == howMany)
                return day[i];
        }
        return -1;
    }
}
