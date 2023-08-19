using System;

public class Solution {
    public int[,] solution(int[] num_list, int n) {
        int rows = num_list.Length / n;
        int[,] answer = new int[rows, n];
        
        int index = 0;
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < n; j++) {
                answer[i, j] = num_list[index++];
            }
        }
        
        return answer;
    }
}
