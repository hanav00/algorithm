# Intuition
The goal is to find a substring without repeating characters, which led me to consider using a HashSet since it cannot contain duplicate characters.

# Approach
When the same element is inserted into a HashSet, it will not be added. And this means the count of elements in the HashSet will remaining the same. If the count before and after adding a character to the HashSet is the same, it indicates that the character is repeated. In such cases, I updated the length of the maximum substring (which is "answer") and moved on to the next character.

Test cases included `s=""` and `s=" "`, and because of these test cases, I initialized the answer based on the length of the string `s`.

# Complexity
- Time complexity: $$O(n^2)$$

- Space complexity: $$O(n)$$

# Code
```
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
```
