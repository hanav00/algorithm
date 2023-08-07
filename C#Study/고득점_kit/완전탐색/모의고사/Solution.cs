using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {       
        /*
        1번: 현재 index%5 + 1
        2번: if index%2 == 0, 2
             if index%8 == 1, 1
             if index%8 == 3, 3
             if index%8 == 5, 4
             if index%8 == 7, 5
        3번: 3 1 2 4 5 두 개씩 반복
        */
        int answerSht1 = 0; int answerSht2 = 0; int answerSht3 = 0;
        int answerCnt1 = 0; int answerCnt2 = 0; int answerCnt3 = 0;
        
        for (int i=0; i<answers.Length; i++)
        {
            //아이들 점수 알아내기
            answerSht1 = i%5+1;
            switch (i%8)
            {
                case 1: answerSht2 = 1; break;
                case 3: answerSht2 = 3; break;
                case 5: answerSht2 = 4; break;
                case 7: answerSht2 = 5; break;
                default: answerSht2 = 2; break;
            }
            switch (((i+2)/2)%5)
            {
                case 1: answerSht3 = 3; break;
                case 2: answerSht3 = 1; break;
                case 3: answerSht3 = 2; break;
                case 4: answerSht3 = 4; break;
                default: answerSht3 = 5; break;
            }

            if (answers[i] == answerSht1) answerCnt1++;
            if (answers[i] == answerSht2) answerCnt2++;
            if (answers[i] == answerSht3) answerCnt3++;
        }
        
        int correct = Math.Max(Math.Max(answerCnt1, answerCnt2), answerCnt3);
        List<int> answerList = new List<int>();
        if (answerCnt1 == correct) answerList.Add(1);
        if (answerCnt2 == correct) answerList.Add(2);
        if (answerCnt3 == correct) answerList.Add(3);
        
        return answerList.ToArray();
    }
}
