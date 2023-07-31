using System;

public class Solution {
    public string solution(string s) {
        string[] numbersAsStrings = s.Split(' ');
        int[] Numbers = new int[numbersAsStrings.Length];
        
        for (int i=0; i<numbersAsStrings.Length; i++)
        {
            Numbers[i] = Convert.ToInt32(numbersAsStrings[i]);
        }
        
        int max = Numbers[0];
        int min = Numbers[0];
        
        for (int i=1; i<Numbers.Length; i++)
        {
            if (max < Numbers[i]) max = Numbers[i];
            if (min > Numbers[i]) min = Numbers[i];
        }
        return min + " " + max;
    }
}
