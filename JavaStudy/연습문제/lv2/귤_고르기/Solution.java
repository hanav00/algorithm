import java.util.*;

class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        Map<Integer, Integer> tang = new HashMap<>();
        
        for (int i=0; i<tangerine.length; i++) {
            int size = tangerine[i];
            tang.put(size, tang.getOrDefault(size, 0) +1); //getOrDefault(key, 기본값): key값이 없으면 기본값으로 설정
        }
      
        List<Integer> tangCount = new ArrayList<>();
        for (Integer key : tang.keySet()) {
            tangCount.add(tang.get(key));
        }
        Collections.sort(tangCount, Collections.reverseOrder());

        int left = k;
        for (int i=0; i<tangCount.size(); i++){
            answer ++;
            if (tangCount.get(i) >= left) break;
            else left = left-tangCount.get(i);
        }
        
        return answer;
    }
}
