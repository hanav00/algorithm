package Easy;

public class ThePalindrome {
	public int find(String s) {
		
		String answer = check(s,0,s);
		return answer.length();
	}
	
	public String check(String word, int current, String firstWord) {
		if (word.length() > 50) return "stopped";
		for (int i=current; i<word.length(); i++) {
			if (word.charAt(i) != word.charAt(word.length()-1-i)) {
				word = firstWord + word.charAt(i) + word.substring(firstWord.length());
				
				return check(word, current + 1, firstWord);
			}
		}
		return word;
	}
	

	public static void main(String[] args) {
		ThePalindrome a = new ThePalindrome();
		
		String n1 = "abab";
		String n2 = "abacaba";
		String n3 = "qwerty";
		String n4 = "abdfhdyrbdbsdfghjkllkjhgfds";
		System.out.println("answer: " + a.find(n1));
		System.out.println("answer: " + a.find(n2));
		System.out.println("answer: " + a.find(n3));
		System.out.println("answer: " + a.find(n4));
	}

}
