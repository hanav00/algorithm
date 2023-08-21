using System;

public class Solution {
    public int solution(int n) {
        int factorial = 1;
        for (int i=1; ; i++){
            factorial *= i;
            if (factorial > n) return i-1;
        }
    }
}
