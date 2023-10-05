public class Solution2 {
    public IList<int> MajorityElement(int[] nums) {
        int n = nums.Length;
        /* list max length is 2 ( (n/3 + a) + (n/3 + b) = 2n/3 + x, n - (2n/3 + x) < n/3 */
        /* Boyer-Moore Majority Vote */
        int max1 = 0;
        int max2 = 0;
        int max1Count = 0;
        int max2Count = 0;

        foreach (int num in nums) {
            if (num == max1) {
                max1Count++;
            } else if (num == max2) {
                max2Count++;
            } else if (max1Count == 0) {
                max1 = num;
                max1Count = 1;
            } else if (max2Count == 0) {
                max2 = num;
                max2Count = 1;
            } else {
                max1Count--;
                max2Count--;
            }
        }
        
        max1Count = 0;
        max2Count = 0;
        
        foreach (int num in nums) {
            if (num == max1) {
                max1Count++;
            } else if (num == max2) {
                max2Count++;
            }
        }
        
        List<int> answer = new List<int>();
        if (max1Count > nums.Length / 3) {
            answer.Add(max1);
        }
        if (max2Count > nums.Length / 3) {
            answer.Add(max2);
        }

        return answer;
    }
}
