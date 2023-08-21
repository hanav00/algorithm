using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        for (int i=1; i<=n; i++)
        {
            if (count(i)) answer ++;
        }
        
        return answer;
    }
    
    public bool count(int n)
    {
        for (int i=2; i<n; i++)
        {
            if (n%i == 0) return true;
        }
        return false;
    }
}
