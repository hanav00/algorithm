public class AppleWord {
	public int minRep(String word) {
		//a, l, e, p(2개이상) -> 최소 5글자 이상
		if (word.length() < 5) return -1;
		
		//편의상 모두 대문자로 변경
		word = word.toUpperCase();
		
		int answer = 0;
		
		//A, L, E는 위치 고정
		if (word.charAt(0) != 'A') answer ++;
		if (word.charAt(word.length()-2) != 'L') answer ++;
		if (word.charAt(word.length()-1) != 'E') answer ++;
		
		//그 사이는 다 P로 변경
		 for (int i=1; i<word.length()-2; i++) {
			 if (word.charAt(i) != 'P') answer ++;
		 }
		
		
		return answer;
	}
}
