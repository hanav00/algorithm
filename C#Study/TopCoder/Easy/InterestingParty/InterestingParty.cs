using System;
using System.Collections.Generic;

public class InterestingParty
{
    public int BestInvitation(string[] first, string[] second)
    {
        Dictionary<string, int> hobby = new Dictionary<string, int>();

        foreach (string name in first)
        {
            if (hobby.ContainsKey(name))
            {
                hobby[name]++;
            }
            else
            {
                hobby[name] = 1;
            }
        }

        foreach (string name in second)
        {
            if (hobby.ContainsKey(name))
            {
                hobby[name]++;
            }
            else
            {
                hobby[name] = 1;
            }
        }

        int maxCnt = 1;

        foreach (int count in hobby.Values)
        {
            if (count > maxCnt)
            {
                maxCnt = count;
            }
        }

        return maxCnt;
    }
}
