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
            int index = s.Length;
            int n = 0;

            for (int i = 0; i < index - 1 - n; i++)
            {
                if (s[i] != s[index - 1 - n])
                {
                    s = s.Substring(0, index) + s[i] + s.Substring(index, i);
                    Console.WriteLine(s);
                }
                else
                {
                    n++;
                }
            }

            return s.Length;
        }

    }
}