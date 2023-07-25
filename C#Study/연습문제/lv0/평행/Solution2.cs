using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[,] dots) {
        HashSet<double> slopes = new HashSet<double>();
        
        for (int i = 0; i < 4; i++) {
            int x1 = dots[i, 0];
            int y1 = dots[i, 1];
            
            for (int j = i+1; j < 4; j++) { // j는 i 다음부터 시작하여 중복을 피함

                int x2 = dots[j, 0];
                int y2 = dots[j, 1];

                if (x1 == x2 || y1 == y2) continue; // 같은 x 또는 y 값을 가진 경우 무시
                double slope = (double)(y2 - y1) / (x2 - x1);
                //Console.WriteLine("i is " + i + ", j is " + j); 
                //Console.WriteLine(slope); 
                if (!slopes.Add(slope)) { // HashSet.Add()는 기존 값이 있을 경우 false를 반환
                    return 1; // 중복이 발생하므로 1을 반환
                }
                
                //slopes.Add(slope);
            }
            
        }
        /*
        foreach (var item in slopes) {
            Console.WriteLine(item);
        }
        
        // 중복값 제거 -> 개수 세기 -> 배열의 길이와 개수 비교
        if (slopes.Distinct().Count() != 6) {
            return 1;
        }*/
        
        return 0;
    }
}
