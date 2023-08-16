using System;

public class Solution {
    public string solution(int age) {
        string answer = "";
        
        string ageStr = age.ToString();
        
        foreach (char digit in ageStr)
        {
            /*
            string add = digit switch
            {
                '0' => "a",
                '1' => "b",
                '2' => "c",
                '3' => "d",
                '4' => "e",
                '5' => "f",  
                '6' => "g",
                '7' => "h",
                '8' => "i",
                '9' => "j",
                _ => ""
            };*/
            
            string add = "";

            switch (digit)
            {
                case '0':
                    add = "a";
                    break;
                case '1':
                    add = "b";
                    break;
                case '2':
                    add = "c";
                    break;
                case '3':
                    add = "d";
                    break;
                case '4':
                    add = "e";
                    break;
                case '5':
                    add = "f";
                    break;
                case '6':
                    add = "g";
                    break;
                case '7':
                    add = "h";
                    break;
                case '8':
                    add = "i";
                    break;
                case '9':
                    add = "j";
                    break;
                default:
                    add = ""; // 예외 처리를 위한 기본 값 추가
                    break;
            }

            
            answer += add;
        }
        
        return answer;
    }
}
