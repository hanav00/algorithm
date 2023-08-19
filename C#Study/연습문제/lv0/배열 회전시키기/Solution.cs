using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[numbers.Length];
        
        for (int i = 0; i < numbers.Length; i++) {
            if (direction == "left") {
                answer[i] = numbers[(i + 1) % numbers.Length];
            } 
            else if (direction == "right") {
                int newIndex = i - 1;
                if (newIndex < 0) {
                    newIndex = numbers.Length - 1;
                }
                answer[i] = numbers[newIndex];
            }
            else {
                throw new ArgumentException("direction 값 오류");
            }
        }

        return answer;
    }
}
