//효율성 검사까지 통과한 것
import java.util.*;

class Solution {
    public String[] solution(String[] players, String[] callings) {
        String[] answer = new String[players.length];
 
        Map<String, Integer> map = new HashMap<>();
        for (int i=0; i<players.length; i++) {map.put(players[i], i);}
        
        Map<Integer, String> reversedMap = new HashMap<>();
        for (int i=0; i<players.length; i++) {reversedMap.put(i, players[i]);}
     
        for (int i=0; i<callings.length; i++) {
            int currentIndex = map.get(callings[i]); //그 학생의 순위-1
            map.put(reversedMap.get(currentIndex-1), currentIndex); //이전 학생의 순위 +1
            reversedMap.put(currentIndex, reversedMap.get(currentIndex-1));
            map.put(callings[i], currentIndex-1); //현재 학생의 순위 -1
            reversedMap.put(currentIndex-1, callings[i]);
        }
        
        for (int i=0; i<players.length; i++) {answer[i] = reversedMap.get(i);}

        return answer;
    }
}


//답은 맞으나 시간 복잡도가 높아서 통과 못한 코드들
/*
import java.util.*;

class Solution {
    public String[] solution(String[] players, String[] callings) {
        String[] answer = new String[players.length];
        /*문제 이해
        계속 순서가 바껴야하므로 그냥 hashmap을 만들어서 [name, index] 를 담고,
        마지막에 sort하는 게 편할 것 같음
        */
        Map<String, Integer> map = new HashMap<>();
        for (int i=0; i<players.length; i++) {
            map.put(players[i], i);
        }
        
        for (int i=0; i<callings.length; i++) {
            map.put(getKey(map, map.get(callings[i])-1), map.get(callings[i]));
            map.put(callings[i], map.get(callings[i])-1);
        }
        
        for (int i=0; i<players.length; i++) {
            answer[i] = getKey(map, i);
        }

        
        return answer;
    }
    
    public static <K, V> K getKey(Map<K, V> map, V value){
        for (Map.Entry<K, V> entry: map.entrySet()){
            if (value.equals(entry.getValue())) {
                return entry.getKey();
            }
        }
        return null;
    }
}
*/
/*
import java.util.*;

class Solution {
    public String[] solution(String[] players, String[] callings) {

        List<String> list = new ArrayList<>();
        for (int i=0; i<players.length; i++) {list.add(players[i]);}
        
        for (int i=0; i<callings.length; i++) {
            int now = list.indexOf(callings[i]);
            Collections.swap(list, now-1, now);
        }
        return list.toArray(new String[players.length]);
    }
}
*/
/*
import java.util.*;

class Solution {
    public String[] solution(String[] players, String[] callings) {
        LinkedList<String> list = new LinkedList<>(Arrays.asList(players));

        for (String calling : callings) {
            int now = list.indexOf(calling);
            list.remove(now);
            list.add(now - 1, calling);
        }
        return list.toArray(new String[players.length]);
    }
}
*/
