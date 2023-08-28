using System;

public class Solution {
    public int solution(int[] array, int n) {
        int[] check = new int[array.Length];
        int i=0;
        int min = 100;
        int index = -1;
        foreach (int num in array)
        {
            check[i] = Math.Abs(num-n);
            if (min > check[i])
            {
                min = check[i];
                index = i;
            } 
            else if (min == check[i] && array[i] < array[index])
            {
                index = i;
            }
            i++;
        }
        return array[index];
    }
}
