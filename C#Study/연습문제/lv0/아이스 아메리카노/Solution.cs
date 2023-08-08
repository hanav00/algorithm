public class Solution {
    public int[] solution(int money) {
        /*
        int[] answer = new int[2];
        answer[0] = money/5500;
        answer[1] = money - answer[0]*5500;
        return answer;
        */
        //한 줄로 만들기
        return new int[]{money/5500, money - money/5500*5500};
    }
}
