using System;
using System.Collections.Generic;

public class Solution {
    HashSet<int> list = new HashSet<int>();
    public int[] solution(int n) {
        math(n); 
        int[] answer = new int[list.Count];
        list.CopyTo(answer);
        
        return answer;
    }
    
    public void math(int n) {
        for (int i = 2; i <= n; i++) {
            if (n % i == 0) {
                list.Add(i);
                math(n / i);
                return; 
            }
        }
    }
}
