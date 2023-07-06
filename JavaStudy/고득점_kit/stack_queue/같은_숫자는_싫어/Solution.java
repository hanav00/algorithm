package stack_queue.같은_숫자는_싫어;

public class Solution {
    public int[] solution(int[] arr) {
        
        //1. result 배열 선언
        int n = arr.length;
        int[] result = new int[n];
        
        //2. arr의 첫번째 값을 result에 넣음
        int index = 0;
        result[index++] = arr[0]; //이 식에서는 0으로 계산되고, 계산이 끝나면 1
        
        //3. 앞의 숫자와 같지 않으면 배열에 넣기
        for (int i = 1; i < n; i++) {
            if (arr[i] != arr[i - 1]) {
                result[index++] = arr[i];
            }
        }

        //4. 나머지 0을 제거하여 결과 배열의 크기 조정
        int[] finalResult = new int[index];
        System.arraycopy(result, 0, finalResult, 0, index);

        return finalResult;
    }
}