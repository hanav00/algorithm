public class A0Paper{
    public String canBuild(int[] A){
        double sum = 0;
        for (int i=0; i<A.length; i++){
        	sum += (1/Math.pow(2,i))*A[i];
            if (sum >= 1) return "Possible";
        }
        return "Impossible";
    }
}
