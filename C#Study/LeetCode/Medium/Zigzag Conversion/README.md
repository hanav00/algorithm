# Intuition & Approach
I have listed the differences between the indices of each character.
```
00    04    08    12 --> +4
01 03 05 07 09 11 13 --> +2 +2
02    06    10       --> +4
```
```
00       06       12        --> +6 
01    05 07    11 13    17  --> +4 +2 
02 04    08 10    14 16     --> +2 +4 
03       09       15        --> +6 
```
```
if (numRows == 6)
--> +10
--> +8 +2
--> +6 +4
--> +4 +6
--> +2 +8
--> +10
```
```
if (numRows == n)
--> +(n-1 -0)*2 
--> +(n-1 -1)*2 +2*1 => sum = (n-1)*2
--> +(n-1 -2)*2 +2*2 => sum = (n-1)*2
.
.
.
```
As you can see, for the rows located in the middle, excluding the first and last rows, you can simply concatenate the string according to their row numbers.

# Complexity
- Time complexity: $$O(n)$$

- Space complexity: $$O(n)$$

# Code
```
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

```
