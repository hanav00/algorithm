package dfs_bfs.타겟_넘버;

class Solution {
    
    /*0. 문제 이해하기: [부호1] [숫자2] [부호2] [숫자2] .. [부호5] [숫자5] 
        이 때 부호에는 +와 -만 들어감(2^5개의 경우의 수)
        모든 경우의 수를 계산하고 그 중 target number와 같은 경우의 개수
    */
    
    /*1. 더하기 빼기 반복 .. 인데 함수가 계속 반복되므로 
        한 배열을 함수 5번 반복하면 됨
        근데 그럼 파람으로 몇 번째 인덱스 숫자인지랑 계산값도 필요하니까..
        새로운 함수가 하나 더 필요함
    */
    int index = 0;
    int result = 0;
    int answer = 0;
    int target = 0;
    
    //5. 입력받는 numbers와 target을 반복함수에 넣어줌
    public int solution(int[] numbers, int target) {
        addOrSubstract(numbers, target, 0, 0);
        return answer;
    }
    
    //2. 함수 설정..
    public void addOrSubstract(int[] arr, int tar, int index, int result) {
        //4. 5개 다 했을 때
        if(index == arr.length) {
            //result가 target 값이면
            if(result == tar) {
                answer ++; 
            }
            return; //종료
        }//end of roop

        //3. 5개 다 안한 상태면
        addOrSubstract(arr, tar, index + 1, result + arr[index]); //더하거나
        addOrSubstract(arr, tar, index + 1, result - arr[index]); //빼거나
    }
    
}