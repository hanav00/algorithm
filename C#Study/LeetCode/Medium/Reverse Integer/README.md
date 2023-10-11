# Intuition & Approach
1. Check if x is negative. I had to make x positive since I will convert it to string type.
2. Convert x to a string and build a new string in reverse.
3. Convert the reversed string back to an integer. Ensure to return 0 if it is out of the Int32 range.
4. If x was negative, return -x.

# Complexity
- Time complexity: $$O(log10(x))$$ 

- Space complexity: $$O(1)$$ 

# Code
```
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

```
