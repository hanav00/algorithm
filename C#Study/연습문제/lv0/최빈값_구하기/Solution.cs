using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] array) {

        Dictionary<int, int> CntDict = new Dictionary<int, int>();
        foreach (int i in array)
        {
            if (CntDict.ContainsKey(i))
            {
                CntDict[i]++;
            }
            else
            {
                CntDict.Add(i,1);
            }
        }

        int answer = 0; int count = 0; int only = 0;
        
        foreach (var pair in CntDict)
        {
            if (pair.Value > count)
            {
                count = pair.Value;
                answer = pair.Key;
            }
        }

        foreach (var pair in CntDict)
        {
            if (count == pair.Value) only ++;
            if (only > 1) return -1;
        }
        
        return answer;
    }
}
