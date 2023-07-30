public class Solution {
    public int[] solution(long n) {
        string Num = n.ToString();
        int[] answer = new int[Num.Length];
        
        for (int i=Num.Length-1, j=0; i>=0; i--, j++)
        {
             answer[j] = Num[i] - '0'; //0의 아스키코드가 48이므로, 이걸 빼야 정상적으로 나옴
        }
        
        return answer;
    }
}
