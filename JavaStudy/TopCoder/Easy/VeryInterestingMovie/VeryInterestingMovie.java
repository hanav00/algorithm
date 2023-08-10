import java.util.*;

public class VeryInterestingMovie{
    public int maximumPupils(String[] seats) {
        
        HashMap<Integer, Integer> canSeat = new HashMap<Integer, Integer>();
        int index = 1;
        
        for (int i=0; i<seats.length; i++){
            for (int j=0; j<seats[i].length(); j++){
                //"Y"로 시작하면 앉을 수 있는 자리에 넣기
                if(seats[i].charAt(j) == 'Y') {
                    //index가 존재하면 count +1, 아니면 새로 생성
                    if(canSeat.containsKey(index)){
                    	canSeat.put(index, canSeat.get(index)+1);
                    } else {
                        canSeat.put(index, 1);
                    }
                }
                if(seats[i].charAt(j) == 'N') {
                	index ++;
                }
            }
            index ++;
        }

        //가능한 자리에 앉을 수 있는 최대 학생 수 구하기
        int answer = 0;
        for (int values : canSeat.values()) {
            answer += (values+1)/2;
        }
        
    	return answer;
    }
}
