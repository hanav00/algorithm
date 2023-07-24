using System;

public class Solution {
    public int solution(int age) {
        if (0 < age && age <= 120)
            return 2022 - age + 1;
        else {
            try {
                throw new Exception ("invalid param");
            }
            catch {
                Console.WriteLine("범위를 벗어남");
                return -1;
            }
        }
    }
}
