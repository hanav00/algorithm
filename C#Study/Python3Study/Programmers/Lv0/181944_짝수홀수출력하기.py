"""
문제: 짝수/홀수 출력하기

자연수 n이 입력으로 주어졌을 때,
- n이 짝수이면 "n is even"
- n이 홀수이면 "n is odd"
를 출력하는 코드를 작성한다.

제한사항
- 1 ≤ n ≤ 1,000

입출력 예
입력: 100
출력: 100 is even

입력: 1
출력: 1 is odd
"""

a = int(input())
print(f"{a} is even" if a % 2 == 0 else f"{a} is odd")
