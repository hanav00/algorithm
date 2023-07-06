package 연습문제.lv1.가장_가까운_같은_글자;

class Solution {
    public int[] solution(String s) {

        //하나씩 넣기
        String[] word = s.split("");
        int[] answer = new int[word.length];
        answer[0] = -1;
        
        for (int i=1; i<word.length; i++) {
            for (int j=i-1; j>=0; j--) {
                if (word[i].equals(word[j])) {
                    answer[i] = i-j; break;
                } else { answer[i] = -1;}
            }
        }
        return answer;
    }
}