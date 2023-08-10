package Easy;

import java.util.Arrays;

public class AdditionCycles {
    public int cycleLength(int n) {
        int count = 0;
        return makeNum(n, n, count);
    }

    public int makeNum(int n, int now, int count) {
        count++;
        // 1. 숫자 분리하기
        int firstNum = now / 10;
        int secondNum = now % 10;

        // 2. 더하기
        int addDigits = firstNum + secondNum;

        // 3. 분리해서 이어붙이기
        int answer = secondNum * 10 + (addDigits % 10);

        // 4. 아니면 다시 돌리기
        if (answer != n) {
            return makeNum(n, answer, count);
        } else {
            return count;
        }
    }


	public static void main(String[] args) {
		AdditionCycles a = new AdditionCycles();
		
		int n1 = 26;
		int n2 = 55;
		int n3 = 0;
		int n4 = 71;
		System.out.println("answer: " + a.cycleLength(n1));
		System.out.println("answer: " + a.cycleLength(n2));
		System.out.println("answer: " + a.cycleLength(n3));
		System.out.println("answer: " + a.cycleLength(n4));
	}
}
