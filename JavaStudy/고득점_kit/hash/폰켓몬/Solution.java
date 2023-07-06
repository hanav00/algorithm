package hash.폰켓몬;

import java.util.*;

class Solution {
    public int solution(int[] nums) {
        
        //1. 배열의 값을 값:중복된 횟수 로 HashMap 만들기
        Map<Integer, Integer> map = new HashMap<Integer, Integer>();
        
        //2-1. map에 for문으로 값을 먼저 넣고, 값이 또 나오면 count+1을 함
        for(Integer str : nums) {
            Integer count = map.get(str);
            
            if(count == null) { //새로 나오는 key값이면 key:1회 로 설정
                map.put(str, 1);
            } else { //중복 key값이면 현재 count에 +1을 함
                map.put(str, count+1);
            }
        }
        
        //Check: Map 출력
        /*
        for (String key : map.keySet()) {
            System.out.println(key + ":" + map.get(key));
        }*/

        //3-1. HashMap의 길이가 n/2보다 작거나 같으면 result = HashMap의 길이
        int result = 0;
        if (map.size() <= (nums.length)/2) {
            result = map.size();
        } else { //3-2. n/2보다 크면 result = 배열의 길이/2
            result = (nums.length)/2;
        }
        
        return result;
    }
}