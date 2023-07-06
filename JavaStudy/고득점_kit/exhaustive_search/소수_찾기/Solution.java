package exhaustive_search.소수_찾기;

import java.util.*;

class Solution {
    
    HashSet<Integer> madeNumbers = new HashSet<>(); //숫자카드로 만든 숫자조합 담을 HashSet
    int answer = 0;
    
    public int solution(String numbers) {

        //1. 문자열을 하나씩 배열에 넣기
        String[] numbersArrayString = numbers.split("");
                //test
                /*for (int s : numbersArrayString) {
                    System.out.println(s);
                }*/
        int length = numbersArrayString.length; //숫자카드 개수
        boolean[] checked = new boolean[length]; //카드가 사용됐는지 체크용, 기본 false
        
        //2. 문자형 배열을 int형 배열로 변환
        int[] numbersArray = new int[length];
        for (int i = 0; i < length; i++) {
            numbersArray[i] = Integer.parseInt(numbersArrayString[i]);
        }

        //5. 카드를 한장씩 함수에 넣어줌
        for (int i=0; i<length; i++) {
            checked[i] = true; //처음 넣어준 카드를 checked 해주고
            makeNumber(checked, numbersArray[i], numbersArray); //조합기에 돌림
            checked[i] = false; //1을 다 넣고 7을 넣을 때 1의 checked를 다시 풀어줌
        }
        
                //HashSet 출력
                /*Iterator<Integer> iterSet = madeNumbers.iterator();
                while(iterSet.hasNext()) {
                    System.out.println(iterSet.next());
                }
                System.out.println("size:" + madeNumbers.size());*/

        //6. HashSet의 원소 하나하나를 isPrime에 넣어서 확인 -- 근데 1, 0 제외해야함
        Iterator<Integer> checkIsPrime = madeNumbers.iterator();
        while(checkIsPrime.hasNext()) {
            //System.out.println("checkIsPrime.next +1 is " + checkIsPrime.next() + 1);
            int currentNum = checkIsPrime.next();
            if(currentNum > 1) {
                int isItPrimeNum = isPrime(currentNum);
                if (isItPrimeNum == 1) {
                    answer ++;
                }
            }
            currentNum = 0;
        }
        
        //test
        /*Iterator<Integer> iterSet = primeNumbers.iterator();
                while(iterSet.hasNext()) {
                    System.out.println(iterSet.next());
        }*/

        return answer;
    }
    
    //3. 소수판별 함수 만들기
    public int isPrime(int n) {
        //System.out.println("prime func :" + n);
        for (int i = 2; i<=(int)Math.sqrt(n); i++) {
          if (n % i == 0) {
              return 0;
          }
        }
        return 1;
    }
    
    //4. 숫자카드 조합 만드는 함수 만들기
    public void makeNumber(boolean[] checked, int number, int[] numbersArray) { //이전에 조합한 숫자: result
        madeNumbers.add(number); //HashSet에 추가
        for (int i=0; i<numbersArray.length; i++) {
            if(!checked[i]) { //사용되지 않은 숫자카드가 있으면
                checked[i] = true; //그 카드를 맨 뒤에 붙여주고 true로 바꿈
                makeNumber(checked, number*10 + numbersArray[i], numbersArray);
                checked[i] =false; //그 카드를 넣고 다 돌렸으면 다시 checked를 풀어줌
            }
        }
        
    }
    
}
