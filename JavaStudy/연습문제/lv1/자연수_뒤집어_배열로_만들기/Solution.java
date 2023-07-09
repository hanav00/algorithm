import java.util.*;

class Solution {
    public int[] solution(long n) {
        
        String str = Long.toString(n);
        String reverse = "";
        
        for (int i = str.length() - 1; i >= 0; i--) {
            reverse = reverse + str.charAt(i);
        }
        String[] arr = reverse.split("");
        
        int[] answer = new int[arr.length];
        for (int i = 0; i < arr.length; i++) {
            answer[i] = Integer.parseInt(arr[i]);
        }
        return answer;
    }
}
