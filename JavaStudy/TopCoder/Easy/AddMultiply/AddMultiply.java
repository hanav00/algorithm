public class AddMultiply {
    public int[] makeExpression(int y) {
        int[] answer = new int[3];
        
        answer[0] = 2;
        answer[1] = 2;
        answer[2] = y-4;
        
        if (answer[2] == 1 || answer[2] == 0) {
            answer[0] = 4;
            answer[1] = 4;
            answer[2] = y-16;
        }
        
        return answer;
    }
}
