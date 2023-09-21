using System;

public class BrokenStrings
{
    public int BuyStrings(int n, string[] stringCosts)
    {
        int[,] costs = new int[stringCosts.Length, 2];
        for (int i = 0; i < stringCosts.Length; i++)
        {
            string[] costValues = stringCosts[i].Split(' ');
            costs[i, 0] = int.Parse(costValues[0]);
            costs[i, 1] = int.Parse(costValues[1]);
        }

        int min6 = 1000, min1 = 1000;
        for (int i = 0; i < costs.GetLength(0); i++)
        {
            if (min6 > costs[i, 0]) min6 = costs[i, 0];
            if (min1 > costs[i, 1]) min1 = costs[i, 1];
        }

        int sum = 0;
        int number = n;
        if (number >= 6)
        {
            sum = (number / 6) * min6;
            number -= (number / 6) * 6;
        }
        sum += number * min1;

        int sum1 = 0;
        if (n % 6 != 0)
        {
            sum1 = ((n / 6) + 1) * min6;
        }
        else
        {
            sum1 = (n / 6) * min6;
        }

        int sum2 = n * min1;

        int answer = Math.Min(sum, Math.Min(sum1, sum2));

        return answer;
    }
}
