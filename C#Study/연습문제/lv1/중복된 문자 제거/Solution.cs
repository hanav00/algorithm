using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string) {
        HashSet<string> set = new HashSet<string>();
        
        for (int i=0; i<my_string.Length; i++)
        {
            set.Add(my_string[i].ToString());
        }
        
        return string.Join("", set);
    }
}
