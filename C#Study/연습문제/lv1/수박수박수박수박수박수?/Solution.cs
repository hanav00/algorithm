using System;

public class Solution {
    public string solution(int n) {
        string answer = "";
        
        for (int i=0; i<n/2; i++) {
            answer += "수박";
        }
        
        if (n%2 != 0) answer += "수";
        //Console.WriteLine(answer);
        return answer;
    }
}
