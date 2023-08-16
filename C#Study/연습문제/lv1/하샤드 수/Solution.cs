using System;

public class Solution {
    public bool solution(int x) {
        int sum = 0;
        
        string str = x.ToString();
        for (int i = 0; i < str.Length; i++)
        {
            sum += int.Parse(str[i].ToString());
        }
        //Console.WriteLine(sum);
        return x % sum == 0;
    }
}
