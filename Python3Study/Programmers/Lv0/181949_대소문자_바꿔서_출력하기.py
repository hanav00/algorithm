"""
문제: 대소문자 바꿔서 출력하기

문제 설명
영어 알파벳으로 이루어진 문자열 str이 주어집니다.
각 알파벳을 대문자는 소문자로, 소문자는 대문자로 변환해서 출력하는 코드를 작성해 보세요.

제한사항
- 1 ≤ str의 길이 ≤ 20
- str은 알파벳으로 이루어진 문자열입니다.

입출력 예
입력 #1
aBcDeFg

출력 #1
AbCdEfG
"""


# 방법 1) 직접 구현 (반복문)
s = input()
result = ""

for ch in s:
    if ch.islower():
        result += ch.upper()
    else:
        result += ch.lower()

print(result)

# ----------------------------
# 방법 2) 내장 함수 사용 (swapcase)
# s = input()
# print(s.swapcase())
