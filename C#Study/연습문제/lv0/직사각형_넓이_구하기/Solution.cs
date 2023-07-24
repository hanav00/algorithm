using System;

public class Solution {
    public int solution(int[,] dots) {
        int width = 0; int height = 0;
        
        
        for (int i = 0; i < 3; i++) {
            if (dots[i, 0] != dots[i + 1, 0]) {
                height = Math.Abs(dots[i, 0] - dots[i + 1, 0]);
                break;
            }
        }

        for (int i = 0; i < 3; i++) {
            if (dots[i, 1] != dots[i + 1, 1]) {
                width = Math.Abs(dots[i, 1] - dots[i + 1, 1]);
                break;
            }
        }
        
        return height * width;
    }
}
