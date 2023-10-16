# Intuition & Approach
[1, 1]
[1, 1+1, 1]
[1, 1+(1+1), (1+1)+1, 1]
...
-> You just need to add the previous element of the current index, except for the first and last numbers.

# Complexity
- Time complexity: $$O(n^2)$$

- Space complexity: $$O(n^2)$$

# Code
```
public class Solution {
    public IList<int> GetRow(int rowIndex) {
        List<int> row = new List<int>();
        
        for (int i = 0; i <= rowIndex; i++) {
            row.Add(1);
            for (int j = i - 1; j > 0; j--) {
                row[j] += row[j - 1];
            }
        }
        return row;
    }
}
```
