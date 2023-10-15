public class Solution {
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false;
        string numStr = x.ToString();

        int left = 0;
        int right = numStr.Length - 1;

        while (left < right){
            if (numStr[left] != numStr[right]){
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
