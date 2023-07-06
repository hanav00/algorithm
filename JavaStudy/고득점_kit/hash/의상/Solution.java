package hash.의상;

import java.util.*;

class Solution {
    public int solution(String[][] clothes) {
        
        /*필요한 정보
        의상종류를 a, b, c ...x 라 두고
        각 종류의 개수를 a1, a2, a3 ... an 총 n개라 두면
        총 가지 수는
        (na+1)(nb+1)(nc+1) ... (nx+1) - 1 
        이때 -1은 전부 다 안입었을 경우
        즉 우리가 필요한 정보는 의상 종류의 수, 각 종류의 개수
        */
        
        //1. 의상의 종류와 개수를 담을 배열 생성 (의상 종류, 의상 개수)
        HashMap<String, Integer> map = new HashMap<>();
        
        //2. map 채워넣기
        for (int i = 0; i < clothes.length; i++) {
            //clothKind[i] = clothes[i][1];
            //처음 넣는 종류면
            if (map.get(clothes[i][1]) == null) {
                map.put(clothes[i][1], 1); //1개 새로 넣어줌
            }
            //이미 있는 종류면
            else if (map.get(clothes[i][1]) != null) {
                int x = map.get(clothes[i][1]);
                map.put(clothes[i][1], x+1); //+1
            }
        }

        //3. 의상 종류만 담은 배열 만들기 (중복 안되게)
        HashSet<String> hash = new HashSet<>();
        for (int i=0; i<clothes.length; i++) {
            hash.add(clothes[i][1]);
        } //중복 없애기 위해서 HashSet에 담아서 없애고 ..
        String[] array = hash.toArray(new String[hash.size()]); //인덱스로 불러오기 위해서 배열로 변환

        //System.out.println(Arrays.toString(array));
        //4.  각 종류의 개수 + 1 씩 곱해줌
        int answer = 1;
        for (int i = 0; i < map.size(); i++) {
            answer *= (map.get(array[i])+1);
        }  
        
        return answer -1 ;
    }
}
