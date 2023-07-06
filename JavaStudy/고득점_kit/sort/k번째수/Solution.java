package sort.k번째수;

import java.util.*;

class Solution {
    public int[] solution(int[] array, int[][] commands) {

        int row = commands.length; //행의 개수 구하기
        int n = 0;
        ArrayList<Integer> result = new ArrayList<>();
        
        //2. for문으로 commands에 있는 i, j, k값 순서대로 꺼내기
        for (n=0; n<row; n++) {
            int i = commands[n][0];
            int j = commands[n][1];
            int k = commands[n][2];
            //Check
            //System.out.println("i:" + i +" j:" + j +" k:" + k);

            //3. 배열 i~j만큼 자르기
            int[] newArr = Arrays.copyOfRange(array, i-1, j);
            //Check
            //System.out.println(Arrays.toString(newArr));

            //4. 배열 정렬하기
            Arrays.sort(newArr);

            //5. index[k-1]인 수를 결과값 배열에 add
            int number = newArr[k-1];
            result.add(number);
        }

        //6. result를 int[]로 변환 후 출력하기
        int[] answer = new int[result.size()];
        for (int i = 0; i < result.size(); i++) {
            answer[i] = result.get(i);
        }

        return answer;
    }
}
