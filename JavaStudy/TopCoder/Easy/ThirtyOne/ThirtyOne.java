import java.util.*;

public class ThirtyOne {
	
	public int findWinner(String[] hands) {
		
		String [][] cards1 = new String[hands.length][3];
		for (int i=0; i<hands.length; i++) {
			cards1[i][0] = hands[i].split(" ")[0];
			cards1[i][1] = hands[i].split(" ")[1];
			cards1[i][2] = hands[i].split(" ")[2];
			//System.out.println(Arrays.toString(cards1[i]));
		}
		
		//JQK는 10으로 변환
		String [][] cards = new String[hands.length][3];
		for (int i=0;i<cards.length;i++) {
			for (int j=0; j<3; j++) {
				if (cards1[i][j].equals("J") || cards1[i][j].equals("Q") || cards1[i][j].equals("K")) cards[i][j] = "10";
				else cards[i][j] = cards1[i][j];
			}
		}
		
		//점수를 담을 배열
		double[][] score = new double[cards.length][2];
		for (int i=0;i<cards.length;i++) {
			for (int j=0; j<3; j++) {
				if (cards[i][j].equals("A")) { //A는 따로 체크해서 빼둠
					score[i][1] += 1;
				} else {
					score[i][0] += Integer.parseInt(cards[i][j]);
				}
			}
		}
		
		//3개가 같은 카드면 30.5점
		for (int i=0;i<cards.length;i++) {
			if (cards1[i][0].equals(cards1[i][1]) && cards1[i][0].equals(cards1[i][2])) {
				score[i][0] = 30.5;
				score[i][1] = 0;
			}
		}
		
		//A를 체크한 배열
		double[] finalScore = new double[cards.length];
		for (int i=0;i<cards.length;i++) {
				if (score[i][1] == 0) {
					finalScore[i] = score[i][0];
				} else if(score[i][1] == 1) {
					if (score[i][0] + 11 > 31) finalScore[i] = score[i][0] + 1;
					else finalScore[i] = score[i][0] + 11;
				} else if(score[i][1] == 2) {
					if (score[i][0] + 22 > 31) finalScore[i] = score[i][0] + 12;
					else finalScore[i] = score[i][0] + 22;
				}
		}
		
		//System.out.println(Arrays.toString(finalScore));
		
		double max = 0; int answer = -1;
		for (int i=finalScore.length-1;i>=0; i--) {
			if (finalScore[i] >= max) {
				max = finalScore[i];
				answer = i;
			}
		}
		
		
		return answer;
	}
}
