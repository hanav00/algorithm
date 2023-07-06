package greedy.체육복;

class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = 0;
        
        //가지고 있는 체육복 수로 배열을 새로 만들자
        int[] clothCount = new int[n];
        
        //처음에는 모두 1개의 체육복을 가지고 있다고 가정
        //lost와 같으면 -1
        //reserve와 같으면 +1
        for (int i=0; i<n; i++) clothCount[i] = 1;
        for (int i : lost) clothCount[i-1]--;
        for (int i : reserve) clothCount[i-1]++;

        for (int i=0; i<n; i++) {
            if (clothCount[i] == 0) { //체육복이 없는 친구는
                if (i>0 && clothCount[i-1] == 2) { //앞친구한테 빌리기
                    clothCount[i] ++; clothCount[i-1] --;
                } else if (i+1<n && clothCount[i+1] == 2) { //앞친구한테 빌리기
                    clothCount[i] ++; clothCount[i+1] --;
                }
            }
        }//end of for i

        //0이 아닌 값 세기
        for (int i=0; i<n; i++) {
            if (clothCount[i] > 0)
                answer ++;
        }
        
        return answer;
    }
}