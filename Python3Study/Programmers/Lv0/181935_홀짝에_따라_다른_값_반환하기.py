"""
문제: 홀짝에 따라 다른 값 반환하기

양의 정수 n이 매개변수로 주어질 때,
- n이 홀수라면: n 이하의 홀수인 모든 양의 정수의 합을 return
- n이 짝수라면: n 이하의 짝수인 모든 양의 정수의 제곱의 합을 return

제한사항
- 1 ≤ n ≤ 100

입출력 예
n = 7  -> 16
n = 10 -> 220

설명
- n이 7(홀수)일 때: 1 + 3 + 5 + 7 = 16
- n이 10(짝수)일 때: 2^2 + 4^2 + 6^2 + 8^2 + 10^2 = 220
"""

def solution_loop(n):
    answer = 0

    # n이 짝수일 때: 짝수들의 제곱 합
    if n % 2 == 0:
        for i in range(0, n + 1, 2):
            answer += i ** 2

    # n이 홀수일 때: 홀수들의 합
    else:
        for i in range(1, n + 1, 2):
            answer += i

    return answer


def solution_sum(n):
    if n % 2 == 0:
        return sum(i ** 2 for i in range(0, n + 1, 2))
    else:
        return sum(range(1, n + 1, 2))
