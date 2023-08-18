using System;

public class Solution {
    public string solution(string letter) {
        string answer = "";
        string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

        foreach(string a in letter.Split(" "))
        {
            answer += Convert.ToChar(Array.IndexOf(morse, a) + 97);
        }
        return answer;
    }
}
