using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int[2];
        
        //분모
        int denom = denom1 * denom2;
        //분자
        int numer = numer1 * denom2 + numer2 * denom1;
        
        //최대공약수로 나누기
        int gcd = GetGCD(denom, numer);
        
        answer[0] = numer / gcd;
        answer[1] = denom / gcd;
        
        return answer;
    }
    
    //유클리드 최대공약수 구하기
    public static int GetGCD(int num1, int num2)
    {
        while (num2 != 0) {
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }
        return num1;
    }
}
