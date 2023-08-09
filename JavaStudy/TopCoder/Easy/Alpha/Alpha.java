public class Alpha{
    public int maxPref(String s){
        String abc = "abcdefghijklmnopqrstuvwxyz";
        for (int i = 0; i < s.length(); i++) {
        	if (abc.charAt(i) != s.charAt(i)) return i;
        }
        return s.length();
    }
}
