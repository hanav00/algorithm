using System;

public class Solution {
    public int solution(int M, int N) {      
  
        if (0<M && M<100 && 0<N && N<100)
            return (M-1) + (N-1) * M;
        else {
            try{
                throw new Exception ("invalid param");
            } catch {
                Console.WriteLine("범위가 벗어남");
                return -1;
            }
        }
    }
}
