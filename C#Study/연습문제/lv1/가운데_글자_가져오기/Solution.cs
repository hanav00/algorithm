using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        int length = s.Length;

        answer = (length%2 != 0) ? s[length/2].ToString() : s.Substring(length/2-1, 2);
        
        return answer;
    }
}
