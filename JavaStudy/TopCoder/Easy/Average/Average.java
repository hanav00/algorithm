import java.util.*;

public class Average{
    public int belowAvg(int[] math, int[] verbal){
        int[] total = new int[math.length];
        int sum = 0;
        
        for (int i=0; i<math.length; i++){
        	total[i] += math[i] + verbal[i];
          	sum += math[i] + verbal[i];
        }
        
        //System.out.println(Arrays.toString(total));
        
        double average = (double)sum / math.length;
        
        int answer = 0;
        for (int i=0; i<total.length; i++){
        	if (total[i] < average) answer++;
        }
        
        return answer;
    }
}
