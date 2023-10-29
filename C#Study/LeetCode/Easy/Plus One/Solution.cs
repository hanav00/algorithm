public class Solution {
    public int[] PlusOne(int[] digits) {
        int n = digits.Length;
        int carry = 1;
        
        for (int i = n - 1; i >= 0; i--) {
            int sum = digits[i] + carry;
            digits[i] = sum % 10;
            carry = sum / 10;
            
            if (carry == 0) {
                // No need to carry over to the next digit
                break;
            }
        }
        
        if (carry == 1) {
            // Need to add an additional digit
            int[] result = new int[n + 1];
            result[0] = 1;
            return result;
        }
        
        return digits;
    }
}
