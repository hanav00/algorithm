# Intuition
Given an integer, we want to determine if it's a power of two.

# Approach
First, check if the input is less than or equal to 0. If it is, return false.

Next, check if the input is a power of two by verifying that it has only one '1' bit when represented in binary.

To check if a number has only one set bit, we can use the expression (n & (n - 1)) == 0. If it's true, the number is a power of two; otherwise, it's not.

# Complexity
- Time complexity: $$O(log2(n))$$

- Space complexity: $$O(1)$$ 

# Code
```
public class Solution {
    public bool IsPowerOfTwo(int n) {
        if (n <= 0) return false;
        while (n > 1){
            if (n%2 != 0) return false;
            else n = n/2;
        }
        return true;
    }
}
```
