using System;
using System.Collections;
using System.Linq;

public class Solution {
    public int[] solution(string my_string) {
        ArrayList list = new ArrayList();
        for (int i = 0; i < my_string.Length; i++) {
            if (char.IsDigit(my_string[i])) {
                int num = Convert.ToInt32(my_string[i].ToString());
                list.Add(num);
            }
        }
        int[] arr = (int[])list.ToArray(typeof(int));
        Array.Sort(arr);
        return arr;
    }
}
