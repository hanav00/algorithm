public class Solution {
    public int MyAtoi(string s) {
        bool isPositive = true;

        // Remove Space
        s = s.Trim();
        
        if (s.Length == 0) return 0;
        int firstIndex = 0;
        int lastIndex = s.Length-1;

        // find if it is positive or negative
        if (s[0] == '-') {
            isPositive = false;
            firstIndex = 1;
            if (s.Length == 1) return 0;
        }
        else if (s[0] == '+'){
            firstIndex = 1;
            if (s.Length == 1) return 0;
        }
        // find first index
        if (!Char.IsDigit(s[firstIndex])) {
            return 0;
        }

        for (int i = firstIndex; i < s.Length; i++) {
            // last index
            if (!Char.IsDigit(s[i])) {
                lastIndex = i - 1;
                break;
            }
        }

        string answerString = s.Substring(firstIndex, lastIndex - firstIndex + 1);
        int answer = 0;

        if (int.TryParse(answerString, out int result)) {
            answer = isPositive ? result : -result;
        }
        else {
            if (isPositive) {
                answer = int.MaxValue;
            } else {
                answer = int.MinValue;
            }
        }
        return answer;
    }
}
