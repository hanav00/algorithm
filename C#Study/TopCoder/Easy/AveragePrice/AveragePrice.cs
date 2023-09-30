using System;
using System.Collections.Generic;

public class AveragePrice
{
    public double NonDuplicatedAverage(int[] prices)
    {
        HashSet<int> priceCheck = new HashSet<int>();
        foreach (int price in prices)
        {
            priceCheck.Add(price);
        }

        double answer = 0;
        foreach (int num in priceCheck)
        {
            answer += num;
        }

        return answer / priceCheck.Count;
    }
}
