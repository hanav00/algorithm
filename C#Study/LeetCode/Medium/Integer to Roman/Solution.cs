public class Solution {
    public string IntToRoman(int num) {
        int numLength = num.ToString().Length;
        string answer = "";

        if (numLength >= 4){
            int number = (num / 1000) % 10;
            answer += number switch {
                1 => "M",
                2 => "MM",
                3 => "MMM",
                _ => ""
            };
        }
        if (numLength >= 3){
            int number = (num / 100) % 10;
            answer += number switch {
                1 => "C",
                2 => "CC",
                3 => "CCC",
                4 => "CD",
                5 => "D",
                6 => "DC",
                7 => "DCC",
                8 => "DCCC",
                9 => "CM",
                _ => ""
            };
        }
        if (numLength >= 2){
            int number = (num / 10) % 10;
            answer += number switch {
                1 => "X",
                2 => "XX",
                3 => "XXX",
                4 => "XL",
                5 => "L",
                6 => "LX",
                7 => "LXX",
                8 => "LXXX",
                9 => "XC",
                _ => ""
            };
        }
        if (numLength >= 1){
            int number = num % 10;
            answer += number switch {
                1 => "I",
                2 => "II",
                3 => "III",
                4 => "IV",
                5 => "V",
                6 => "VI",
                7 => "VII",
                8 => "VIII",
                9 => "IX",
                _ => ""
            };
        }
        return answer;
    }
}
