namespace InterestingDigit
{
    class InterestingDigit
    {
        static void Main(string[] args)
        {
            /*
             테스트 케이스
            int baseNum = 10;
            return: {3,9}

            int baseNum = 3;
            return: {2}

            int baseNum = 9;
            return: {2, 4, 8}

            int baseNum = 26;
            return: {5, 25}

            int baseNum = 30;
            return: {29}
             */

            int baseNum = 30;
            int[] answer = Solution(baseNum);
            Console.WriteLine(string.Join(", " , answer));
        }

        private static int[] Solution(int baseNum)
        {
            List<int> answer = new List<int>();
            for (int i=2; i<baseNum; i++)
            {
               bool ok = true;
               for (int k1 = 0; k1 < baseNum; k1++)
                {
                    for (int k2 = 0; k2 < baseNum; k2++)
                    {
                        for (int k3 = 0; k3 < baseNum; k3++)
                        {
                            if((k1 + k2*baseNum +  k3*baseNum*baseNum) % i == 0 && (k1+k2+k3) % i != 0)
                            {
                                ok = false; break;
                            }
                        }
                        if (!ok) break;
                    }
                    if (!ok) break;
                }
               if (ok) answer.Add(i);
            }
            return answer.ToArray();
        }
    }
}