using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string strN = n.ToString();
        for (int i=0; i<strN.Length; i++){
            answer += Convert.ToInt32(strN[i].ToString());
        }
        return answer;
    }
}
