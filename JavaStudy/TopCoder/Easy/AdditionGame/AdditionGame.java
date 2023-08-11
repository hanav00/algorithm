public class AdditionGame {
	
	public int getMaximumPoints(int A, int B, int C, int N) {

		return game(A,B,C,1,0,N);

	}
	
	public int game(int A, int B, int C, int count, int totalScore,int N) {
		
		if (count > N) return totalScore;
		
		System.out.println(count + "번 째 선택입니다. 현재 점수: " + totalScore);
		int[] max = findMax(A,B,C);
		totalScore += max[1];
		System.out.println("점수를 획득하셨습니다! 현재 점수: " + totalScore);
		if (max[0] == 1 && A>=1) A--;
		else if (max[0] == 2 && B>=1) B--;
		else if (max[0] == 3 && C>=1) C--;
		
		count ++;
		return game(A,B,C,count, totalScore,N);

	}
	
	public int[] findMax (int a, int b, int c) {
		int[] max = new int[3];
		max[1] = Math.max(Math.max(a, b), c);
		
		if (a == max[1]) max[0] = 1;
		else if(b == max[1]) max[0] = 2;
		else max[0] = 3;
		
		System.out.println("현재 가장 큰 숫자: " + max[1]);
		
		return max;
	}
}
