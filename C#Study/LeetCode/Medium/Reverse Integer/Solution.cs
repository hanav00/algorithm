public class Solution {
    public int Reverse(int x) {
        bool isNegative = false;
        if (x < 0) {
            isNegative = true;
            x = -x;
        }
        string xToString = x.ToString();
        int length = xToString.Length;

        StringBuilder answerString = new StringBuilder();
        for (int i = length - 1; i >= 0; i--) {
            answerString.Append(xToString[i]);
        }

        if (!int.TryParse(answerString.ToString(), out int answer)) {
            return 0;
        }
        return isNegative ? -answer : answer;
    }
}
