public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) return s;

        int length = s.Length;
        StringBuilder answer = new StringBuilder();
        int setting = (numRows - 1) * 2;

        for (int i = 0; i < numRows; i++) {
            for (int j = i; j < length; j += setting) {
                answer.Append(s[j]);
                if (i > 0 && i < numRows - 1 && j + (numRows - i - 1) * 2 < length) {
                    answer.Append(s[j + (numRows - i - 1) * 2]);
                }
            }
        }
        
        return answer.ToString();
    }
}
