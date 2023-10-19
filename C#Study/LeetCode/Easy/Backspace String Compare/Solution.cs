public class Solution {
    public bool BackspaceCompare(string s, string t) {
        for (int i = 0; i < s.Length; i++){
            Console.WriteLine("--" + s);
            if (s[i] == '#'){
                s = s.Remove(i,1);
                i --;
                Console.WriteLine(s);
                if (i > -1){
                    s = s.Remove(i,1);
                    Console.WriteLine(s);
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
