public class Solution {
    public string LongestPalindrome(string s) {
        int longestStartIndex = 0;
        int longestLength = 0;

        for (int i = 0; i < s.Length; i++) {
            int length1 = ExpandAroundCenter(s, i, i); // odd palindrom (aba)
            int length2 = ExpandAroundCenter(s, i, i + 1); // even palindrom (abba)
            
            int maxLength = Math.Max(length1, length2);

            if (maxLength > longestLength) {
                longestLength = maxLength;
                longestStartIndex = i - (maxLength - 1) / 2;
            }
        }
        return s.Substring(longestStartIndex, longestLength);
    }

    private int ExpandAroundCenter(string s, int left, int right) {
        while (left >= 0 && right < s.Length && s[left] == s[right]) {
            left--;
            right++;
        }
        return right - left - 1;
    }
}
