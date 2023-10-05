public class SolutionWithLinearSearch {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length;
        int n = nums2.Length;
        
        if (m == 0) {
            return (n % 2 == 0) ? (nums2[n / 2] + nums2[(n / 2) - 1]) / 2.0 : nums2[n / 2];
        }
        if (n == 0) {
            return (m % 2 == 0) ? (nums1[m / 2] + nums1[(m / 2) - 1]) / 2.0 : nums1[m / 2];
        }

        int totalLength = m + n;
        int leftRemainingCount = (totalLength - 1) / 2;

        int left = 0;
        int i = 0;
        int j = 0;
        double median1 = 0;
        double median2 = 0;

        if (totalLength % 2 != 0){
            while (left < leftRemainingCount + 1) {
                median1 = (i < m) ? nums1[i] : double.MaxValue;
                median2 = (j < n) ? nums2[j] : double.MaxValue;

                if (median1 < median2) {
                    i++;
                } else {
                    j++;
                }

                left++;
            }
            return Math.Min(median1, median2);
        }
        else{
            double answer = 0;
            while (left < leftRemainingCount + 2) {
                median1 = (i < m) ? nums1[i] : double.MaxValue;
                median2 = (j < n) ? nums2[j] : double.MaxValue;

                if (median1 < median2) {
                    i++;
                    if (left >= leftRemainingCount){
                        answer += median1;
                    }
                } else {
                    j++;
                    if (left >= leftRemainingCount){
                        answer += median2;
                    }
                }
                left++;
            }
            return answer / 2.0;
        }
    }
}
