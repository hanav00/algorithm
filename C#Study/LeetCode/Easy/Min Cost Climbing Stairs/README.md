# Intuition
To solve this problem, we can use dynamic programming. We'll maintain an array `dp` where `dp[i]` represents the minimum cost to reach step `i`. We can fill in this array by iterating through the steps and calculating the minimum cost at each step.


# Approach
1. Create an array `dp` of length `n`, where `n` is the length of the `cost` array.
2. Initialize `dp[0]` and `dp[1]` with the costs of the first two steps, as we need these values as base cases.
3. Iterate from step `2` to step `n-1`.
4. For each step `i`, calculate `dp[i]` as the cost of the current step (`cost[i]`) plus the minimum of the cost to reach the previous step (`dp[i-1]`) and the cost to reach the step before the previous step (`dp[i-2]`).
5. Finally, return the minimum of `dp[n-1]` and `dp[n-2]` as the result, as we can either end at the last step or the step before the last step.


# Complexity
- Time complexity: $$O(n)$$ 

- Space complexity: $$O(n)$$

# Code
```
public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;

        int[] dp = new int[n];
        dp[0] = cost[0];
        dp[1] = cost[1];

        for (int i = 2; i < n; i++) {
            dp[i] = cost[i] + Math.Min(dp[i - 1], dp[i - 2]);
        }
        return Math.Min(dp[n - 1], dp[n - 2]);
    }
}
```
