public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        
        List<IList<int>> result = new List<IList<int>>();

        if (nums.Length < 4)
        {
            return result;
        }

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue; // Skip duplicates
            }

            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1])
                {
                    continue; // Skip duplicates
                }

                int left = j + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[j] + nums[left] + nums[right];

                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });

                        while (left < right && nums[left] == nums[left + 1])
                        {
                            left++; // Skip duplicates
                        }
                        while (left < right && nums[right] == nums[right - 1])
                        {
                            right--; // Skip duplicates
                        }

                        left++;
                        right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }

        return result;
    }
}
