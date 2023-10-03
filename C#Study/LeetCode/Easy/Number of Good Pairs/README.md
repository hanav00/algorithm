# Intuition
My first thought was to compare each element with the elements that come after it in the array.

# Approach
I iterate through all elements and check if any identical pairs exist by comparing each element with the elements at higher indices.

# Complexity
- Time complexity: $$O(n^2)$$

- Space complexity: $$O(1)$$

# Code
```
public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int answer = 0;
        for (int i=0; i<nums.Length-1; i++){
            for (int j=i+1; j<nums.Length; j++){
                if (nums[i] == nums[j]){
                    answer ++;
                }
            }
        }
        return answer;
    }
}
```
