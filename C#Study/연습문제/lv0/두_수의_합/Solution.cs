using System;

public class Solution {
    public int solution(int num1, int num2) {
        //제한사항 적용하기
        if (-50000 <= num1 && num1 <= 50000 && -50000 <= num2 && num2 <= 50000) return num1 + num2;
        else {
          try {
              // 숫자 범위를 벗어남
              throw new Exception("invalid param");
          }
          catch (Exception ex)
          {
              //Console.WriteLine("범위 벗어남: " + ex.Message);
              return -1;
          }
        }
    }//end of solution
}//end of class Solution
