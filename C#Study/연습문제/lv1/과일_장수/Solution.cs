using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        
        //score 정렬
        Array.Sort(score);
        
        for (int i=score.Length-1; i>=0; i-=m) 
        {
            if (i >= m-1) // 담으려는 개수보다 많이 남았을 경우, 더 담음
            {
                answer += score[i-m+1] * m;
            } 
            else break;
        }
        
        return answer;
    }
}
