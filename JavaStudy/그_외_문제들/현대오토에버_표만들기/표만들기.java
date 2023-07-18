public class 표만들기 {
    public static void main (String[] args) {
        int[] blocks = {2, 2, 1, 1};
        String result = Solution(3, 2, blocks);
        System.out.println(result);
    }
    
    public static String Solution(int row, int column, int[] block) {
        /*
        +-+-+
        |.|.|
        +-+-+          
        */

        String answer = "";
        int blockNum = 0;
        // 표 만들기
        for (int i = 0; i < row; i++) {
            answer += "+";
            for (int j = 0; j < column; j++) {
                answer += "-+";
            }
            answer += "\n|";
            
            for (int j = 0; j < column; j++) {
                int endPoint = 0;
                //블록 수 2n-1만큼 . 찍어야 함
                int sum = 0;
                for (int k = blockNum; k < block.length; k++) {
                    //칸 수가 열 수와 같으면 break
                    if (sum == column) {endPoint = 1; break; }

                    for (int m = 0; m < 2*block[k]-1; m++) answer += ".";
                    
                    sum+= block[blockNum]; blockNum ++; 
                    answer += "|";
                }
                if (endPoint == 1) break;
            }
            answer += "\n";
        }
        answer += "+";
        for (int j = 0; j < column; j++) {
            answer += "-+";
        }
        return answer;
    }
}
