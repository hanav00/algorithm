import java.util.*;

public class InterestingParty {
    public int bestInvitation(String[] first, String[] second) {
        HashMap<String, Integer> hobby = new HashMap<>();
        for (int i = 0; i < first.length; i++) {
            if (hobby.containsKey(first[i])) {
                hobby.put(first[i], hobby.get(first[i]) + 1);
            } else {
                hobby.put(first[i], 1);
            }
        }
        for (int i = 0; i < second.length; i++) {
            if (hobby.containsKey(second[i])) {
                hobby.put(second[i], hobby.get(second[i]) + 1);
            } else {
                hobby.put(second[i], 1);
            }
        }
        int maxCnt = 1;
        for (int i : hobby.values()) {
            if (i > maxCnt) {
                maxCnt = i;
            }
        }
        return maxCnt;
    }
}
