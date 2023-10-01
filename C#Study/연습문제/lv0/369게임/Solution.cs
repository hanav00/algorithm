using System;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        string orderToString = order.ToString();
        for (int i=0; i<orderToString.Length; i++){
            if (orderToString[i] == '3' || orderToString[i] == '6' || orderToString[i] == '9'){
                answer ++;
            }
        }
        return answer;
    }
}
