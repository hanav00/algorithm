public class Solution {
    public int LengthOfLongestSubstring(string s) {
        char[] sArray = s.ToCharArray();
        int length = sArray.Length;
        int answer = (length > 0) ? 1 : 0;

        HashSet<char> set = new HashSet<char>();

        for (int i=0; i<length; i++){
            for (int j=i; j<length; j++){
                int before = set.Count;
                set.Add(sArray[j]);
                int after = set.Count;
                if (before == after){
                    answer = Math.Max(answer, after);
                    set.Clear();
                    break;
                }
            }
        }

        return answer;
    }
}
