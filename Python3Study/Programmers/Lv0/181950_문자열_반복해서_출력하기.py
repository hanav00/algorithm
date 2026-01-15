"""
문제: 문자열 반복해서 출력하기

문자열 str과 정수 n이 주어질 때,
str을 n번 반복한 문자열을 출력하는 코드를 작성한다.

제한사항
- 1 ≤ str의 길이 ≤ 10
- 1 ≤ n ≤ 5

입출력 예
입력:  string 5
출력:  stringstringstringstringstring
"""

s, n = input().split()
print(s * int(n))
