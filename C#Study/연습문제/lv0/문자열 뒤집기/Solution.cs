using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        for (int i=0; i<my_string.Length; i++)
        {
            answer += my_string.Substring(my_string.Length - 1 -i, 1);
        }
        return answer;
    }
}
