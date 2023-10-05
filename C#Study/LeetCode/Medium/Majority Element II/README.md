# First Method (using Dictionary)

### Intuition
Thinking of counting all elements and checking if they are greater than n/3 is straightforward.

### Approach
I employed a Dictionary to store the elements and their respective counts.

### Complexity
- Time complexity: $$O(n)$$

- Space complexity: $$O(n)$$

### Code
```
public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int n = nums.Length;
        Dictionary<int, int> checkNums = new Dictionary<int, int>();

        foreach (int k in nums){
            if (checkNums.ContainsKey(k)){
                checkNums[k]++;
            }
            else{
                checkNums.Add(k,1);
            }
        }

        List<int> answer = new List<int>();
        foreach (KeyValuePair<int, int> k in checkNums){
            int key = k.Key;
            int value = k.Value;
            if (value > n/3){
                answer.Add(key);
            }
        }
        return answer;
    }
}
```


# Second Method (using Boyer-Moore Majority Vote Algorithm)

### Intuition
I decided that we can employ the Boyer-Moore Majority Vote algorithm, which is one of the algorithms for finding the element with the highest frequency in a given array.

### Approach
Boyer-Moore Majority Vote algorithm is more effective than using Dictionary - since its time and space complexity is O(n), O(1) respectively.
The core idea of the algorithm is as follows:

- Maintain a candidate element and its count.
- Traverse the array and compare the current element with the candidate element.
- If the current element is the same as the candidate element, increase the candidate's count.
- If the current element is different from the candidate element, decrease the candidate's count.
- Whenever the candidate's count becomes 0, set the current element as a new candidate.
- After traversing the entire array, the last selected candidate may be the majority element, so select it as the final candidate.
- Verify the final candidate to confirm if it is indeed the majority element (this step is performed if necessary).

### Complexity
- Time complexity: $$O(n)$$

- Space complexity: $$O(1)$$

### Code
```
public class Solution {
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
```
