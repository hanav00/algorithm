# Intuition
My initial approach was to explore all possible combinations of sums within the nums array.

# Approach
I utilized an outer and inner loop, along with an if statement, to evaluate the sum of two elements in the given array. I made sure not to redundantly add array elements, and I paid careful attention to defining the iteration range for the variables (i, j) within the for loop.

# Complexity
- Time complexity: $$O(n^2)$$
( T(n) = (nums.Length - 2) * (nums.Length - 1 - i) * O(1) )

- Space complexity: $$O(1)$$
( Size of answer is always 2. )

# Code
```
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] answer = new int[2];
        for (int i=0; i<nums.Length-1; i++){
            for (int j=i+1; j<nums.Length; j++){
                if (nums[i] + nums[j] == target){
                    answer[0] = i;
                    answer[1] = j;
                    break;
                }
            }
        }
        return answer;
    }
}
```
