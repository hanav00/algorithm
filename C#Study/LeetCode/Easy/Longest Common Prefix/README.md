# Intuition
The goal is to find the longest common prefix among a given array of strings. We can achieve this by comparing the characters of the strings one by one.

# Approach
1. First, we check if the input array 'strs' is null or empty. If it is, we return an empty string as there is no common prefix.

2. We find the shortest string in the array 'strs' (based on the length of strings). We initialize the 'shortest' variable to the shortest string found.

3. We iterate through the characters of the 'shortest' string. For each character at index 'i', we compare it with the corresponding character in other strings from 'strs'.

4. If we find a character that doesn't match in any of the strings or if a string is shorter than 'i', we return the substring of 'shortest' up to index 'i' as the common prefix.

5. If we successfully iterate through all characters of 'shortest' without finding any mismatches, we return the 'shortest' string as the common prefix.

# Complexity
- Time complexity: $$O(n)$$ 

- Space complexity: $$O(1)$$

# Code
```
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0) return "";

        string shortest = strs.Min(s => s.Length == 0 ? " " : s);

        for (int i = 0; i < shortest.Length; i++)
        {
            char currentChar = shortest[i];
            foreach (string str in strs)
            {
                if (str.Length <= i || str[i] != currentChar)
                    return shortest.Substring(0, i);
            }
        }

        return shortest;
    }
}
```
