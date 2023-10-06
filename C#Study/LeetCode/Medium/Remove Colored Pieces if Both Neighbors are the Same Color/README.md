# Intuition
If Alice has a higher possible turn count than Bob, Alice is the winner. A possible turn is counted if the same letter occurs consecutively 3 times or more.

# Approach
I have declared some variables to check if the same letter occurs consecutively three times or more. If the consecutive count is 3 or greater, the possible turn count increases.

# Complexity
- Time complexity: $$O(n)$$

- Space complexity: $$O(1)$$

# Code
```
public class Solution {
    public bool WinnerOfGame(string colors) {
        int n = colors.Length;
        int aliceTurn = 0;
        int bobTurn = 0;
        int countA = 0;
        int countB = 0;

        for (int i = 0; i < n; i++) {
            if (colors[i] == 'A') {
                countA++;
                countB = 0;

                if (countA >= 3) {
                    aliceTurn++;
                }
            } else if (colors[i] == 'B') {
                countB++;
                countA = 0;

                if (countB >= 3) {
                    bobTurn++;
                }
            }
        }

        return aliceTurn > bobTurn;
    }
}

```
