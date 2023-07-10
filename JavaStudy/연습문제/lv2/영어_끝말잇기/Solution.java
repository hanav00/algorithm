import java.util.*;

class Solution {
    public int[] solution(int n, String[] words) {
        int[] answer = new int[2];
        List<String> wordCheck = new ArrayList<>(); wordCheck.add(words[0]);

        int wrong = -1; //wrong은 몇 번째에 틀렸는지
        for (int i=1; i<words.length; i++){
            if (wordCheck.contains(words[i])){
                wrong = i+1; break; //중복
            } else wordCheck.add(words[i]);
            if (words[i].charAt(0) != words[i-1].charAt(words[i-1].length()-1)){
                wrong = i+1; break; //틀림
            }
        }
        if (wrong == -1) return answer; //-1이면 틀린 부분이 없음
        if (wrong%n == 0) answer[0] = n;
        else answer[0] = wrong%n;
        answer[1] = (wrong-1)/n + 1;
        
        return answer;
    }
}
