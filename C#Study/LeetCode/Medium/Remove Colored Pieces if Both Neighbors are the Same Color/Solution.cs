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
