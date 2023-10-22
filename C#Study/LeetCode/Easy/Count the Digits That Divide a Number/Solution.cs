public class Solution {
    public int CountDigits(int num) {
        int answer = 0;
        string numString = num.ToString();
        
        for (int i = 0; i < numString.Length; i++) {
            int digit = int.Parse(numString[i].ToString());
            if (digit != 0 && num % digit == 0) {
                answer++;
            }
        }
        return answer;
    }
}
