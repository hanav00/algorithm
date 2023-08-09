public class AlmostPerfectNumber {
    public int count(int left, int right, int k){
    	int answer = 0;
        
        for (int i=left; i<=right; i++){
            //약수 모두 구해서 더하기
            int s = 0;
            for (int n=1; n<i; n++) {
            	if (i%n == 0) s += n;
            }
        	if (-1*k <= Math.abs(i-s) && Math.abs(i-s) <= k) answer ++;
        }
        return answer;
    }
}
