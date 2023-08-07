using System;

public class Solution {
    public int solution(int[,] sizes) {
        
        //1. 가로는 길게, 세로는 짧게 설정
        for (int i=0; i<sizes.GetLength(0); i++) 
        {
            if(sizes[i,0] < sizes[i,1]) //세로가 더 큰 경우에만 둘 자리 바꿈
            {
                int longer = sizes[i,1];
                int shorter = sizes[i,0];
                sizes[i,0] = longer;
                sizes[i,1] = shorter;
            }
        }
        
        //2. 가로 중 제일 긴 것
        int maxLength = sizes[0,0];
        int maxHeight = sizes[0,1];
        for (int i=0; i<sizes.GetLength(0); i++)
        {
            if (sizes[i,0] > maxLength) maxLength = sizes[i,0];
            if (sizes[i,1] > maxHeight) maxHeight = sizes[i,1];
        }        
        /*
        int rows = sizes.GetLength(0); // 이차원 배열의 행 수
        int cols = sizes.GetLength(1); // 이차원 배열의 열 수

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(sizes[i, j] + " ");
            }
            Console.WriteLine();
        }
        */
        return maxLength * maxHeight;
    }
}
