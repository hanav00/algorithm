# Intuition & Approach
I just removed # characters and the characters immediately before # (if # appears at the beginning of a string).

# Complexity
- Time complexity: $$O(n)$$

- Space complexity: $$O(1)$$

# Code
```
public class Solution {
    public bool BackspaceCompare(string s, string t) {
        for (int i = 0; i < s.Length; i++){
            if (s[i] == '#'){
                s = s.Remove(i,1);
                i --;
                if (i > -1){
                    s = s.Remove(i,1);
                    i --;
                }
            }
        }
        for (int i = 0; i < t.Length; i++){
            if (t[i] == '#'){
                t = t.Remove(i,1);
                i --;
                if (i > -1){
                    t = t.Remove(i,1);
                    i --;
                }
            }
        }
        if (s == t) return true;
        return false;
    }
}
```
