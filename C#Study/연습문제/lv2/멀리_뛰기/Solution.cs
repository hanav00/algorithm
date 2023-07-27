using System;

public class Solution {
    public int solution(int n) {
        /*
        n=0 : (0) -> 1
        n=1 : (1) -> 1
        n=2 : (2) (1,1) -> 2
                => (n[0], 2) (n[1], 1)
        n=3 : (2,1) (1,2) (1,1,1) -> 3
                => (n[1], 2) (n[2], 1)
        n=4 : (2,2) (2,1,1) (1,2,1) (1,1,2) (1,1,1,1) -> 5
                => (n[2], 2) (n[3], 1)
        n=5 : (n[3], 2) (n[4], 1)
        */
        
        int MOD = 1234567;
        int[] count = new int[n + 1];
        count[0] = 1;
        count[1] = 1;

        for (int i = 2; i <= n; i++) {
            count[i] = (count[i - 1] + count[i - 2]) % MOD;
        }

        return count[n];
    }
}
