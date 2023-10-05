public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length;
        int n = nums2.Length;

        if (m > n) {
            return FindMedianSortedArrays(nums2, nums1);
        }

        int left = 0;
        int right = m;
        int halfLen = (m + n + 1) / 2;

        while (left <= right) {
            int i = (left + right) / 2;
            int j = halfLen - i;

            if (i < m && nums2[j - 1] > nums1[i]) {
                left = i + 1;
            } else if (i > 0 && nums1[i - 1] > nums2[j]) {
                right = i - 1;
            } else {
                double maxLeft = 0;
                if (i == 0) maxLeft = nums2[j - 1];
                else if (j == 0) maxLeft = nums1[i - 1];
                else maxLeft = Math.Max(nums1[i - 1], nums2[j - 1]);

                if ((m + n) % 2 == 1) {
                    return maxLeft;
                }
                
                double minRight = 0;
                if (i == m) {
                    minRight = nums2[j];
                }
                else if (j == n) {
                    minRight = nums1[i];
                }
                else {
                    minRight = Math.Min(nums1[i], nums2[j]);
                }

                return (maxLeft + minRight) / 2.0;
            }
        }
        return 0.0;
    }
}
