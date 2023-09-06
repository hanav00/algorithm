using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] array) 
    {
        int max = array.Max();
        int maxIndex = Array.IndexOf(array, max);
        
        int[] answer = new int[2]{max, maxIndex};
        
        return answer;
    }
}
