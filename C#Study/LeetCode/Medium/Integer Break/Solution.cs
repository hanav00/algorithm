public class Solution {
    public int IntegerBreak(int n) {
        if (n == 2) return 1;
        if (n == 3) return 2;
        /* Remaining 1 -> same when multiplied */
        /* group as many 3's as possible, and if there is a remaining 1, make it 2 */
        int answer = 1;
        int max3 = n/3;
        int left = n - max3*3;
        if (left == 0){
            answer = (int)Math.Pow(3, max3);
        }
        else if (left == 1){
            answer = (int)Math.Pow(3, max3-1) * 2 * 2;
        }
        else {
            answer = (int)Math.Pow(3, max3) * 2;
        }
        return answer;
    }
}
