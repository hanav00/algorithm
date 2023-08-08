namespace Cryptography
{
    class Cryptography
    {
        static void Main(String[] args)
        {
            /*
             테스트 케이스
             int[] numbers = new int[] { 1, 2, 3 };
             return: 12

            int[] numbers = new int[] { 1, 3, 2, 1, 1, 3 };
             return: 36

            int[] numbers = new int[] { 1000, 999, 998, 997, 996, 995 };
             return: 986074810223904000

            int[] numbers = new int[] { 1, 1, 1, 1 };
             return: 2
             */

            int[] numbers = new int[] { 1000, 999, 998, 997, 996, 995 };
            long answer = Solution(numbers);
            Console.WriteLine(answer);
        }

        private static long Solution(int[] numbers)
        {
            long mul = 1;
            foreach (int n in numbers)
            {
                mul *= n;
            }

            long max = mul;

            for (int i = 0; i<numbers.Length; i++)
            {
                if (mul / numbers[i] * (numbers[i] + 1) > max) max = mul / numbers[i] * (numbers[i] + 1);
            }

            return max;
        }
    }
}