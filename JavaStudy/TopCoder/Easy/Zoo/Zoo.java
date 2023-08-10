import java.util.*;

public class Zoo{
    public long theCount(int[] answers){
        int animals = answers.length;
        int[] count = new int[animals];
        
        //count 배열 생성. count[0]에는 answers 배열에 있는 0의 개수가 들어감
        for (int i=0; i<animals; i++){
            if (answers[i] >= animals) return 0;
        	count[answers[i]]++;
            if(count[answers[i]] > 2) return 0;
        }
        //System.out.println(Arrays.toString(count));
        
        //두 동물의 수가 같은 경우: count 배열이 {2,2,0,0}인 경우
        int same = 1;
        for (int i=0; i<(animals+1)/2; i++){
            if(count[i] != 2) {same = 0; break;}
        }
        if (same == 1) return (long)Math.pow(2,animals/2);
        
        //두 동물 수가 다른 경우: count배열에 무조건 1 존재
        int less = 0;
        for (int i=0; i<animals; i++){
            if(count[i] == 0) return 0;
            if(count[i] == 1) {less = i; break;}
        }
        
        //less 동물 수부터 쭉 1인지 확인
        for (int i=less; i<animals-less; i++){
        	if(count[i] != 1) return 0;
        }
        
        return (long)Math.pow(2,less+1);
    }
}
