public class Solution1 {
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
