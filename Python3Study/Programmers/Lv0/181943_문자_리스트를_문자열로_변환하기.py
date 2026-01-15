"""
문제: 문자열 붙여서 출력하기
문자들이 담겨있는 배열 arr가 주어집니다.
arr의 원소들을 순서대로 이어 붙인 문자열을 return 하는 solution 함수를 작성해 주세요.

제한사항
- 1 ≤ arr의 길이 ≤ 200
- arr의 원소는 전부 알파벳 소문자로 이루어진 길이가 1인 문자열

입출력 예
arr = ["a","b","c"]
result = "abc"
"""

# 풀이 1) 반복문으로 직접 이어 붙이기
def solution_loop(arr):
    answer = ''
    for s in arr:
        answer += s
    return answer

# 풀이 2) join 사용
def solution_join(arr):
    return ''.join(arr)
