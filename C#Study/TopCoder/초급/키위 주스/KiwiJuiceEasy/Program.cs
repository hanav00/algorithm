namespace KiwiJuiceEasy
{
    class KiwiJuiceEasy
    {
        static void Main(string[] args)
        {
            /*
             * 병은 총 N개
             * capacities[i]만큼 담을 수 있는 병에 bottles[i]만큼 주스가 담겨 있음
             * 
             * 리턴값: 병들에 남아있는 주스의 양을 담고 있는 배열
             */

            /*
                # Case# 0
                int[] capacities = new int[] { 20, 20 };
                int[] bottles = new int[] { 5, 8 };
                int[] fromId = new int[] { 0 };
                int[] toId = new int[] { 1 };

                result : [0, 13]

                # Case# 1
                int[] capacities = new int[] { 10, 10 };
                int[] bottles = new int[] { 5, 8 };
                int[] fromId = new int[] { 0 };
                int[] toId = new int[] { 1 };

                result : [3, 10]

                # Case# 2
                int[] capacities = new int[] { 30, 20, 10 };
                int[] bottles = new int[] { 10, 5, 5 };
                int[] fromId = new int[] { 0, 1, 2 };
                int[] toId = new int[] { 1, 2, 0 };

                result : [10, 10, 0]

                # Case# 3
                int[] capacities = new int[] { 14, 35, 86, 58, 25, 62 };
                int[] bottles = new int[] { 6, 34, 27, 38, 9, 60 };
                int[] fromId = new int[] { 1, 2, 4, 5, 3, 3, 1, 0 };
                int[] toId = new int[] { 0, 1, 2, 4, 2, 5, 3, 1 };

                result : [0, 14, 65, 35, 25, 35]

                # Case# 4
                int[] capacities = new int[] { 700000, 800000, 900000, 1000000 };
                int[] bottles = new int[] { 478478, 478478, 478478, 478478 };
                int[] fromId = new int[] { 2, 3, 2, 0, 1 };
                int[] toId = new int[] { 0, 1, 1, 3, 2 };

                result : [0, 156956, 900000, 856956]
             */

            int[] capacities = new int[] { 20, 20 };
            int[] bottles = new int[] { 5, 8 };
            int[] fromId = new int[] { 0 };
            int[] toId = new int[] { 1 };

            int[] answer = Solution(capacities, bottles, fromId, toId);
            Console.WriteLine("return: " + string.Join(", ", answer));
        }

        private static int[] Solution(int[] capacities, int[] bottles, int[] fromId, int[] toId)
        {
            int n = capacities.Length;

            for (int i = 0; i < fromId.Length; i++)
            {
                int fromNum = fromId[i];
                int toNum = toId[i];
                int spaceLeft = capacities[toNum] - bottles[toNum];

                if (bottles[fromNum] >= spaceLeft)
                {
                    bottles[fromNum] -= spaceLeft;
                    bottles[toNum] += spaceLeft;
                }
                else
                {
                    bottles[toNum] += bottles[fromNum];
                    bottles[fromNum] = 0;
                }
            }

            return bottles;
        }
    }
}
