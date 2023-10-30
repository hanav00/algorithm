public class Solution {
    public int RomanToInt(string s) {
        int[] intArray = new int[s.Length];
        for (int i = 0; i < s.Length; i++) {
            intArray[i] = ConvertToInt(s[i]);
        }

        int answer = 0;
        for (int i = 0; i < intArray.Length; i++) {
            if (i < intArray.Length - 1 && intArray[i] < intArray[i + 1]) {
                answer -= intArray[i];
            } else {
                answer += intArray[i];
            }
        }

        return answer;
    }

    public int ConvertToInt(char a) {
        int num = a switch {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };
        return num;
    }
}
