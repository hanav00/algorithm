using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] numbers) {
        Dictionary<int, int> check = new Dictionary<int, int>();
        for (int i=0; i<10; i++){
            check.Add(i,1);
        }
        
        foreach (int num in numbers){
            check[num] = check[num] - 1;
        }
        
        int answer = 0;
        foreach (KeyValuePair<int, int> item in check ){
            answer += item.Key * item.Value;
        }
        return answer;
    }
}
