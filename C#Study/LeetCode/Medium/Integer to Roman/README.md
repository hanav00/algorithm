# Intuition
The core idea of this problem is to convert the given integer into a Roman numeral. Understand the rules for converting to Roman numerals and break down the given integer into its thousands, hundreds, tens, and ones places.

# Approach
1. Calculate the number of digits in the given integer num.
2. Calculate the thousands place digit of num and add "M," "MM," or "MMM" based on the digit value.
3. Calculate the hundreds place digit of num and add "C," "CC," "CCC," "CD," "D," "DC," "DCC," "DCCC," or "CM" based on the digit value.
4. Calculate the tens place digit of num and add "X," "XX," "XXX," "XL," "L," "LX," "LXX," "LXXX," or "XC" based on the digit value.
5. Calculate the ones place digit of num and add "I," "II," "III," "IV," "V," "VI," "VII," "VIII," or "IX" based on the digit value.
6. Concatenate the strings obtained at each of the above steps to form the final Roman numeral string.

# Complexity
- Time complexity: $$O(1)$$

- Space complexity: $$O(1)$$

# Code
```
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

```
