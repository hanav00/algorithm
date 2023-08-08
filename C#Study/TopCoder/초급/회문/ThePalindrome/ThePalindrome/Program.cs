namespace ThePalindrome
{
    class ThePalindrome
    {
        static void Main(string[] args)
        {
            /*
             테스트 케이스
             string s = "abab";
             return: 5
            
             string s = "abacaba";
             return: 7
            
             string s = "qwerty";
             return: 11
            
             string s = "abdfhdyrbdbsdfghjkllkjhgfds";
             return: 38
             */

            string s = "abdfhdyrbdbsdfghjkllkjhgfds";
            int answer = Solution(s);
            Console.WriteLine(answer);
        }
        static int Solution(string s)
        {
            string reverse =  new string(s.Reverse().ToArray());
            string answer = "";
            for (int i=0; i<s.Length; i++)
            {
                string checkWord = s + reverse.Substring(s.Length - i, i);
                bool check = true;
                for (int k=0; k<(checkWord.Length+1)/2; k++)
                {
                    if (checkWord[k] != checkWord[checkWord.Length - k - 1])
                    {
                        check = false;
                        break;
                    }
                    
                }
                if (check)
                {
                    answer = checkWord;
                    break;
                }
            }
            Console.WriteLine(answer);
            return answer.Length;
        }
    }
}
