using System;

public class A0Paper
{
    public string CanBuild(int[] A)
    {
        double sum = 0;
        for (int i = 0; i < A.Length; i++)
        {
            sum += (1 / Math.Pow(2, i)) * A[i];
            if (sum >= 1)
                return "Possible";
        }
        return "Impossible";
    }
}
