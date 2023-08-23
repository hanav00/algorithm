public class Solution {
    public string solution(string[] seoul) {
        int num = 0;
        for (int i=0; i<seoul.Length; i++)
        {
            if (seoul[i] == "Kim") 
            {
                num = i;
                break;
            }
        }
        
        return "김서방은 " + num + "에 있다";
    }
}
