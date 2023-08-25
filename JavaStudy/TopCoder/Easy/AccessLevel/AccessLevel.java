public class AccessLevel {

	public String canAccess(int[] rights, int minPermission) {
		String answer = "";
		for (int i=0; i<rights.length; i++){
			if (rights[i] >= minPermission) {
				answer += "A";
			} else {
				answer += "D";
			}
		}
		return answer;
	}
}
