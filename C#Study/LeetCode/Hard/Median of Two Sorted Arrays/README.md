# Intuition
The problem statement specifies a required time complexity of O(log (m+n)), which naturally suggests the use of a binary search algorithm.

# Approach
Binary search is an algorithm used to find a specific value in a sorted array, and it proceeds through the following steps:

1. Set the start and end indices. Initially, start with the entire array.
2. Calculate the middle index. Find it as (start index + end index) / 
3. Compare the element at the middle index with the value you're looking for.
4. If the middle element matches the desired value, return that value, and end the algorithm.
5. If the middle element is greater than the desired value, perform another binary search on the right half of the array. In other words, update the end index to be one less than the middle index.
6. If the middle element is less than the desired value, perform another binary search on the left half of the array. In this case, update the start index to be one more than the middle index.
7. Repeat these steps until you find the desired value or until the start index becomes greater than the end index. If the desired value is not in the array, the algorithm will terminate when the start index exceeds the end index.

If you want to perform binary search on two arrays instead of a single array to find the median, you can follow the steps below:

1. Store the lengths of the two arrays as m and n.
2. If m is greater than n, swap the two arrays, ensuring that nums1 is always the shorter or equally long array.
3. Perform binary search on nums1 with two pointers, left and right, initialized to 0 and m, respectively.
4. Calculate the middle index, i, as (left + right) / 2.
5. Select the element nums1[i] corresponding to the middle index i and find an index j in nums2 where nums2[j] is greater than the selected element.
6. Divide both arrays into four parts:

   - Left part of nums1: nums1[0:i]
   - Right part of nums1: nums1[i:m]
   - Left part of nums2: nums2[0:j]
   - Right part of nums2: nums2[j:n]
7. Check the following conditions:

   - nums1[i - 1] <= nums2[j] (The maximum value on the left is less than or equal to the minimum value on the right.)
   - nums2[j - 1] <= nums1[i] (The maximum value on the right is less than or equal to the minimum value on the left.)
8. If both conditions are met, you have found the median. Calculate it as follows:

   - If m + n is odd, the median is Math.Max(nums1[i - 1], nums2[j - 1]).
   - If m + n is even, the median is (Math.Max(nums1[i - 1], nums2[j - 1]) + Math.Min(nums1[i], nums2[j])) / 2.0.
9. Return the calculated median.
10. If the conditions are not met, adjust the value of i and repeat the binary search:

   - If nums1[i - 1] is greater than nums2[j], update right = i - 1 to move i to the left.
   - Otherwise, update left = i + 1 to move i to the right.

Repeat these steps until you find the median using binary search. This approach achieves a time complexity of O(log(min(m, n))).

# Complexity
- Time complexity: $$O(log(n+m))$$

- Space complexity: $$O(1)$$

# Code
```
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

```
