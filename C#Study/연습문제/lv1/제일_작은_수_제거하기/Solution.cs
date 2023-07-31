using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        if (arr.Length == 1) return new int[]{-1};
        
        int min = arr.Min();
        int[] answer = new int[arr.Length-1];
        int index = 0;
        
        for (int i=0; i<arr.Length; i++) {
            if (arr[i] != min) 
            {
                answer[index] = arr[i];
                index ++;
            }
        }
        
        return answer;
    }
}
