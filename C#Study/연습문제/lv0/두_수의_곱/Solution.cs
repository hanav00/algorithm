using System;

public class Solution {
    public int solution(int num1, int num2) {
        if (0 <= num1 && num1 <= 100 && 0<= num2 && num2 <= 100) return num1 * num2;
        else {
            try {
                throw new Exception("invalid param");
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}
