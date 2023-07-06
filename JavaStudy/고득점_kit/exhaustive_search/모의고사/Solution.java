package exhaustive_search.모의고사;

import java.util.*;

class Solution {
    public int[] solution(int[] answers) {
        /*0. 문제 이해: answer과 1 2 3번의 답안지 비교해서 점수 내고,
            점수가 제일 높은 사람 리턴
            점수가 동일하면 오름차순 정렬
        */
        
        //1. 1 2 3 번의 답안지 만들기
        int[] one = new int[answers.length];
        int[] two = new int[answers.length];
        int[] three = new int[answers.length];
        
        //1. 1번은 12345 반복
        int test = 1;
        for(int n=0; n<answers.length; n++) {
            one[n] = test;
            test ++;
            if (test > 5) {
                test = 1; //5가 되면 1로 초기화
            }
        }
        
        //2. 2번은 짝수 인덱스에는 2, 홀수 인덱스에는 1 3 4 5 반복
        two[0] = 2;
        for(int n=0; n<answers.length; n++) {
            if(n % 2 == 0) { //일단 짝수면 2
                two[n] = 2;
            } else if (n % 8 == 1) {
                two[n] = 1;
            } else if (n % 8 == 3) {
                two[n] = 3;
            } else if (n % 8 == 5) {
                two[n] = 4;
            } else if (n % 8 == 7) {
                two[n] = 5;
            }
        }
        
        //3. 3번은 33 11 22 44 55 반복
        three[0] = 3;
        for(int n=0; n<answers.length; n++) {
            switch (n%10) {
                case 0:
                case 1:
                    three[n] = 3;break;
                case 2:
                case 3:
                    three[n] = 1;break;
                case 4:
                case 5:
                    three[n] = 2;break;
                case 6:
                case 7:
                    three[n] = 4;break;
                case 8:
                case 9:
                    three[n] = 5;break;
            }
        }
        
        //4. 문제지 답안지 비교
        int oneScore = 0;
        int twoScore = 0;
        int threeScore = 0;
        for(int i=0; i< answers.length; i++) {
            if (one[i] == answers[i]) {
                oneScore ++;
            }
            if (two[i] == answers[i]) {
                twoScore ++;
            }
            if (three[i] == answers[i]) {
                threeScore ++;
            }
        }
        
        //5. 최고점은
        int highest = Math.max(oneScore, Math.max(twoScore, threeScore));
        
        //6. 최고점과 동일한 점수를 가진 사람 수 세기
        ArrayList<Integer> answerList = new ArrayList<>();
        if(oneScore == highest) { answerList.add(1); }
        if(twoScore == highest) { answerList.add(2); }
        if(threeScore == highest) { answerList.add(3); }
        Collections.sort(answerList);
        
        //7. ArrayList를 Array로 변환하기..
        int[] answer = new int[answerList.size()];
        for (int i=0; i<answerList.size(); i++) {
            answer[i] = answerList.get(i).intValue();
        }
        
        return answer;

    }
}
