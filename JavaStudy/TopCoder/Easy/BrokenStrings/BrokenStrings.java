public class BrokenStrings {

	public int buyStrings(int n, String[] stringCosts) {
		
		int[][] costs = new int[stringCosts.length][2];
		
		//1. stringCosts에서 가격 분리하기
		for (int i=0; i<stringCosts.length; i++) {
			costs[i][0] = Integer.parseInt(stringCosts[i].split(" ")[0]);
			costs[i][1] = Integer.parseInt(stringCosts[i].split(" ")[1]);
		}

		//2. 가격에서 패키지 미니멈, 단품 미니멈 가격 구하기
		int min6=1000; int min1=1000;
		for(int i=0; i<costs.length; i++) {
			if (min6 > costs[i][0]) {min6 = costs[i][0];}
			if (min1 > costs[i][1]) {min1 = costs[i][1];}
		}
		
		//가격 구하기 (패키지가 싼 곳+단품)
		int sum = 0;
		int number = n;
		if (number>=6) {
			sum = (number/6)*min6;
			number -= (number/6)*6;
		}
		sum += number*min1;
		
		//가격 구하기 (패키지로만)
		int sum1 = 0;
		if (n%6 != 0) {
			sum1 = (n/6+1)*min6;
		} else {
			sum1 = n/6*min6;
		}
		
		//가격 구하기 (단품으로만)
		int sum2 = n*min1;
		
		int answer = Math.min(sum, Math.min(sum1, sum2));

		return answer;
	}
}
