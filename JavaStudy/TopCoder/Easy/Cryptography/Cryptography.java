public class Cryptography{
    public long encrypt(int[] numbers){
        
        long mul = 1;
        
        for (int i=0; i<numbers.length; i++){
        	mul *= (long)numbers[i];
        }
        
        long answer = mul;
        for (int i=0; i<numbers.length; i++){
        	if((long)mul/numbers[i]*(numbers[i]+1) > answer) answer = (long)mul/numbers[i]*(numbers[i]+1);
        }
        
    	return answer;
    }
}
