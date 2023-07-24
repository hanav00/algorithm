using System;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];
        int firstNum = 0;

        firstNum = (total - (num*(num-1)/2)) / num;
        
        for (int i=0; i<num; i++) {
            answer[i] = firstNum + i;
        }
        return answer;
    }
}
