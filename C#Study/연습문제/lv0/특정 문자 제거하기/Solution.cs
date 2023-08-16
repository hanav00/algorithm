using System;

public class Solution {
    public string solution(string my_string, string letter) {
        string answer = my_string;

        int index = answer.IndexOf(letter);
        while (index != -1)
        {
            answer = answer.Remove(index, 1);
            index = answer.IndexOf(letter);
        }

        return answer;
    }
}
