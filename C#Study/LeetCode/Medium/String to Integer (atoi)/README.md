# Intuition
Just followed the description!

# Approach
1. Read in and ignore any leading whitespace. **-> Trim()**
2. Check if the next character is '-' or '+'. **-> Check if the first character in the trimmed string is '+' or '-'.** (Since it was trimmed, the first character should be either '+' or '-'. If it's not, assume it's a positive number.)
4. Read in the next characters until the next non-digit character is encountered or the end of the input is reached. **-> If the first character is not a digit, return 0. If it is a digit, find the last continuous digit.**
4. If the integer is out of the 32-bit signed integer range [-231, 231 - 1], then clamp the integer so that it remains in the range. **-> If the number is positive, use int.MaxValue; otherwise, use int.MinValue.**

# Complexity
- Time complexity: $$O(n)$$

- Space complexity: $$O(1)$$

# Code
```
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

```
