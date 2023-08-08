using System;

public class Solution {
    public int solution(int[] common) {

        if (common[2]-common[1] == common[1]-common[0])
        {
            return common[common.Length-1] + common[1]-common[0];
        }

        return common[common.Length-1] * common[1]/common[0];

    }
}
