<h1>키위 주스</h1>

타로는 맛있는 키위 주스를 준비했습니다.
타로는 0부터 N-1이라 이름을 붙인 N개의 병에 키위 주스를 넣었습니다.
이때 i번째의 병의 용량은 capacities[i] 리터이며 타로가 i번째 병에 넣은 키위 주스의 양을 bottles[i] 리터라고 합니다.

타로는 병에 키위 주스를 재분배하려고 하며, 0부터 M-1까지 M회 조작합니다.
i번째의 조작은 타로가 병 fromId[i]부터 병 toId[i]에 키위 주스를 넣는 것을 의미합니다.
병 fromId[i]가 비어 있거나 병 toId[i]가 꽉 차 있는 순간, 타로는 더 이상 키위 주스를 넣지 않습니다.

N개의 요소를 가진 정수 배열 int[]를 리턴해주세요.
배열의 i번째 요소는 모든 주스를 쏟는 작업이 완료되고 i번째 병에 남아 있는 키위 주스의 양입니다.


테스트케이스
```
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
```
