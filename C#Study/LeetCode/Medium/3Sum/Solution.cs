public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        if (nums.Length < 3) return new List<IList<int>>();

        Array.Sort(nums);
        var triplets = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] > 0) break; // if the first number is greater than 0, then the sum cannot be 0

            if (i > 0 && nums[i] == nums[i - 1]) continue; // skipping repeated numbers to avoid repeating triples

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    triplets.Add(new List<int>() { nums[i], nums[left], nums[right] });
                    while (left < right && nums[left] == nums[left + 1]) left++; // skipping repeated numbers to avoid repeating triples
                    while (left < right && nums[right] == nums[right - 1]) right--; // skipping repeated numbers to avoid repeating triples
                    left++;
                    right--;
                }
                else if (sum < 0)
                    left++;
                else
                    right--;
            }
        }

        return triplets;    
    }
}
