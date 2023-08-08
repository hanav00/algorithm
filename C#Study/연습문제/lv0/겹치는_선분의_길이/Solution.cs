using System;

public class Solution {
    public int solution(int[,] lines) {
        int answer = 0;

        for (int i = 0; i < lines.GetLength(0); i++) {
            if (Math.Max(lines[i,1],lines[(i+1)%3,1]) - Math.Min(lines[i,0],lines[(i+1)%3,0]) < lines[i,1]-lines[i,0] + lines[(i+1)%3,1]-lines[(i+1)%3,0])
            {
                answer += Math.Min(lines[i,1],lines[(i+1)%3,1]) - Math.Max(lines[i,0],lines[(i+1)%3,0]);
            }
            
        }
        
        //직선 세 개가 겹칠 경우 빼줘야함
        if (Math.Max(Math.Max(lines[0,0],lines[1,0]), lines[2,0]) - Math.Min(Math.Min(lines[0,1],lines[1,1]), lines[2,1])< 0) answer -= (Math.Min(Math.Min(lines[0,1],lines[1,1]), lines[2,1])-Math.Max(Math.Max(lines[0,0],lines[1,0]), lines[2,0]))*2;
        
        return answer;
    }
}
