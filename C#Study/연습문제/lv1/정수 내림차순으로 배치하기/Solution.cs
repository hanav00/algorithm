using System;

public class Solution {

    public long solution(long n) {
        long answer = 0;
        char[] temp = n.ToString().ToCharArray();
        Array.Sort(temp);
        Array.Reverse(temp);
        answer = Convert.ToInt64(new string(temp));

        return answer;
    }
}
