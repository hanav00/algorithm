using System;

public class Solution {
    public int solution(int num1, int num2) {
        double result = 0;
        int answer = 0;
        
        if (0 < num1 && num1 <= 100 && 0 < num2 && num2 <= 100) {
            result = (double)num1 / num2;
            answer = (int)Math.Floor(result * 1000);
        }
        else {
            try {
                throw new Exception ("invalid param");
            }
            catch {
                Console.WriteLine("범위 벗어남");
                answer = -1;
            }
        }
        
        return answer;
    }
}
