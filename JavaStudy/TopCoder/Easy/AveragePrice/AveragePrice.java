import java.util.*;

public class AveragePrice {
	public  double nonDuplicatedAverage(int[] prices) {
	   HashSet<Integer> priceCheck = new HashSet<Integer>();
	   for (int i=0; i<prices.length; i++) {
		   priceCheck.add(prices[i]);
	   }
	   double answer = 0;
	   for (int num : priceCheck) {
		   answer += num;
	   }
	   return answer/priceCheck.size();
	}
}
