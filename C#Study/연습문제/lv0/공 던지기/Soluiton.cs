using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 1;
        k = k % numbers.Length;
        int[] number2 = new int[numbers.Length * 2];
        for (int i = 0; i < number2.Length; i++) {
            number2[i] = numbers[i % numbers.Length];
        }

        if (k == 0) answer = number2[number2.Length - 2];
        else answer = number2[k * 2 - 2];

        return answer;
    }
}
