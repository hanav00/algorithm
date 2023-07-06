package hash.완주하지_못한_선수;

import java.util.*;

class Solution {
    public String solution(String[] participant, String[] completion) {
        /*0. 문제 이해: participant 배열 - completion 배열 해서 남는거 출력
            a b c 순서대로 정렬하고 두 개의 배열 앞에서부터 비교
            다른 순간 
            a b c c c d : participant
            a b c c d -> c 출력
            a b c c c -> 다 같으므로 마지막이 문제
        */
        String answer = "";
        int check = 0;
        
        //1. 두 배열 정렬
        Arrays.sort(participant);
        Arrays.sort(completion);
        
        //2. 두 배열 비교
        for (int i=0; i<participant.length-1; i++) {
            //3. 두 개가 달라진 순간 !
            if (!participant[i].equals(completion[i])) {
                answer = participant[i];
                check ++;
                break;
            }
        }
        
        //4. check가 0이다 = for문 안에서 다 같았다 = 마지막이 문제
        if (check == 0) {
            answer = participant[participant.length -1];
        }

        return answer;
    }
}
