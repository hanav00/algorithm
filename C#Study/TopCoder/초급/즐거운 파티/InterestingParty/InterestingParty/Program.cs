namespace InterestingParty
{
    class InterestingParty
    {
        static void Main(string[] args)
        {
            /*
             테스트케이스
            string[] first = new string[] { "fishing", "gardening", "swimming", "fishing" };
            string[] second = new string[] { "hunting", "fishing", "fishing", "biting" };
            return: 4

            string[] first = new string[] { "variety", "diversity", "loquacity", "courtesy" };
            string[] second = new string[] { "talking", "speaking", "discussion", "meeting" };
            return: 1

            string[] first = new string[] { "snakes", "programming", "cobra", "monty" };
            string[] second = new string[] { "python", "python", "anaconda", "python" };
            return: 3

            string[] first = new string[] { "t", "o", "p", "c", "o", "d", "e", "r", "s", "i", "n", "g", "l", "e", "r", "o", "u", "n", "d", "m", "a", "t", "c", "h", "f", "o" ,"u", "r", "n", "i" };
            string[] second = new string[] { "n", "e", "f", "o", "u", "r", "j", "a", "n", "u", "a", "r", "y", "t", "w", "e", "n", "t", "y", "t", "w", "o", "s", "a", "t", "u" ,"r", "d", "a", "y" };
            return: 6
             */

            string[] first = new string[] { "t", "o", "p", "c", "o", "d", "e", "r", "s", "i", "n", "g", "l", "e", "r", "o", "u", "n", "d", "m", "a", "t", "c", "h", "f", "o", "u", "r", "n", "i" };
            string[] second = new string[] { "n", "e", "f", "o", "u", "r", "j", "a", "n", "u", "a", "r", "y", "t", "w", "e", "n", "t", "y", "t", "w", "o", "s", "a", "t", "u", "r", "d", "a", "y" };

            int answer = Solution(first, second);
            Console.WriteLine("return: " + answer);
        }

        private static int Solution(string[] first, string[] second)
        {
            Dictionary<string, int> hobbyCnt = new Dictionary<string, int>();
            for (int i=0; i<first.Length; i++)
            {
                if (hobbyCnt.ContainsKey(first[i])) hobbyCnt[first[i]]++;
                else hobbyCnt.Add(first[i], 1);  
            }
            for (int i = 0; i < second.Length; i++)
            {
                if (hobbyCnt.ContainsKey(second[i])) hobbyCnt[second[i]]++;                  
                else hobbyCnt.Add(second[i], 1);
            }
            int maxNum = 1;
            foreach (int s in hobbyCnt.Values)
            {
                if (s > maxNum) maxNum = s;
            }
            return maxNum;
        }
    }
}