using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] emergency) {
        int[] answer = new int[emergency.Length]; 
        int number = 1;
        
        for (int i = 100; i >= 1; i--)
        {
            if (emergency.Contains(i))
            {
                int index = Array.IndexOf(emergency, i);
                answer[index] = number;
                number++;
            }
        }
        
        return answer;
    }
}
