using System;

public class Solution {
    public string[] solution(string[] quiz) {
        string[] answer = new string[quiz.Length];
        
        for (int i=0; i<quiz.Length; i++) 
        {
            string[] quizArr = quiz[i].Split(' ');
            
            //항상 요소가 5개
            int num1 = int.Parse(quizArr[0]);
            int num2 = int.Parse(quizArr[2]);
            int result = int.Parse(quizArr[4]);
            
            if (quizArr[1] == "+")
            {
                if (num1 + num2 == result) answer[i] = "O";
                else answer[i] = "X";
            }
            else
            {
                if (num1 - num2 == result) answer[i] = "O";
                else answer[i] = "X";
            }
        }
        
        
        return answer;
    }
}
