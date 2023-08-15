public class AveragesOfThree{
    public int[] restore(int[] B){
		int[] A = new int[B.length+2];
        //first two is 0
        A[0] = 0; A[1] = 0;
        
        for (int i=0; i<B.length; i++){
        	 A[i+2] = B[i] * 3 - (A[i] + A[i+1]);
        }
        return A;
    }
}
