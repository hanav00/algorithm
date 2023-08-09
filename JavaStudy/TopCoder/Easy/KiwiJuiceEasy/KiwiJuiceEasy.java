public class KiwiJuiceEasy {
    public int[] thePouring(int[] capacities, int[] bottles, int[] fromId, int[] toId) {
        for (int i = 0; i < fromId.length; i++) {
            int fromB = fromId[i];
            int toB = toId[i];
            int pour = Math.min(capacities[toB] - bottles[toB], bottles[fromB]);
            bottles[fromB] -= pour;
            bottles[toB] += pour;
        }
        return bottles;
    }
}
