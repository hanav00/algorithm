using System;

public class Solution {
    public string solution(string rsp) {
        string[] answer = new string[rsp.Length];
        
        for (int i=0; i<rsp.Length; i++)
        {
            if (rsp[i] == '2') answer[i] = "0";
            if (rsp[i] == '0') answer[i] = "5";
            if (rsp[i] == '5') answer[i] = "2";
        }
        
        string ans = "";
        for (int i=0; i<answer.Length; i++) 
        {
            ans += answer[i];
        }
        
        return ans;
    }
}
